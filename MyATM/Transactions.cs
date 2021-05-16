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
    public partial class Transactions : Form
    {
        private string userID;
        private XDocument atmUsers;

        public Transactions(string userID, XDocument atmUsers)
        {
            InitializeComponent();

            this.userID = userID;
            this.atmUsers = atmUsers;

            var userTransactions = from x in atmUsers.Descendants("transaction")
                                   where x.Parent.Parent.Descendants("id").First().Value == userID
                                   select new
                                   {
                                       date = x.Descendants("date").First().Value,
                                       description = x.Descendants("description").First().Value,
                                       amount = x.Descendants("amount").First().Value,
                                       accountBalance = x.Descendants("accountBalance").First().Value
                                   };
            BindingSource bs = new BindingSource();
            bs.DataSource = userTransactions.Reverse().Take(5);
            transactionsGrid.DataSource = bs;
        }

        private void returnToDashButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
