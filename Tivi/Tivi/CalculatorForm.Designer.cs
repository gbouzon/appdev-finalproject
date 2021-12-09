namespace Tivi
{
    partial class CalculatorForm
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
            this.calculatorUserControl1 = new Tivi.CalculatorUserControl();
            this.SuspendLayout();
            // 
            // calculatorUserControl1
            // 
            this.calculatorUserControl1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.calculatorUserControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.calculatorUserControl1.Location = new System.Drawing.Point(0, 2);
            this.calculatorUserControl1.Name = "calculatorUserControl1";
            this.calculatorUserControl1.Size = new System.Drawing.Size(342, 410);
            this.calculatorUserControl1.TabIndex = 0;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 414);
            this.Controls.Add(this.calculatorUserControl1);
            this.MaximumSize = new System.Drawing.Size(359, 453);
            this.MinimumSize = new System.Drawing.Size(359, 453);
            this.Name = "CalculatorForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private CalculatorUserControl calculatorUserControl1;
    }
}