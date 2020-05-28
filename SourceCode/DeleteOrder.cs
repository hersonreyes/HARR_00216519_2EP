using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SourceCode
{
    public partial class DeleteOrder : UserControl
    {
        private string user;
        public DeleteOrder()
        {
            InitializeComponent();
        }
        public DeleteOrder(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void DeleteOrder_Load(object sender, EventArgs e)
        {
            var dt = ConnectionDB.ExecuteQuery($"SELECT iduser FROM APPUSER WHERE username='{user}'");
            var dr = dt.Rows[0];
            int id = Convert.ToInt32(dr[0]);
            
            var names = ConnectionDB.ExecuteQuery($"SELECT ao.idOrder "+
                                                  "FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au "+
                                                  "WHERE ao.idProduct = pr.idProduct "+
                                                     "AND ao.idAddress = ad.idAddress "+
                                                    $"AND ad.idUser = au.idUser AND au.idUser = {id}");

            var namesCombo = new List<string>();
            foreach (DataRow datrow in names.Rows)
            {
                namesCombo.Add(datrow[0].ToString());
            }

            comboBox2.DataSource = namesCombo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionDB.ExecuteNonQuery($"DELETE FROM APPORDER WHERE idOrder = {comboBox2.SelectedItem}");
                MessageBox.Show("Orden Eliminada con exito");
            }
            catch(Exception esg)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}