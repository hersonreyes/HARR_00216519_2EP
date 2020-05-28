using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class NewOrder : UserControl
    {
        private string user;
        public NewOrder()
        {
            InitializeComponent();
        }
        public NewOrder(string user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void NewOrder_Load(object sender, EventArgs e)
        {
          
            
            var names = ConnectionDB.ExecuteQuery($"SELECT idproduct FROM product");

            var namesCombo1 = new List<string>();
            foreach (DataRow datrow in names.Rows)
            {
                namesCombo1.Add(datrow[0].ToString());
            }

            comboBox1.DataSource = namesCombo1;
            
            var dt2 = ConnectionDB.ExecuteQuery($"SELECT iduser FROM APPUSER WHERE username='{user}'");
            var dr2 = dt2.Rows[0];
            int id2= Convert.ToInt32(dr2[0]);
            
            var names2 = ConnectionDB.ExecuteQuery($"SELECT idaddress FROM ADDRESS WHERE iduser={id2}");

            var namesCombo2 = new List<string>();
            foreach (DataRow datrow2 in names2.Rows)
            {
                namesCombo2.Add(datrow2[0].ToString());
            }

            comboBox2.DataSource = namesCombo2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionDB.ExecuteNonQuery("INSERT INTO APPORDER(createdate, idproduct, idaddress) "+
            $"VALUES('{DateTime.Today}',{comboBox1.SelectedItem},{comboBox2.SelectedItem})");
            MessageBox.Show("Orden Añadida");
        }
    }
}