namespace Tivi
{
    partial class FinanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.returnToMainMenu = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.choicePanel = new System.Windows.Forms.Panel();
            this.miscellanousButton = new System.Windows.Forms.RadioButton();
            this.investmentButton = new System.Windows.Forms.RadioButton();
            this.entertainmentButton = new System.Windows.Forms.RadioButton();
            this.autoButton = new System.Windows.Forms.RadioButton();
            this.foodButton = new System.Windows.Forms.RadioButton();
            this.billsButton = new System.Windows.Forms.RadioButton();
            this.costLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.addDataButton = new System.Windows.Forms.Button();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.miscTotalLbl = new System.Windows.Forms.Label();
            this.investmentTotalLbl = new System.Windows.Forms.Label();
            this.entertainmentTotalLbl = new System.Windows.Forms.Label();
            this.autoTotalLbl = new System.Windows.Forms.Label();
            this.foodTotalLbl = new System.Windows.Forms.Label();
            this.billsTotalLbl = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonErrorLabel = new System.Windows.Forms.Label();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.costErrorLabel = new System.Windows.Forms.Label();
            this.calculatorUserControl1 = new Tivi.CalculatorUserControl();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.choicePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnToMainMenu
            // 
            this.returnToMainMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.returnToMainMenu.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToMainMenu.Location = new System.Drawing.Point(50, 825);
            this.returnToMainMenu.Name = "returnToMainMenu";
            this.returnToMainMenu.Size = new System.Drawing.Size(273, 79);
            this.returnToMainMenu.TabIndex = 28;
            this.returnToMainMenu.Text = "Back To Main Menu";
            this.returnToMainMenu.UseVisualStyleBackColor = false;
            this.returnToMainMenu.Click += new System.EventHandler(this.returnToMainMenu_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.addDataButton);
            this.panel4.Controls.Add(this.generateReportButton);
            this.panel4.Location = new System.Drawing.Point(50, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(674, 197);
            this.panel4.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nameLabel);
            this.panel3.Controls.Add(this.choicePanel);
            this.panel3.Controls.Add(this.costLabel);
            this.panel3.Controls.Add(this.nameTextBox);
            this.panel3.Controls.Add(this.costTextBox);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 138);
            this.panel3.TabIndex = 27;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(16, 18);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(133, 20);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "Enter the name";
            // 
            // choicePanel
            // 
            this.choicePanel.Controls.Add(this.miscellanousButton);
            this.choicePanel.Controls.Add(this.investmentButton);
            this.choicePanel.Controls.Add(this.entertainmentButton);
            this.choicePanel.Controls.Add(this.autoButton);
            this.choicePanel.Controls.Add(this.foodButton);
            this.choicePanel.Controls.Add(this.billsButton);
            this.choicePanel.Location = new System.Drawing.Point(3, 84);
            this.choicePanel.Name = "choicePanel";
            this.choicePanel.Size = new System.Drawing.Size(655, 37);
            this.choicePanel.TabIndex = 16;
            // 
            // miscellanousButton
            // 
            this.miscellanousButton.AutoSize = true;
            this.miscellanousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscellanousButton.Location = new System.Drawing.Point(519, 10);
            this.miscellanousButton.Name = "miscellanousButton";
            this.miscellanousButton.Size = new System.Drawing.Size(125, 20);
            this.miscellanousButton.TabIndex = 11;
            this.miscellanousButton.TabStop = true;
            this.miscellanousButton.Text = "Miscellaneous";
            this.miscellanousButton.UseVisualStyleBackColor = true;
            // 
            // investmentButton
            // 
            this.investmentButton.AutoSize = true;
            this.investmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.investmentButton.Location = new System.Drawing.Point(280, 10);
            this.investmentButton.Name = "investmentButton";
            this.investmentButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.investmentButton.Size = new System.Drawing.Size(107, 20);
            this.investmentButton.TabIndex = 10;
            this.investmentButton.TabStop = true;
            this.investmentButton.Text = "Investments";
            this.investmentButton.UseVisualStyleBackColor = true;
            // 
            // entertainmentButton
            // 
            this.entertainmentButton.AutoSize = true;
            this.entertainmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entertainmentButton.Location = new System.Drawing.Point(393, 10);
            this.entertainmentButton.Name = "entertainmentButton";
            this.entertainmentButton.Size = new System.Drawing.Size(119, 20);
            this.entertainmentButton.TabIndex = 9;
            this.entertainmentButton.TabStop = true;
            this.entertainmentButton.Text = "Entertainment";
            this.entertainmentButton.UseVisualStyleBackColor = true;
            // 
            // autoButton
            // 
            this.autoButton.AutoSize = true;
            this.autoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoButton.Location = new System.Drawing.Point(139, 10);
            this.autoButton.Name = "autoButton";
            this.autoButton.Size = new System.Drawing.Size(126, 20);
            this.autoButton.TabIndex = 8;
            this.autoButton.TabStop = true;
            this.autoButton.Text = "Transportation";
            this.autoButton.UseVisualStyleBackColor = true;
            // 
            // foodButton
            // 
            this.foodButton.AutoSize = true;
            this.foodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodButton.Location = new System.Drawing.Point(69, 10);
            this.foodButton.Name = "foodButton";
            this.foodButton.Size = new System.Drawing.Size(61, 20);
            this.foodButton.TabIndex = 7;
            this.foodButton.TabStop = true;
            this.foodButton.Text = "Food";
            this.foodButton.UseVisualStyleBackColor = true;
            // 
            // billsButton
            // 
            this.billsButton.AutoSize = true;
            this.billsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billsButton.Location = new System.Drawing.Point(8, 10);
            this.billsButton.Name = "billsButton";
            this.billsButton.Size = new System.Drawing.Size(55, 20);
            this.billsButton.TabIndex = 6;
            this.billsButton.TabStop = true;
            this.billsButton.Text = "Bills";
            this.billsButton.UseVisualStyleBackColor = true;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(16, 52);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(123, 20);
            this.costLabel.TabIndex = 15;
            this.costLabel.Text = "Enter the cost";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(155, 18);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(360, 26);
            this.nameTextBox.TabIndex = 19;
            // 
            // costTextBox
            // 
            this.costTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costTextBox.Location = new System.Drawing.Point(155, 49);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(360, 26);
            this.costTextBox.TabIndex = 20;
            // 
            // addDataButton
            // 
            this.addDataButton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDataButton.Location = new System.Drawing.Point(333, 147);
            this.addDataButton.Name = "addDataButton";
            this.addDataButton.Size = new System.Drawing.Size(132, 33);
            this.addDataButton.TabIndex = 17;
            this.addDataButton.Text = "Add Data";
            this.addDataButton.UseVisualStyleBackColor = true;
            this.addDataButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // generateReportButton
            // 
            this.generateReportButton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateReportButton.Location = new System.Drawing.Point(176, 147);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(139, 33);
            this.generateReportButton.TabIndex = 18;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // pieChart
            // 
            this.pieChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pieChart.Legends.Add(legend1);
            this.pieChart.Location = new System.Drawing.Point(758, 17);
            this.pieChart.Name = "pieChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.pieChart.Series.Add(series1);
            this.pieChart.Size = new System.Drawing.Size(479, 381);
            this.pieChart.TabIndex = 30;
            this.pieChart.Text = "Budget Chart";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.miscTotalLbl);
            this.panel1.Controls.Add(this.investmentTotalLbl);
            this.panel1.Controls.Add(this.entertainmentTotalLbl);
            this.panel1.Controls.Add(this.autoTotalLbl);
            this.panel1.Controls.Add(this.foodTotalLbl);
            this.panel1.Controls.Add(this.billsTotalLbl);
            this.panel1.Location = new System.Drawing.Point(50, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 422);
            this.panel1.TabIndex = 31;
            // 
            // miscTotalLbl
            // 
            this.miscTotalLbl.AutoSize = true;
            this.miscTotalLbl.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscTotalLbl.Location = new System.Drawing.Point(9, 362);
            this.miscTotalLbl.Name = "miscTotalLbl";
            this.miscTotalLbl.Size = new System.Drawing.Size(149, 26);
            this.miscTotalLbl.TabIndex = 5;
            this.miscTotalLbl.Text = "Miscellaneous :";
            // 
            // investmentTotalLbl
            // 
            this.investmentTotalLbl.AutoSize = true;
            this.investmentTotalLbl.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.investmentTotalLbl.Location = new System.Drawing.Point(9, 296);
            this.investmentTotalLbl.Name = "investmentTotalLbl";
            this.investmentTotalLbl.Size = new System.Drawing.Size(135, 26);
            this.investmentTotalLbl.TabIndex = 4;
            this.investmentTotalLbl.Text = "Investments :";
            // 
            // entertainmentTotalLbl
            // 
            this.entertainmentTotalLbl.AutoSize = true;
            this.entertainmentTotalLbl.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entertainmentTotalLbl.Location = new System.Drawing.Point(9, 226);
            this.entertainmentTotalLbl.Name = "entertainmentTotalLbl";
            this.entertainmentTotalLbl.Size = new System.Drawing.Size(160, 26);
            this.entertainmentTotalLbl.TabIndex = 3;
            this.entertainmentTotalLbl.Text = "Entertainment : ";
            // 
            // autoTotalLbl
            // 
            this.autoTotalLbl.AutoSize = true;
            this.autoTotalLbl.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoTotalLbl.Location = new System.Drawing.Point(9, 153);
            this.autoTotalLbl.Name = "autoTotalLbl";
            this.autoTotalLbl.Size = new System.Drawing.Size(158, 26);
            this.autoTotalLbl.TabIndex = 2;
            this.autoTotalLbl.Text = "Transportation :";
            // 
            // foodTotalLbl
            // 
            this.foodTotalLbl.AutoSize = true;
            this.foodTotalLbl.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodTotalLbl.Location = new System.Drawing.Point(11, 90);
            this.foodTotalLbl.Name = "foodTotalLbl";
            this.foodTotalLbl.Size = new System.Drawing.Size(73, 26);
            this.foodTotalLbl.TabIndex = 1;
            this.foodTotalLbl.Text = "Food : ";
            // 
            // billsTotalLbl
            // 
            this.billsTotalLbl.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billsTotalLbl.Location = new System.Drawing.Point(11, 28);
            this.billsTotalLbl.Name = "billsTotalLbl";
            this.billsTotalLbl.Size = new System.Drawing.Size(73, 26);
            this.billsTotalLbl.TabIndex = 0;
            this.billsTotalLbl.Text = "Bills :";
            // 
            // outputBox
            // 
            this.outputBox.Cursor = System.Windows.Forms.Cursors.No;
            this.outputBox.Enabled = false;
            this.outputBox.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.Location = new System.Drawing.Point(758, 421);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputBox.Size = new System.Drawing.Size(479, 375);
            this.outputBox.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonErrorLabel);
            this.panel2.Controls.Add(this.nameErrorLabel);
            this.panel2.Controls.Add(this.costErrorLabel);
            this.panel2.Location = new System.Drawing.Point(50, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 153);
            this.panel2.TabIndex = 34;
            // 
            // radioButtonErrorLabel
            // 
            this.radioButtonErrorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.radioButtonErrorLabel.Font = new System.Drawing.Font("Candara Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.radioButtonErrorLabel.Location = new System.Drawing.Point(165, 56);
            this.radioButtonErrorLabel.Name = "radioButtonErrorLabel";
            this.radioButtonErrorLabel.Size = new System.Drawing.Size(205, 45);
            this.radioButtonErrorLabel.TabIndex = 39;
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.nameErrorLabel.Font = new System.Drawing.Font("Candara Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.nameErrorLabel.Location = new System.Drawing.Point(165, 101);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(205, 42);
            this.nameErrorLabel.TabIndex = 38;
            // 
            // costErrorLabel
            // 
            this.costErrorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.costErrorLabel.Font = new System.Drawing.Font("Candara Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.costErrorLabel.Location = new System.Drawing.Point(165, 11);
            this.costErrorLabel.Name = "costErrorLabel";
            this.costErrorLabel.Size = new System.Drawing.Size(205, 45);
            this.costErrorLabel.TabIndex = 37;
            // 
            // calculatorUserControl1
            // 
            this.calculatorUserControl1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.calculatorUserControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.calculatorUserControl1.Location = new System.Drawing.Point(1297, 152);
            this.calculatorUserControl1.Name = "calculatorUserControl1";
            this.calculatorUserControl1.Size = new System.Drawing.Size(341, 412);
            this.calculatorUserControl1.TabIndex = 33;
            // 
            // FinanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1693, 916);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.calculatorUserControl1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.returnToMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FinanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finance";
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.choicePanel.ResumeLayout(false);
            this.choicePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnToMainMenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel choicePanel;
        private System.Windows.Forms.RadioButton miscellanousButton;
        private System.Windows.Forms.RadioButton investmentButton;
        private System.Windows.Forms.RadioButton entertainmentButton;
        private System.Windows.Forms.RadioButton autoButton;
        private System.Windows.Forms.RadioButton foodButton;
        private System.Windows.Forms.RadioButton billsButton;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Button addDataButton;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label miscTotalLbl;
        private System.Windows.Forms.Label investmentTotalLbl;
        private System.Windows.Forms.Label entertainmentTotalLbl;
        private System.Windows.Forms.Label autoTotalLbl;
        private System.Windows.Forms.Label foodTotalLbl;
        private System.Windows.Forms.Label billsTotalLbl;
        private System.Windows.Forms.TextBox outputBox;
        private CalculatorUserControl calculatorUserControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label radioButtonErrorLabel;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label costErrorLabel;
    }
}