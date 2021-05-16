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
    public partial class AccountBalance : Form
    {
        private string userID;
        private XDocument atmUsers;
        public AccountBalance(string userID, XDocument atmUsers)
        {
            InitializeComponent();
            this.userID = userID;
            this.atmUsers = atmUsers;
            var userTransactions = from x in atmUsers.Descendants("transaction")
                                   where x.Parent.Parent.Descendants("id").First().Value == userID
                                   select new
                                   {
                                       date = x.Descendants("date").Last().Value,
                                       description = x.Descendants("description").Last().Value,
                                       amount = x.Descendants("amount").Last().Value,
                                       accountBalance = x.Descendants("accountBalance").Last().Value
                                   };
            textBox1.Text = DateTime.Today.ToString("dd.MM.yyyy.");
            textBox2.Text = userTransactions.Last().accountBalance;
        }
        
        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
