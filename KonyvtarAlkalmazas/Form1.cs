using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KonyvtarAlkalmazas
{
    public partial class Form1 : Form
    {

        static public string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = konyvt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var conn = new SqlConnection(ConnectionString);
            conn.Open();
            var command = new SqlCommand(
                "select isbn, szerzo, cim, megjelenes, hatarido " +
                "from konyvek, kolcsonzesek " +
                "where konyvek.isbn = kolcsonzesek.konyv;",conn);

            var r = command.ExecuteReader();

            while (r.Read())
            {
                dataGridView1.Rows.Add(r[0],r[1],r[2],r[3],r[4]);
            }
            r.Close();
            conn.Close();   
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            lblCim.Text = dataGridView1.SelectedRows[0].Cells[1].ToString();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            lblIsbn.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            lblSzerzo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            lblCim.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            lblKolcsonzott.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            MessageBox.Show(DateTime.Now.ToString());
        }


    }
}
