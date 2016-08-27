using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using Discord;

namespace BeakoBotNew
{
    public partial class botConnector : Form
    {
        /// <summary>
        /// The instance of the discord bot
        /// </summary>
        public static DiscordClient beakoBot = new DiscordClient();

        /// <summary>
        /// The flag for if the bot is connected
        /// </summary>
        public static bool IsConnected = false;
        
        /// <summary>
        /// The location for appdata
        /// </summary>
        private readonly string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        /// <summary>
        /// The target for other classes
        /// </summary>
        public static Server target = null;

        /// <summary>
        /// The cooldown for connecting
        /// </summary>
        private static bool hasConnectedCooldown = false;

        /// <summary>
        /// The constructor
        /// </summary>
        public botConnector()
        {
            InitializeComponent(); //Add the form components

            //Dis-allow them from maximizing it
            MaximizeBox = false;
        }

        /// <summary>
        /// Adds the input to the console
        /// </summary>
        /// <param name="input"></param>
        /// <param name="color"></param>
        public void AddConsoleLog(string input)
        {
            //Add the log with the time at the start
            outputWindow.Text += "[" + DateTime.Now.ToString("HH:mm") + "]: " + input + Environment.NewLine;        
        }

        /// <summary>
        /// This is the connect button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Disable the button to stop the user spamming connections
            button1.Enabled = false;

            //Check if they want to save their info to avoid typing again
            if (saveInfo.CheckState == CheckState.Checked)
            {
                //Write the users token to a text file for next time
                File.WriteAllText(appdata + "/cache.txt", loginBox.Text);
            }

            /*Do not use execute and wait, it will freeze the UI
            * Because it waits for the bot to be disconnected before moving on*/
            new Task(async () =>
            {
                try
                {
                    //Add console log to show connecting
                    AddConsoleLog("Connecting to token...");

                    //Wait for bot to be connected
                    await beakoBot.Connect(loginBox.Text);

                    await Task.Delay(1500); //Wait for some fields to fill

                    //Set the flag to true
                    IsConnected = true;

                    //Add the log to the console that the bot connected correctly and there are no errors
                    AddConsoleLog("Connected to bot [" + beakoBot.CurrentUser.Name + "] correctly.");

                    //Set it to true to let them disconnect
                    button2.Enabled = true;

                    //Set it to readonly so they can't edit the token while connected
                    loginBox.ReadOnly = true;

                    //Set it to disable to stop them from changing it while the bot is online
                    saveInfo.Enabled = false;

                    //Add the message recieved async method to the event handler
                    beakoBot.MessageReceived += onMessageRecieved.beakoMessageRecieved;
                }
                catch (Exception) //Catch any errors that raise while connecting etc
                {
                    //Show the error in the debug log
                    AddConsoleLog("Something went wrong while connecting, try restarting the program or re-installing.");
                }
            }).Start();
        }

        /// <summary>
        /// This is the disconnect button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            new Task(async () =>
            {
                try
                {
                    //Disconnect from the bot
                    await beakoBot.Disconnect();

                    //Add the log to the console that the bot disconnected correctly
                    AddConsoleLog("Disconnected from the current token correctly.");

                    #region Button swapping 

                    //Re-enable the button to let them connect again
                    button1.Enabled = true;

                    //Disable the disconnect button
                    button2.Enabled = false;

                    //Set it to not readonly so they can edit the token
                    loginBox.ReadOnly = false;

                    //Set it to enabled to allow editing
                    saveInfo.Enabled = true;

                    //Set the count of all the servers as offline to show the user isnt connected
                    serverCountLabel.Text = "Server count: Offline";

                    //Set to red to show disabled
                    serverCountLabel.ForeColor = System.Drawing.Color.Red;

                    //Set to red to show disabled
                    userCountLabel.ForeColor = System.Drawing.Color.Red;

                    //Set the amount of users in the bots scope as offline to show disconnected
                    userCountLabel.Text = "User count: Offline";

                    #endregion
                }
                catch(Exception) //Catch any exceptions that raise while disconnecting
                {
                    //Add a log to the console that something has went wrong
                    AddConsoleLog("Something went wrong while disconnecting. Try killing the process.");
                }
                finally
                {
                    //Set the connection to false
                    IsConnected = false;
                }

            }).Start();
        }

        /// <summary>
        /// The constructor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            ///<summary>
            ///All constructors are here
            ///</summary>

            #region /// File reading

            //Set it to disabled to stop them from disconnecting from nothing
            button2.Enabled = false;

            //If the cache file exists
            if (File.Exists(appdata + "/cache.txt"))
            {
                //Put the token in the slot to save the user copy and pasting
                loginBox.Text = File.ReadAllText(appdata + "/cache.txt");

                //Set the checked to true to show the user it saved from last time
                saveInfo.Checked = true;
            }
            else
            {
                //Create the text file at runtime to stop errors later if it doesnt exist
                File.Create(appdata + "/cache.txt").Close();
            }

            #endregion

            //A new task for updating values
            new Task(async () =>
            {
                //Constant loop for updating values
                while (true)
                {
                    try
                    {
                        //Wait for 1 second before continuing to stop spam
                        await Task.Delay(5000);

                        //If the bot is connected (to avoid null errors)
                        if (IsConnected)
                        {
                            //Set the count of all the servers
                            serverCountLabel.Text = "Server count: " + beakoBot.Servers.Count();

                            //Set to green to show enabled
                            serverCountLabel.ForeColor = System.Drawing.Color.Green;

                            //Set to green to show enabled
                            userCountLabel.ForeColor = System.Drawing.Color.Green;

                            //Set the amount of users in the bots scope
                            userCountLabel.Text = "User count: " + beakoBot.Servers.Select(x => x.UserCount).Sum();

                            //A flag so it doesnt automatically open a form
                            hasConnectedCooldown = true;

                            //Add all the servers to the bot to show which ones the bot is in and also the amount of users
                            serverListBox.DataSource = beakoBot.Servers.Select(x => x.Name).ToList();

                            //Disable the flag to allow form selection
                            hasConnectedCooldown = false;
                        }
                    }
                    catch(Exception)
                    {
                        //Insert capture logs here
                    }
                }
            }).Start();
        }

        /// <summary>
        /// The server browser selector
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serverListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If the user hasnt just connected
            if (!hasConnectedCooldown)
            {
                //The selected item the user currently has
                string selectedItem = serverListBox.SelectedItem.ToString();

                //Set the default discord server
                target = beakoBot.Servers.Single(x => x.Name == selectedItem);

                //Show the selected servers information in the new form
                serverBrowse activeForm = new serverBrowse();

                activeForm.Show(); //Display the form
            }
        }

        /// <summary>
        /// Change the preferences of the bot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void preferences_Click(object sender, EventArgs e)
        {
            //If the bot is not connected
            if (!IsConnected)
            {
                //Show an error message
                MessageBox.Show("You aren't connected to any bot");
                return; //Return back to calling point
            }
            //If the user is connected to a bot
            else
            {
                //Create a new instance of the configuration class
                botprefs configuration = new botprefs();

                //Show the new instance's form
                configuration.Show();
            }
        }
    }
}