using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class ViewOrders : UserControl
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
           try
            {
                var dt = ConnectionDB.ExecuteQuery("SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address " +
                                                   "FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                                                   "WHERE ao.idProduct = pr.idProduct " +
                                                   "AND ao.idAddress = ad.idAddress " +
                                                   "AND ad.idUser = au.idUser");
                dataGridView1.DataSource = dt;
            
            }
            catch (Exception esg)
            {
                MessageBox.Show("Ha cocurrido un problema");
            }
        }
    }
}