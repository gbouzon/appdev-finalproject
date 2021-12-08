using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tivi
{
    public partial class BudgetingForm : Form
    {
        private User user;
        // List to hold all the information about the entries
        List<Product> productList = new List<Product>();
       
        // Bools for entry validation
        bool nameIsGood = false;
        bool costIsGood = false;
        bool genreIsGood = false;   
        public BudgetingForm(User user)
        {
            InitializeComponent();
            this.user = user;
            this.BackColor = ColorTranslator.FromHtml(user.Colour);
            // Sets the error label to blank on startup
            costErrorLabel.Text = "";
            nameErrorLabel.Text = "";
            radioButtonErrorLabel.Text = "";

            // Sets the default for the text labels
            billsTotalLbl.Text = "Bills: ";
            foodTotalLbl.Text = "Food: ";
            autoTotalLbl.Text = "Auto: ";
            entertainmentTotalLbl.Text = "Entertainment: ";
            investmentTotalLbl.Text = "Investments: ";
            miscTotalLbl.Text = "Misc: ";

            pieChart.Titles.Add("Budget Chart");

            // Sets the default for the pie chat
            pieChart.Series["s1"].IsValueShownAsLabel = true;
            pieChart.Series["s1"].Points.AddXY("Bills", "1");
            pieChart.Series["s1"].Points.AddXY("Food", "1");
            pieChart.Series["s1"].Points.AddXY("Auto", "1");
            pieChart.Series["s1"].Points.AddXY("Entertainment", "1");
            pieChart.Series["s1"].Points.AddXY("Investments", "1");
            pieChart.Series["s1"].Points.AddXY("Miscellaneous", "1");

            this.Text = "Cost Evaluater";
        }

        private void BudgetingForm_Load(object sender, EventArgs e)
        {

        }

        // Prints out the entire pro
        private static void DisplayProducts(List<Product>productList, TextBox outputBox)
        {
            string formattedString2;

            formattedString2 = String.Format("{0,-25}-{1,-40}-{2,-20}", "Name", "Description", "Price");

            outputBox.AppendText("Costs      " + DateTime.Now.ToString("MM/dd/yyyy hh:mm tt") + Environment.NewLine);
            outputBox.AppendText("=============================" + Environment.NewLine);

            foreach (Product i in productList)
            {
                outputBox.AppendText(String.Format("{0,-25}-{1,-40}${2,-20:0.00}", i.GetName(), i.GetDescription(), i.GetPrice()) + Environment.NewLine);   

            }

            outputBox.AppendText("" + Environment.NewLine);
        
        }

        // Adds a filled out Product object when all the entries are valid
        private void addDataButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length == 0)
            {
                nameErrorLabel.Text = "Not a valid name";
                nameIsGood = false;
            }
            else
            {
                nameIsGood = true;
                nameErrorLabel.Text = "";
            }

            try
            {
                Convert.ToDouble(costTextBox.Text);
                costIsGood = true;
                costErrorLabel.Text = "";
            }

            catch (Exception ex)
            {
                costErrorLabel.Text = "Not a valid number";
                costIsGood = false;
            }

            foreach (RadioButton item in choicePanel.Controls)
            {
                if (item.Checked)
                {
                    genreIsGood = true;
                    radioButtonErrorLabel.Text = "";
                }
            }

            // if every entry is valid it adds a product object to a list
            if (nameIsGood && costIsGood && genreIsGood)
            {
                string productName;
                string productDescription;
                double productPrice;

                productPrice = Convert.ToDouble(costTextBox.Text);
                costTextBox.Text = "";
                costErrorLabel.Text = "";

                productName = nameTextBox.Text;
                nameTextBox.Text = "";
                nameErrorLabel.Text = "";

                productDescription = RadioLooper();

                // Uses the asigned values and created a Product with them
                Product newProduct = new Product(productName, productDescription, productPrice);

                productList.Add(newProduct);
            }

            // Display errors for radiobuttons
            else if (genreIsGood == false)
            {
                radioButtonErrorLabel.Text = "Please select a category";

            }
            
        }

        // Loops through the RadioButton in Panel and returns the Text value 
        private string RadioLooper()
        {
            foreach (RadioButton item in choicePanel.Controls)
            {
                if (item.Checked)
                {
                    radioButtonErrorLabel.Text = "";
                    return item.Text;
                }
               
            }
            return "";
        }

        // generates a list and pie chat 
        private void generateReportButton_Click(object sender, EventArgs e)
        {
            double autoCost = 0;
            double billCost = 0;
            double foodCost = 0;
            double entertainmentCost = 0;
            double investmentCost = 0;
            double miscellaneousCost = 0;
            double sumOfAll = 0;

            // Assignes the total cost for each category
            foreach (Product i in productList)
            {
                if (i.GetDescription() == "Transportation")
                {
                    autoCost = autoCost + i.GetPrice();
                }
                if (i.GetDescription() == "Bills")
                {
                    billCost = billCost + i.GetPrice();
                }
                if (i.GetDescription() == "Food")
                {
                    foodCost = foodCost + i.GetPrice();
                }
                if (i.GetDescription() == "Entertainment")
                {
                    entertainmentCost = entertainmentCost + i.GetPrice();
                }
                if (i.GetDescription() == "Investments")
                {
                    investmentCost = investmentCost + i.GetPrice();
                }
                if (i.GetDescription() == "Miscellaneous")
                {
                    miscellaneousCost = miscellaneousCost + i.GetPrice();
                }
            }

                // Sums all the costs up
                sumOfAll = autoCost + billCost + foodCost + entertainmentCost + investmentCost + miscellaneousCost;

                DisplayProducts(productList, outputBox);

                pieChart.Series["s1"].Points.Clear();


                // Plots down the updated data points
                // Stes the labels with the total dollar amount and percentage that the user spent per category

                if (billCost != 0) 
                {
                    pieChart.Series["s1"].Points.AddXY("Bills", Convert.ToString(billCost));
                    billsTotalLbl.Text = String.Format("Bills: ${0:0.00} ({1:0.00}%)", billCost, (billCost / sumOfAll) * 100);
                }
                if (foodCost != 0)
                {
                    pieChart.Series["s1"].Points.AddXY("Food", Convert.ToString(foodCost));
                    foodTotalLbl.Text = String.Format("Food: ${0:0.00} ({1:0.00}%)", foodCost, (foodCost / sumOfAll) * 100);
                }

                if (autoCost != 0)
                {
                    pieChart.Series["s1"].Points.AddXY("Auto", Convert.ToString(autoCost));
                    foodTotalLbl.Text = String.Format("Auto: ${0:0.00} ({1:0.00}%)", autoCost, (autoCost / sumOfAll) * 100);
                }

                if (entertainmentCost != 0)
                {
                    pieChart.Series["s1"].Points.AddXY("Entertainment", Convert.ToString(entertainmentCost));
                    entertainmentTotalLbl.Text = String.Format("Entertainment: ${0:0.00} ({1:0.00}%)", entertainmentCost, (entertainmentCost / sumOfAll) * 100);
                }
                if (investmentCost != 0)
                {
                    pieChart.Series["s1"].Points.AddXY("Auto", Convert.ToString(investmentCost));
                    investmentTotalLbl.Text = String.Format("Investments: ${0:0.00} ({1:0.00}%)", investmentCost, (investmentCost / sumOfAll) * 100);
                }

                if (miscellaneousCost != 0)
                {
                    pieChart.Series["s1"].Points.AddXY("Auto", Convert.ToString(miscellaneousCost));
                    miscTotalLbl.Text = String.Format("Miscellaneuous: ${0:0.00} ({1:0.00}%)", miscellaneousCost, (miscellaneousCost / sumOfAll) * 100);
                }

            

        }

        private void pieChart_Click(object sender, EventArgs e)
        {

        }

        private void errorLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void returnToMainMenu_Click(object sender, EventArgs e)
        {
            OldUserForm form = new OldUserForm(this.user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void costErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameErrorLabel_Click(object sender, EventArgs e)
        {

        }
    }
    class Product
    {
        private string name;
        private string description;
        private double price;

        public Product(string productName, string productDescription, double productPrice)
        {
            name = productName;
            description = productDescription;
            price = productPrice;
        }

        public string GetName()
        {
            return name;
        }

        public string GetDescription()
        {
            return description;
        }

        public double GetPrice()
        {
           return price;
        }
    }
}
