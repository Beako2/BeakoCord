using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Text.RegularExpressions;
using Discord;
using System.Drawing;
using System.Threading.Tasks;

/// <summary>
/// BeakoBotNew
/// </summary>
namespace BeakoBotNew
{
    /// <summary>
    /// When the bot recieves a message
    /// </summary>
    class onMessageRecieved
    {
        /// <summary>
        /// Is called when the bot
        /// recieves a message from
        /// a group chat or pm/dm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static async void beakoMessageRecieved(object sender, MessageEventArgs e)
        {
            ///<summary>
            ///MessageEventArgs contains
            ///<seealso cref="Server"/>
            ///<seealso cref="User"/>
            ///<seealso cref="Channel"/>
            ///</summary>
            ///<exception cref="NullReferenceException">
            ///Sometimes a null reference might thrown, this
            ///is because the user might have a null name and or
            ///other property in some instance
            ///</exception>

            ///<example>
            /// (!users online),
            /// only the !users will be read
            ///</example>
            //If the user isnt a bot, to avoid spam loops
            if (!e.User.IsBot && e.Server != null)
            {
                ///<summary>
                ///These are the variables that
                ///are used inside of the switch statement
                ///</summary>              
                #region local variables
                //Get the bots user object for things like comparing permissions etc
                User beakoObject = botConnector.beakoBot.CurrentUser.Name.ToUser(e.Server.Users);

                //A cache of the lowercase version to avoid swapping characters
                string lower = e.Message.Text.ToLower();
                #endregion

                try
                {
                    ///<summary>
                    ///The commands for the bot
                    ///</summary>
                    #region commands

                    //Example command
                    #region Online/Idle/Offline command
                    //If their string starts with who, or users, and ends with one of the parameters for status
                    if (Regex.IsMatch(lower, @"^\>(user|users)\s+(online|idle|away|offline)"))
                    {
                        //A new prediction value
                        Predicate<User> f = null;

                        //Create a new predicate based on the values the user asked, compares the status of the user to the one asked via user
                        //If the user selected the online keyword, compare the user status data to find users that are online
                        f = Regex.IsMatch(lower, @"online") ? new Predicate<User>((User g) => g.Status == UserStatus.Online) :

                            //If the user selected the idle or away keyword, return users that are idle
                            Regex.IsMatch(lower, @"idle|away") ? new Predicate<User>((User h) => h.Status == UserStatus.Idle) :

                            //Return users that are offline if the user picked the offline keyword
                            Regex.IsMatch(lower, @"offline") ? new Predicate<User>((User j) => j.Status == UserStatus.Offline)

                            //Return as null if something went wrong
                            : null;

                        //If the predicate is not null (this should never happen)
                        if (f != null)
                        {
                            //Return all the users that match with the predicates terms
                            User[] types = e.Server.Users.ReturnUsersWith(f).ToArray();

                            //If more than one user returned and the types is not null
                            if (types.Length > 0)
                            {
                                //Send the message with the users
                                await e.Channel.SendMessage("I found: " + string.Join(", ", types.Select(x => "`" + x.Name + "`").ToArray()));
                            }
                            else
                            {
                                //Send an error message showing the users could not be found
                                await e.Channel.SendMessage("No users found D:");
                            }
                        }
                    }
                    #endregion

                    #endregion
                }
                catch (Exception ex)
                {
                    
                }
            }

            ///<summary>
            ///Returns from the method incase
            ///a bot interacts with another bot
            ///and causes a chain reaction of spam
            ///</summary>
            #region Anti-Bot spam
            //Else if the user is a bot
            else
            {
                //Return to avoid spamming
                return;
            }
            #endregion
        }
    }
}
