using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class AllUsers : UserControl
    {
        public AllUsers()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void AllUsers_Load(object sender, EventArgs e)
        {
            try
            {
                var dt = ConnectionDB.ExecuteQuery("SELECT * FROM APPUSER");
                dataGridView1.DataSource = dt;
            
            }
            catch (Exception esg)
            {
                MessageBox.Show("Ha cocurrido un problema");
            }
        }
    }
    }
