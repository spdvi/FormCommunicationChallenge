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
    public partial class SubDashboard : Form
    {
        public static MessageModel message;

        public SubDashboard()
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

        private void SubDashboard_Activated(object sender, EventArgs e)
        {
            if (Dashboard.message != null && !string.IsNullOrEmpty(Dashboard.message.Message))
                nameAndMessageText.Text = $"{Dashboard.message.Name}: {Dashboard.message.Message}";
        }
    }
}
