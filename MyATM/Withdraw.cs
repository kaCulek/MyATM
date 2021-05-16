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
    public partial class Withdraw : Form
    {
        private string userID;
        private XDocument atmUsers;
        public Withdraw(string userID, XDocument atmUsers)
        {
            InitializeComponent();
            this.userID = userID;
            this.atmUsers = atmUsers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            withdrawMoney(10);
        }

        private void withdrawMoney(int amount)
        {

            if (amount > 1000)
            {
                MessageBox.Show("Maximum withdraw amonut is 1000 $.");
            }
            else
            {

                var userTransactions = from x in atmUsers.Descendants("transaction")
                                       where x.Parent.Parent.Descendants("id").First().Value == userID
                                       select new
                                       {
                                           date = x.Descendants("date").Last().Value,
                                           description = x.Descendants("description").Last().Value,
                                           amount = x.Descendants("amount").Last().Value,
                                           accountBalance = x.Descendants("accountBalance").Last().Value
                                       };
                var newBalance = Int32.Parse(userTransactions.Last().accountBalance) - amount;

                var transactionsDoneToday = 0;
                foreach (var tran in userTransactions)
                {
                    if (tran.date.Contains(DateTime.Today.ToString("dd.MM.yyyy.")))
                    {
                        transactionsDoneToday++;
                    }
                }

                if (transactionsDoneToday > 10)
                {
                    if (MessageBox.Show("You have reached the maximum number of transactions today.") == System.Windows.Forms.DialogResult.OK)
                    {
                        this.Dispose();
                    }
                    
                }else if (newBalance < 0)
                {
                    MessageBox.Show("Not enough money left on the account try a lower amount.");
                }
                else
                {
                    var newTransaction = new XElement("transaction",
                        new XElement("date", DateTime.Now.ToString("dd.MM.yyyy. HH:mm:ss")),
                        new XElement("description", "ATM withdraw"),
                        new XElement("amount", amount),
                        new XElement("accountBalance", newBalance)
                    );
                    var userTransactions2 = from x in atmUsers.Descendants("transactions")
                                            where x.Parent.Parent.Descendants("id").First().Value == userID
                                            select x;
                    userTransactions2.First().Add(newTransaction);
                    atmUsers.Save(@"C:\Users\VsiTeStudent\Documents\Visual Studio 2013\Projects\MyATM\atmUsers.xml");
                    //TODO : MainDash dash = new MainDash(this.userID, this.atmUsers);
                    this.Dispose();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            withdrawMoney(20);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            withdrawMoney(30);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            withdrawMoney(50);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            withdrawMoney(100);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            withdrawMoney(200);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            withdrawMoney(300);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WithdrawAmountInput input = new WithdrawAmountInput();
            if (input.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var inputAmount = input.GetWithdrawAmount();
                withdrawMoney(inputAmount);
            }
        }

    }
}
