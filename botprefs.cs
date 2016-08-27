using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

/// <summary>
/// Beako bot new project
/// </summary>
namespace BeakoBotNew
{
    /// <summary>
    /// The botprefs class & form
    /// </summary>
    public partial class botprefs : Form
    {
        /// <summary>
        /// The form constructor
        /// </summary>
        public botprefs()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botprefs_Load(object sender, EventArgs e)
        {
            //Set the title of the form
            botnamePrefs.Text = botConnector.beakoBot.CurrentUser.Name + " Configuration";
        }

        /// <summary>
        /// Choose an image to set profile pic to
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pickImage_Click(object sender, EventArgs e)
        {
            //Choose an image
            using (OpenFileDialog pathway = new OpenFileDialog())
            {
                //Set the title of the file choose
                pathway.Title = "Choose an image file";

                //Set the filter to image files only
                pathway.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

                //When the user picks a file
                if (pathway.ShowDialog() == DialogResult.OK)
                {
                    //Get the path
                    profilepicbox.Text = pathway.FileName.ToString();
                }
            }
        }

        /// <summary>
        /// Saves the properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void saveButton_Click(object sender, EventArgs e)
        {
            //If the bot characters length is more than 1 and the string is not empty
            if (Regex.IsMatch(profilepicbox.Text, @"\w+\\\w+") && profilepicbox.Text != string.Empty)
            {
                //Set the bots new profile picture
                await botConnector.beakoBot.CurrentUser.Edit(avatarType: Discord.ImageType.Png, avatar: File.Open(profilepicbox.Text, FileMode.Open));
            }

            //if the name field is more than 2 characters
            if (Regex.IsMatch(botnamebox.Text, @"\w{2,}"))
            {
                //Set the name
                await botConnector.beakoBot.CurrentUser.Edit(username: botnamebox.Text);
            }

            //if the game field is more than 2 characters
            if (Regex.IsMatch(gamenamebox.Text, @"\w{2,}"))
            {
                botConnector.beakoBot.SetGame(gamenamebox.Text);
            }

            //Show a confirmation
            MessageBox.Show("Changes saved");
        }
    }
}
