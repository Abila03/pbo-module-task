using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;


namespace JT_APPS__Final_Setting_
{
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=PBO;User Id=postgres;Password=abilabrucle;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from admin";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                tabelstaf.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();
        }
        private void ResetForm()
        {
            // Reset nilai-nilai kontrol ke keadaan awal
            
            boxnama.Text = string.Empty;
            boxhp.Text = string.Empty;
            boxemail.Text = string.Empty;
            boxdom.Text = string.Empty;
        }
        private bool AlertGakLengkap()
        {
            if (string.IsNullOrEmpty(boxnama.Text) ||
                string.IsNullOrEmpty(boxhp.Text) ||
                string.IsNullOrEmpty(boxemail.Text) ||
                string.IsNullOrEmpty(boxdom.Text))
            {
                return true; // Ada TextBox yang kosong
            }
            return false; // Semua TextBox terisi
        }
        private void btntambahdata_Click(object sender, EventArgs e)
        {
            ResetForm();
            formdata.Visible = true;
        }
        private void btnsimpandata_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=PBO;User Id=postgres;Password=abilabrucle;");
            conn.Open();
            string nama = boxnama.Text;
            string hp = boxhp.Text;
            string email = boxemail.Text;
            string domisili = boxdom.Text;
            DateTime tanggal = boxtgl.Value.Date;
            string query = "INSERT INTO public.admin (nama, no_hp, email, domisili, tanggal_masuk) VALUES (@nama, @hp, @email, @domisili, @tanggal)";
            NpgsqlCommand comm = new NpgsqlCommand(query, conn);
            comm.Parameters.AddWithValue("@nama", nama);
            comm.Parameters.AddWithValue("@hp", hp);
            comm.Parameters.AddWithValue("@email", email);
            comm.Parameters.AddWithValue("@domisili", domisili);
            comm.Parameters.AddWithValue("@tanggal", NpgsqlDbType.Date, tanggal);
            if (AlertGakLengkap())
            {
            MessageBox.Show("Harap isi semua data");
            return; // Tidak melanjutkan penyimpanan data
            }
            comm.ExecuteNonQuery();
            conn.Close();
            ResetForm();
            formdata.Visible = false;
        }
        private void btnbatal_Click(object sender, EventArgs e)
        {
            ResetForm();
            formdata.Visible = false;
        }

        private void btntmbhdata_Click(object sender, EventArgs e)
        {
            ResetForm();
            formdata.Visible = true;
        }


        private void btnrefresh_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=PBO;User Id=postgres;Password=abilabrucle;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from admin";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                tabelstaf.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();
        }
    }
}
