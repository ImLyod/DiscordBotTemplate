using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordBotTemplate
{
    public partial class Bot : Form
    {

        // Allow Form to be accessed from the outside
        public static Bot UI;

        public Bot()
        {
            InitializeComponent();
            UI = this;
        }

        private void Bot_Load(object sender, EventArgs e)
        {
            // Set Default Texst for Status
            CenterStatusText("Offline");
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            // Set Connection Status
            CenterStatusText("Connecting");

            // Start up the Bot Discord Bot
            Discord.Main Discord = new Discord.Main();
        }

        // Set Text to Center of Panel
        public void CenterStatusText(string arg)
        {
            // Set the status to whatever arg is
            Status_Label.Text = arg;

            // Center the label.
            Status_Label.Location = new Point((Status_Panel.Size.Width - Status_Label.Size.Width) / 2, (Status_Panel.Size.Height - Status_Label.Size.Height) / 2);
        }
    }
}
