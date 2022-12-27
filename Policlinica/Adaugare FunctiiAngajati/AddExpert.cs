using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Policlinica
{
    public partial class AddExpert : Form
    {
        public AddExpert()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AddExpert
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "AddExpert";
            this.Load += new System.EventHandler(this.AddExpert_Load);
            this.ResumeLayout(false);

        }

        private void AddExpert_Load(object sender, EventArgs e)
        {

        }
    }
}
