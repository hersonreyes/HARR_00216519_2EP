using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class ModifyAdress : UserControl
    {
        private string user;
        public ModifyAdress(string user)
        {
            InitializeComponent();
            this.user = user;

        }

        private void ModifyAdress_Load(object sender, EventArgs e)
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

            comboBox1.DataSource = namesCombo;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionDB.ExecuteNonQuery(
                    $"UPDATE ADDRESS SET address = 'nueva' WHERE idAddress = {comboBox1.SelectedItem}");
                MessageBox.Show("Direccion Modificada");
            }
            catch (Exception esg)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

        }
    }
}