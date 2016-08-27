using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discord;
using System.Diagnostics;
using System.IO;

/// <summary>
/// Run all discord operations
/// inside of Async to avoid locking 
/// up the GUI thread with a looping
/// synchronous operation
/// 
/// <seealso cref="Server"/>
/// <!--Fill out the server field-->
/// </summary>

namespace BeakoBotNew
{
    /// <summary>
    /// The server browser form
    /// </summary>
    public partial class serverBrowse : Form
    {
        /// <summary>
        /// The server instance
        /// </summary>
        public Server server { get; private set; } = botConnector.target;

        #region original constructor
        /// <summary>
        /// Constructor for the server browser
        /// </summary>
        public serverBrowse()
        {
            InitializeComponent(); //Initialize the form
        }
        #endregion

        #region form constructor
        /// <summary>
        /// Loads the properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serverBrowse_Load(object sender, EventArgs e)
        {
            //Dis-allow them from maximizing it
            MaximizeBox = false;

            //Set the name to the parameter passed in.
            servername.Text = server.Name + " || " + server.UserCount + " Users || " + server.ChannelCount + " Channels";

            //Fill the box with all the users names
            userListBox.DataSource = server.Users.Select(x => x.Name ).ToList();

            //Fill the box with all the names of the servers
            channelListBox.DataSource = server.AllChannels.Select(x => x.Name).ToList();

            //Get the bots user object to see its permissions to disable buttons
            User bot = "Beako".ToUser(server.Users);

            //If the bot can send messages, enable the button, else disable
            channelSendButton.Enabled = bot.ServerPermissions.SendMessages ? true : false;

            //If the bot can manage channels, enable the button else disable
            delChannel.Enabled = bot.ServerPermissions.ManageChannels ? true : false;

            //If the bot can kick people, enable the button, else disable
            kickButton.Enabled = bot.ServerPermissions.KickMembers ? true : false;

            //If the bot can ban people, enable the button, else disable
            banButton.Enabled = bot.ServerPermissions.BanMembers ? true : false;
        }
        #endregion

        #region leaving servers
        /// <summary>
        /// The Button for leaving a server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void leaveServerButton_Click(object sender, EventArgs e)
        {
            //New async task to leave the server
            new Task(async () =>
            {
                //Wait until the bot has left
                await server.Leave();
            }).Start();
           
            //Close the current form
            this.Close();
        }
        #endregion

        #region send message button
        /// <summary>
        /// Sending the message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void channelSendButton_Click(object sender, EventArgs e)
        {
            //If the user has selected a channel
            if (channelListBox.SelectedItem != null)
            {
                //Get the currently selected item
                string target = channelListBox.SelectedItem.ToString();

                //Retrieve the channel from its name
                Channel discordChannel = target.ToChannel(server.AllChannels);

                //If the channel is not a voice channel
                if (!discordChannel.Type.Value.Contains("voice"))
                {
                    //New async task to send the message on the back thread
                    new Task(async () =>
                    {
                        //Send the message on a new thread to avoid GUI Lockdown
                        await discordChannel.SendMessage(channelSendBox.Text);
                    }).Start();
                }
                else
                {
                    //Show an error stating you cannot send messages in a voice channel
                    MessageBox.Show("You cannot send a message in a voice channel");
                }
            }
            else
            {
                //Display an error message that they shoukd pick a channel
                MessageBox.Show("You must specify a channel in the channel list to send a message to.");
            }
        }
        #endregion

        #region history save
        /// <summary>
        /// Saving the messages in the channel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msgHistorySave_Click(object sender, EventArgs e)
        {
            //Get the channel of the selected item
            Channel toSave = channelListBox.SelectedItem.ToString().ToChannel(server.AllChannels);

            //Download the messages on the back thread
            new Task(async () =>
            {
                //Download all the discord messages
                Discord.Message[] messages = await toSave.DownloadMessages();

                //Download the messages then write them to a file
                File.AppendAllLines("messages.txt", messages.Select
                    (x => x.User.Name + ": " + Regex.Replace(x.Text, @"\`|\@", "")).ToArray());

                //Start a new process to open the text
                Process.Start("messages.txt");

                //Wait 8 seconds before deleting to let it load
                await Task.Delay(8000);

                //Delete the text file to conserve space
                File.Delete("messages.txt");
            }).Start();
        }
        #endregion

        #region networkproperties
        /// <summary>
        /// Server information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serverNetwork_Click(object sender, EventArgs e)
        {
            //Show information about the server in a text box
            MessageBox.Show("Region: " + server.Region.Name + "\nHostname: " + server.Region.Hostname +
                "\nID: " + server.Region.Id + "\nPort: " + server.Region.Port + "\nUsers: " + server.UserCount +
                "\nChannels: " + server.ChannelCount + "\nOwner: " + server.Owner.Name);
        }
        #endregion

        #region Kick button
        /// <summary>
        /// The kick button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kickButton_Click(object sender, EventArgs e)
        {
            //The name of the user
            string username = userListBox.SelectedItem.ToString();

            //A new task for awaiting the kick
            new Task(async () =>
            {
                //Kick the user
                await username.ToUser(server.Users).Kick();
            }).Start();
        }
        #endregion

        #region Ban button
        /// <summary>
        /// The ban button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void banButton_Click(object sender, EventArgs e)
        {
            //A new async member to ban on
            new Task(async () =>
            {
                //Ban the person
                await server.Ban(userListBox.SelectedItem.ToString().ToUser(server.Users));
            }).Start();
        }
        #endregion

        #region delete channel
        /// <summary>
        /// The delete channel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delChannel_Click(object sender, EventArgs e)
        {
            //A new task for awaiting the channel deletion
            new Task(async () =>
            {
                //delete the channel
                await channelListBox.SelectedItem.ToString().ToChannel(server.AllChannels).Delete();
            }).Start();
        }
        #endregion

        #region invite
        /// <summary>
        /// the invite button creator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void invite_Click(object sender, EventArgs e)
        {
            MessageBox.Show((await server.CreateInvite()).Url);
        }
        #endregion
    }
}
