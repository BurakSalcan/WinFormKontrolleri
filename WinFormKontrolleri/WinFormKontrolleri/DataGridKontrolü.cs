﻿using System;
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
        int rowindex = -1;
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
                //En hızlı veri çekme şekli List view + cat ile olan şekilde. Ama list view'i silip üstteki dt.rows olanı ekleyerek de yapabiliriz.
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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Tıklandı");
            if(e.Button == MouseButtons.Right)
            {
                dataGridView1.ClearSelection();
                rowindex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                
                if(rowindex != -1)
                {
                    //MessageBox.Show("Sağ Button", "Tıklandı");
                    contextMenuStrip1.Show(dataGridView1, e.X, e.Y);
                    dataGridView1.Rows[rowindex].Selected = true;
                }
            }
            
        }

        private void TSMI_duzenle_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                btn_duzenle.Visible = true;
                int id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
                //MessageBox.Show(id.ToString(),"Seçilen Kategori ID");

                //Category c = new Category();
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT CategoryID, CategoryName, Description FROM Categories WHERE CategoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tb_ID.Text = reader.GetInt32(0).ToString();
                        tb_isim.Text = reader.GetString(1);
                        //if (!reader.IsDBNull(2))
                        //{
                        //    c.Description = reader.GetString(2);
                        //}
                        //else
                        //{
                        //    c.Description = "";
                        //}
                        tb_aciklama.Text = reader.IsDBNull(2) == false ? reader.GetString(2) : "";
                    }
                }
                catch
                {
                    MessageBox.Show("Kategori getirilirken bir hata oluştu gıııı", "Hata Var");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Categories (CategoryName, Description) VALUES(@name,@des)";
            cmd.Parameters.AddWithValue("@name", tb_isim.Text);
            cmd.Parameters.AddWithValue("@des", tb_aciklama.Text);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                tb_aciklama.Text = tb_isim.Text = "";
                MessageBox.Show("Kategori başarıyla eklendi", "Başarılı");
            }
            catch 
            {
                MessageBox.Show("Kategori eklenirken bir hata oluştu", "Hata Var");
            }
            finally
            {
                con.Close();
            }
            DataGridDataBind4();
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_isim.Text))
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE Categories SET CategoryName=@cn, Description=@des WHERE CategoryID=@id";
                cmd.Parameters.AddWithValue("@cn", tb_isim.Text);
                cmd.Parameters.AddWithValue("@des", tb_aciklama.Text);
                cmd.Parameters.AddWithValue("@id", tb_ID.Text);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kategori başarıyla güncellenmiştir", "Başarılı");
                }
                catch
                {
                    MessageBox.Show("Kategori güncellenirken bir hata oluştu", "Hata Var");
                }
                finally
                { 
                    con.Close(); 
                }
                btn_duzenle.Visible = false;
                tb_ID.Text = tb_isim.Text = tb_aciklama.Text = "";
                DataGridDataBind4();
            }
        }

        private void TSMI_sil_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);

                if (MessageBox.Show($"{id} id'li kategori silinecektir.\n Onaylıyor musunuz?","Kategori Sil",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE FROM Categories WHERE CategoryID=@id";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", id);
                    try { con.Open(); cmd.ExecuteNonQuery(); }
                    finally { con.Close(); }
                    DataGridDataBind4();
                }

            }
        }
    }
}
