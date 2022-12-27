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
    public partial class AddReceptioner : Form
    {
        public AddReceptioner()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AddReceptioner
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "AddReceptioner";
            this.Load += new System.EventHandler(this.AddReceptioner_Load);
            this.ResumeLayout(false);

        }

        private void AddReceptioner_Load(object sender, EventArgs e)
        {

        }
    }
}
