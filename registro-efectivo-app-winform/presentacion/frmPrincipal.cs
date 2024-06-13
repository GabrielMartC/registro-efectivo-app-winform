using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentation
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            loadForms(new frmCurrentRegistries());

        }
        public void loadForms(object Form)
        {
            try
            {
                if (panelPrincipal.Controls.Count > 0)
                {
                    panelPrincipal.Controls.RemoveAt(0);
                }
                Form f = Form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                panelPrincipal.Controls.Add(f);
                panelPrincipal.Tag = f;
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadForms(new frmCurrentRegistries());
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            loadForms(new frmOldRegistries());
        }
    }
}
