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
    public partial class MainDash : Form
    {

        private string userID;
        private XDocument atmUsers;

        public MainDash()
        {
            // this.atmUsers = XDocument.Load(@"C:\Users\VsiTeStudent\Documents\Visual Studio 2013\Projects\MyATM\atmUsers.xml");
            InitializeComponent();
            this.Visible = false;
            Login login = new Login(atmUsers);
            if (login.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.userID = login.UserID;
                login.Dispose();
                setWelcomeMessage();
                this.Visible = true;
            }
        }

        private void setWelcomeMessage()
        {
            var users = from x in atmUsers.Descendants("atmUsers")
                        where x.Descendants("id").First().Value == userID
                        select new
                        {
                            name = x.Descendants("name").First().Value,
                            lastName = x.Descendants("lastName").First().Value
                        };
            userHelloLabel.Text = "Welcome " + users.First().name + " " + users.First().lastName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transactions transactionsForm = new Transactions(this.userID, this.atmUsers);
            transactionsForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountBalance AccBal = new AccountBalance(this.userID, this.atmUsers);
            AccBal.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Withdraw withdrawForm = new Withdraw(this.userID, this.atmUsers);
            withdrawForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
