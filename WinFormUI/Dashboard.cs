using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        public static MessageModel message;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void LaunchMessage_Click(object sender, EventArgs e)
        {
            var messageCreationForm = new MessageCreation();
            messageCreationForm.StartPosition = FormStartPosition.Manual;
            messageCreationForm.Location = new Point(this.Location.X + 10, this.Location.Y + this.Height + 20);
            messageCreationForm.Show(this);
        }

        private void LaunchSubDashboard_Click(object sender, EventArgs e)
        {
            var subDashBoard = new SubDashboard();
            subDashBoard.Show();
        }

        private void Dashboard_Activated(object sender, EventArgs e)
        {
            if (message != null && !string.IsNullOrEmpty(message.Message))
                messageText.Text = message.Message;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
