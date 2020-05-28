using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class ViewOrdersNoAdmin : UserControl
    {
        private string user;
        public ViewOrdersNoAdmin()
        {
            InitializeComponent();
        }
        public ViewOrdersNoAdmin(string user)
        {
            InitializeComponent();
            this.user = user;
        }


        private void ViewOrdersNoAdmin_Load(object sender, EventArgs e)
        {
           // try
            //{
                var dt = ConnectionDB.ExecuteQuery($"SELECT iduser FROM APPUSER WHERE username='{user}'");
                var dr = dt.Rows[0];
                int id = Convert.ToInt32(dr[0]);
                
           var dtable= ConnectionDB.ExecuteQuery("SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address "+
            "FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au "+
                "WHERE ao.idProduct = pr.idProduct "+
                "AND ao.idAddress = ad.idAddress "+
                $"AND ad.idUser = au.idUser AND au.idUser = {id}");

           dataGridView1.DataSource = dtable;
           // }
           /*catch
           {
               MessageBox.Show("Ha ocurrido un error");
           }*/
        }
    }
}