using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using business;
using domain;

namespace presentation
{
    public partial class frmCurrentRegistries : Form
    {
        private List<Registry> listRegistries;
        public frmCurrentRegistries()
        {
            InitializeComponent();
        }

        private void frmCurrentRegistries_Load(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void loadDataGridView()
        {
            //with a list...
            RegistryBusiness registryBusiness = new RegistryBusiness();
            try
            {
                listRegistries = registryBusiness.toList();
                dgvRegistries.DataSource = listRegistries;

                occultColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void occultColumns()
        {
            try
            {
                dgvRegistries.Columns["Id"].Visible = false;
                dgvRegistries.Columns["Active"].Visible = false;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
