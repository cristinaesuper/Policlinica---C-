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
    public partial class AddInspector : Form
    {
        public AddInspector()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AddInspector
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "AddInspector";
            this.Load += new System.EventHandler(this.AddInspector_Load);
            this.ResumeLayout(false);

        }

        private void AddInspector_Load(object sender, EventArgs e)
        {

        }
    }
}
