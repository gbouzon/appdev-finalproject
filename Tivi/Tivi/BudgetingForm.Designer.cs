namespace Tivi
{
    partial class BudgetingForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.addDataButton = new System.Windows.Forms.Button();
            this.billsButton = new System.Windows.Forms.RadioButton();
            this.foodButton = new System.Windows.Forms.RadioButton();
            this.autButton = new System.Windows.Forms.RadioButton();
            this.entertainmentButton = new System.Windows.Forms.RadioButton();
            this.investmentButton = new System.Windows.Forms.RadioButton();
            this.miscellanousButton = new System.Windows.Forms.RadioButton();
            this.choicePanel = new System.Windows.Forms.Panel();
            this.costLabel = new System.Windows.Forms.Label();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.costErrorLabel = new System.Windows.Forms.Label();
            this.radioButtonError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.miscTotalLbl = new System.Windows.Forms.Label();
            this.investmentTotalLbl = new System.Windows.Forms.Label();
            this.entertainmentTotalLbl = new System.Windows.Forms.Label();
            this.autoTotalLbl = new System.Windows.Forms.Label();
            this.foodTotalLbl = new System.Windows.Forms.Label();
            this.billsTotalLbl = new System.Windows.Forms.Label();
            this.calculatorControl1 = new Syncfusion.Windows.Forms.Tools.CalculatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            this.choicePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(36, 29);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(119, 15);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Enter the name";
            // 
            // pieChart
            // 
            this.pieChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pieChart.Legends.Add(legend1);
            this.pieChart.Location = new System.Drawing.Point(524, 269);
            this.pieChart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pieChart.Name = "pieChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.pieChart.Series.Add(series1);
            this.pieChart.Size = new System.Drawing.Size(523, 440);
            this.pieChart.TabIndex = 9;
            this.pieChart.Text = "Budget Chart";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(16, 323);
            this.outputBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(460, 371);
            this.outputBox.TabIndex = 8;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(163, 65);
            this.costTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(176, 25);
            this.costTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(163, 29);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(176, 25);
            this.nameTextBox.TabIndex = 6;
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(28, 113);
            this.generateReportButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(151, 27);
            this.generateReportButton.TabIndex = 5;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // addDataButton
            // 
            this.addDataButton.Location = new System.Drawing.Point(207, 113);
            this.addDataButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addDataButton.Name = "addDataButton";
            this.addDataButton.Size = new System.Drawing.Size(100, 27);
            this.addDataButton.TabIndex = 4;
            this.addDataButton.Text = "Add Data";
            this.addDataButton.UseVisualStyleBackColor = true;
            this.addDataButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // billsButton
            // 
            this.billsButton.AutoSize = true;
            this.billsButton.Location = new System.Drawing.Point(11, 15);
            this.billsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.billsButton.Name = "billsButton";
            this.billsButton.Size = new System.Drawing.Size(68, 19);
            this.billsButton.TabIndex = 6;
            this.billsButton.TabStop = true;
            this.billsButton.Text = "Bills";
            this.billsButton.UseVisualStyleBackColor = true;
            // 
            // foodButton
            // 
            this.foodButton.AutoSize = true;
            this.foodButton.Location = new System.Drawing.Point(11, 51);
            this.foodButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.foodButton.Name = "foodButton";
            this.foodButton.Size = new System.Drawing.Size(60, 19);
            this.foodButton.TabIndex = 7;
            this.foodButton.TabStop = true;
            this.foodButton.Text = "Food";
            this.foodButton.UseVisualStyleBackColor = true;
            // 
            // autButton
            // 
            this.autButton.AutoSize = true;
            this.autButton.Location = new System.Drawing.Point(13, 82);
            this.autButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.autButton.Name = "autButton";
            this.autButton.Size = new System.Drawing.Size(60, 19);
            this.autButton.TabIndex = 8;
            this.autButton.TabStop = true;
            this.autButton.Text = "Auto";
            this.autButton.UseVisualStyleBackColor = true;
            // 
            // entertainmentButton
            // 
            this.entertainmentButton.AutoSize = true;
            this.entertainmentButton.Location = new System.Drawing.Point(13, 108);
            this.entertainmentButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.entertainmentButton.Name = "entertainmentButton";
            this.entertainmentButton.Size = new System.Drawing.Size(132, 19);
            this.entertainmentButton.TabIndex = 9;
            this.entertainmentButton.TabStop = true;
            this.entertainmentButton.Text = "Entertainment";
            this.entertainmentButton.UseVisualStyleBackColor = true;
            // 
            // investmentButton
            // 
            this.investmentButton.AutoSize = true;
            this.investmentButton.Location = new System.Drawing.Point(13, 145);
            this.investmentButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.investmentButton.Name = "investmentButton";
            this.investmentButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.investmentButton.Size = new System.Drawing.Size(116, 19);
            this.investmentButton.TabIndex = 10;
            this.investmentButton.TabStop = true;
            this.investmentButton.Text = "Investments";
            this.investmentButton.UseVisualStyleBackColor = true;
            // 
            // miscellanousButton
            // 
            this.miscellanousButton.AutoSize = true;
            this.miscellanousButton.Location = new System.Drawing.Point(13, 182);
            this.miscellanousButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.miscellanousButton.Name = "miscellanousButton";
            this.miscellanousButton.Size = new System.Drawing.Size(132, 19);
            this.miscellanousButton.TabIndex = 11;
            this.miscellanousButton.TabStop = true;
            this.miscellanousButton.Text = "Miscellaneous";
            this.miscellanousButton.UseVisualStyleBackColor = true;
            // 
            // choicePanel
            // 
            this.choicePanel.Controls.Add(this.miscellanousButton);
            this.choicePanel.Controls.Add(this.investmentButton);
            this.choicePanel.Controls.Add(this.entertainmentButton);
            this.choicePanel.Controls.Add(this.autButton);
            this.choicePanel.Controls.Add(this.foodButton);
            this.choicePanel.Controls.Add(this.billsButton);
            this.choicePanel.Location = new System.Drawing.Point(379, 14);
            this.choicePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.choicePanel.Name = "choicePanel";
            this.choicePanel.Size = new System.Drawing.Size(164, 218);
            this.choicePanel.TabIndex = 3;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(36, 68);
            this.costLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(119, 15);
            this.costLabel.TabIndex = 2;
            this.costLabel.Text = "Enter the cost";
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.nameErrorLabel.Location = new System.Drawing.Point(47, 159);
            this.nameErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(280, 43);
            this.nameErrorLabel.TabIndex = 10;
            // 
            // costErrorLabel
            // 
            this.costErrorLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.costErrorLabel.Location = new System.Drawing.Point(47, 217);
            this.costErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.costErrorLabel.Name = "costErrorLabel";
            this.costErrorLabel.Size = new System.Drawing.Size(280, 38);
            this.costErrorLabel.TabIndex = 11;
            // 
            // radioButtonError
            // 
            this.radioButtonError.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.radioButtonError.Location = new System.Drawing.Point(47, 269);
            this.radioButtonError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.radioButtonError.Name = "radioButtonError";
            this.radioButtonError.Size = new System.Drawing.Size(280, 44);
            this.radioButtonError.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.miscTotalLbl);
            this.panel1.Controls.Add(this.investmentTotalLbl);
            this.panel1.Controls.Add(this.entertainmentTotalLbl);
            this.panel1.Controls.Add(this.autoTotalLbl);
            this.panel1.Controls.Add(this.foodTotalLbl);
            this.panel1.Controls.Add(this.billsTotalLbl);
            this.panel1.Location = new System.Drawing.Point(568, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 218);
            this.panel1.TabIndex = 13;
            // 
            // miscTotalLbl
            // 
            this.miscTotalLbl.AutoSize = true;
            this.miscTotalLbl.Location = new System.Drawing.Point(3, 182);
            this.miscTotalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.miscTotalLbl.Name = "miscTotalLbl";
            this.miscTotalLbl.Size = new System.Drawing.Size(127, 15);
            this.miscTotalLbl.TabIndex = 5;
            this.miscTotalLbl.Text = "Miscellaneous :";
            // 
            // investmentTotalLbl
            // 
            this.investmentTotalLbl.AutoSize = true;
            this.investmentTotalLbl.Location = new System.Drawing.Point(3, 145);
            this.investmentTotalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.investmentTotalLbl.Name = "investmentTotalLbl";
            this.investmentTotalLbl.Size = new System.Drawing.Size(111, 15);
            this.investmentTotalLbl.TabIndex = 4;
            this.investmentTotalLbl.Text = "Investments :";
            // 
            // entertainmentTotalLbl
            // 
            this.entertainmentTotalLbl.AutoSize = true;
            this.entertainmentTotalLbl.Location = new System.Drawing.Point(3, 111);
            this.entertainmentTotalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.entertainmentTotalLbl.Name = "entertainmentTotalLbl";
            this.entertainmentTotalLbl.Size = new System.Drawing.Size(135, 15);
            this.entertainmentTotalLbl.TabIndex = 3;
            this.entertainmentTotalLbl.Text = "Entertainment : ";
            // 
            // autoTotalLbl
            // 
            this.autoTotalLbl.AutoSize = true;
            this.autoTotalLbl.Location = new System.Drawing.Point(4, 82);
            this.autoTotalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.autoTotalLbl.Name = "autoTotalLbl";
            this.autoTotalLbl.Size = new System.Drawing.Size(55, 15);
            this.autoTotalLbl.TabIndex = 2;
            this.autoTotalLbl.Text = "Auto :";
            // 
            // foodTotalLbl
            // 
            this.foodTotalLbl.AutoSize = true;
            this.foodTotalLbl.Location = new System.Drawing.Point(3, 51);
            this.foodTotalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.foodTotalLbl.Name = "foodTotalLbl";
            this.foodTotalLbl.Size = new System.Drawing.Size(63, 15);
            this.foodTotalLbl.TabIndex = 1;
            this.foodTotalLbl.Text = "Food : ";
            // 
            // billsTotalLbl
            // 
            this.billsTotalLbl.Location = new System.Drawing.Point(4, 15);
            this.billsTotalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.billsTotalLbl.Name = "billsTotalLbl";
            this.billsTotalLbl.Size = new System.Drawing.Size(67, 20);
            this.billsTotalLbl.TabIndex = 0;
            this.billsTotalLbl.Text = "Bills :";
            // 
            // calculatorControl1
            // 
            this.calculatorControl1.AccessibleDescription = "Calculator control";
            this.calculatorControl1.AccessibleName = "Calculator Control";
            this.calculatorControl1.BackColor = System.Drawing.Color.DarkSalmon;
            this.calculatorControl1.BeforeTouchSize = new System.Drawing.Size(520, 633);
            this.calculatorControl1.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.calculatorControl1.Culture = new System.Globalization.CultureInfo("en-US");
            this.calculatorControl1.DoubleValue = 0D;
            this.calculatorControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculatorControl1.Location = new System.Drawing.Point(1116, 29);
            this.calculatorControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.calculatorControl1.MetroColor = System.Drawing.SystemColors.Control;
            this.calculatorControl1.Name = "calculatorControl1";
            this.calculatorControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calculatorControl1.Size = new System.Drawing.Size(520, 633);
            this.calculatorControl1.TabIndex = 14;
            this.calculatorControl1.Text = "calculatorControl1";
            // 
            // BudgetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1723, 738);
            this.Controls.Add(this.calculatorControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButtonError);
            this.Controls.Add(this.costErrorLabel);
            this.Controls.Add(this.nameErrorLabel);
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.addDataButton);
            this.Controls.Add(this.choicePanel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BudgetingForm";
            this.Text = "Budgeting";
            this.Load += new System.EventHandler(this.BudgetingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            this.choicePanel.ResumeLayout(false);
            this.choicePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.Button addDataButton;
        private System.Windows.Forms.RadioButton billsButton;
        private System.Windows.Forms.RadioButton foodButton;
        private System.Windows.Forms.RadioButton autButton;
        private System.Windows.Forms.RadioButton entertainmentButton;
        private System.Windows.Forms.RadioButton investmentButton;
        private System.Windows.Forms.RadioButton miscellanousButton;
        private System.Windows.Forms.Panel choicePanel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label costErrorLabel;
        private System.Windows.Forms.Label radioButtonError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label billsTotalLbl;
        private System.Windows.Forms.Label miscTotalLbl;
        private System.Windows.Forms.Label investmentTotalLbl;
        private System.Windows.Forms.Label entertainmentTotalLbl;
        private System.Windows.Forms.Label autoTotalLbl;
        private System.Windows.Forms.Label foodTotalLbl;
        private Syncfusion.Windows.Forms.Tools.CalculatorControl calculatorControl1;
    }
}