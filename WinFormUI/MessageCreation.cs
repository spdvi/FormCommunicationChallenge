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
    public partial class MessageCreation : Form
    {
        public MessageCreation()
        {
            InitializeComponent();
        }

        private void CreateMessage_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(messageText.Text) && !string.IsNullOrEmpty(nameText.Text))
            {
                MessageModel message = new MessageModel()
                {
                    Name = nameText.Text,
                    Message = messageText.Text
                };

                if (this.Owner.Name == "Dashboard")
                {
                    Dashboard.message = message;
                }
                else if (this.Owner.Name == "SubDashboard")
                {
                    SubDashboard.message = message;
                }
            }
            this.Close();
        }
    }
}
