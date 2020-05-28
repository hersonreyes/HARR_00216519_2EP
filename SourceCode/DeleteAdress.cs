using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class DeleteAdress : UserControl
    {
        private string user;
        public DeleteAdress()
        {
            InitializeComponent();
        }
        public DeleteAdress(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionDB.ExecuteNonQuery($"DELETE FROM ADDRESS WHERE idAddress = {comboBox2.SelectedItem}");
                MessageBox.Show("Direccion Eliminada");
            }
            catch (Exception esg)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void DeleteAdress_Load(object sender, EventArgs e)
        {
            var dt = ConnectionDB.ExecuteQuery($"SELECT iduser FROM APPUSER WHERE username='{user}'");
            var dr = dt.Rows[0];
            int id = Convert.ToInt32(dr[0]);
            
            var names = ConnectionDB.ExecuteQuery($"SELECT idaddress FROM ADDRESS WHERE iduser={id}");

            var namesCombo = new List<string>();
            foreach (DataRow datrow in names.Rows)
            {
                namesCombo.Add(datrow[0].ToString());
            }

            comboBox2.DataSource = namesCombo;
        }
    }
}