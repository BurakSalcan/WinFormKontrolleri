using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormKontrolleri.Model;

namespace WinFormKontrolleri
{
    public partial class DataGridKontrolü : Form
    {
        public DataGridKontrolü()
        {
            InitializeComponent();
        }

        private void DataGridKontrolü_Load(object sender, EventArgs e)
        {
            //DataTableNedir();
            //DataGridDataBind();
            //dataGridView1.Columns[0].Name = "Murtaza";

            //DataGridDataBind2();
            //DataGridDataBind3();
            DataGridDataBind4();
        }

        private void DataGridDataBind4()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Categories";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Kategori No");
            dt.Columns.Add("Kategori İsim");
            dt.Columns.Add("Kategori Açıklaması");
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string description = reader.GetString(2);
                dt.Rows.Add(id, name, description);
            }

            dataGridView1.DataSource = dt;
        }

        private void DataGridDataBind3()
        {
            List<Category> categories = new List<Category>();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Categories";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Kategori No");
            //dt.Columns.Add("Kategori Adı");
            //dt.Columns.Add("Kategori Açıklaması");
            while (reader.Read())
            {
                //dt.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                Category cat = new Category();
                cat.ID = reader.GetInt32(0);
                cat.Name = reader.GetString(1);
                cat.Description = reader.GetString(2);
                categories.Add(cat);
                //En hızlı veri çekme şekli List view + cat ile olan şekilde. Ama list view'i silik üstteki dt.rows olanı ekleyerek de yapabiliriz.
            }

            //dt.Load(reader);
            dataGridView1.DataSource = categories;
        }

        private void DataGridDataBind2()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = ("SELECT * FROM Products");

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommandBuilder sqlCommand = new SqlCommandBuilder();
            sqlCommand.DataAdapter = da;
            da.SelectCommand = cmd;
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void DataGridDataBind()
        {
            //Northwind veri tabanından ürünleri çekelim.
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Products";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void DataTableNedir()
        {
            //DataTable dataTable = new DataTable();

            //dataTable.Columns.Add("Kolon 1");
            //dataTable.Columns.Add("Kolon 2");
            //dataTable.Columns.Add("Kolon 3");

            //dataTable.Rows.Add(1, "Kategori 1", "Açıklama 1");
            //dataTable.Rows.Add(2, "Kategori 2", "Açıklama 2");
            ////ParamsNedir("3", "Murtaza", "Şuayipoğlu");

            //dataGridView1.DataSource = dataTable;
        }

        public void ParamsNedir(params string[] isimler)
        {
            //Params nedir?
            //Params anahtar sözcüğü metüodun alacağı parametre sayısı belli olmadığında kullanılabilir. Kendisine gönderilen aynı türdeki parametreleri dizi indexlerine otomatik olarak yerleştirir ve dizi olarak kullanıma sunar. 

            //dataTable.Rows.Add(isimler[0], isimler[1], isimler[2]);
            //MessageBox.Show(isimler[0]);
        }


    }
}
