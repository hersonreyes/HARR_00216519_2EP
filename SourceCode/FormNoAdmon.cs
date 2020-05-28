using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class FormNoAdmon : Form
    {
        private string user;
        private UserControl current=null;
        public FormNoAdmon()
        {
            InitializeComponent();
        }
        public FormNoAdmon(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new AddAdress(user);
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,5,0);
            tableLayoutPanel1.SetRowSpan(current, 3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new ModifyAdress(user);
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,5,0);
            tableLayoutPanel1.SetRowSpan(current, 3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new DeleteAdress(user);
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,5,0);
            tableLayoutPanel1.SetRowSpan(current, 3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new NewOrder(user);
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,5,0);
            tableLayoutPanel1.SetRowSpan(current, 3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new DeleteOrder(user);
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,5,0);
            tableLayoutPanel1.SetRowSpan(current, 3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new ViewOrdersNoAdmin(user);
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,5,0);
            tableLayoutPanel1.SetRowSpan(current, 3);
        }
    }
}