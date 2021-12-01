using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tivi
{
    public partial class UserControlLarge : UserControl
    {
        private Label dayNumberLabel;

        public UserControlLarge()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dayNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dayNumberLabel
            // 
            this.dayNumberLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayNumberLabel.Location = new System.Drawing.Point(18, 14);
            this.dayNumberLabel.Name = "dayNumberLabel";
            this.dayNumberLabel.Size = new System.Drawing.Size(42, 43);
            this.dayNumberLabel.TabIndex = 0;
            // 
            // UserControlLarge
            // 
            this.Controls.Add(this.dayNumberLabel);
            this.Name = "UserControlLarge";
            this.Size = new System.Drawing.Size(214, 224);
            this.ResumeLayout(false);

        }
    }
}
