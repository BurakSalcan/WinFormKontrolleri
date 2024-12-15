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

namespace WinFormKontrolleri.Northwind
{
    public partial class KategoriHizliEkleForm : Form
    {
        public KategoriHizliEkleForm()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_isim.Text))
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=true");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO Categories(CategoryName) VALUES(@n)";
                cmd.Parameters.AddWithValue("@n", tb_isim.Text);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Kategori eklenirken hata oluştu.", "Hata");
                }
                finally
                {
                    con.Close();
                }
                
            }
            else
            {

            }
        }
    }
}