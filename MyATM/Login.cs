using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyATM
{
    public partial class Login : Form
    {

        private XDocument atmUsers;
        public string UserID { get; set; }

        public Login(XDocument atmUsers)
        {
            InitializeComponent();
            this.atmUsers = atmUsers;
            UserID = string.Empty;
            //HACK: login details
            creditCardNumberInput.Text = "1234-1234-1234-1234";
            pinInput.Text = "1234";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var userID = userExists(creditCardNumberInput.Text, pinInput.Text);
            if (!string.IsNullOrEmpty(userID))
            {
                UserID = userID;
                errorInfo.Text = string.Empty;
                errorInfo.Visible = false;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                errorInfo.Text = "Invalid login information!";
                errorInfo.Visible = true;
            }
        }

        private string userExists(string cardNumber, string pin)
        {
            var users = from x in atmUsers.Descendants("atmUsers")
                        select new
                        {
                            cardNumber = x.Descendants("cardNumber").First().Value,
                            pin = x.Descendants("pin").First().Value,
                            id = x.Descendants("id").First().Value
                        };

            var userID = string.Empty;
            foreach (var user in users)
            {
                if (user.cardNumber == cardNumber && user.pin == pin)
                {
                    userID = user.id;
                }
            }
            return userID;

        }
    }
}
