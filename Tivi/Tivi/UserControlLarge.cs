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

        public UserControlLarge()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // UserControlLarge
            // 
            this.BackColor = System.Drawing.Color.Bisque;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Name = "UserControlLarge";
            this.Size = new System.Drawing.Size(210, 220);
            this.ResumeLayout(false);

        }
    }
}
