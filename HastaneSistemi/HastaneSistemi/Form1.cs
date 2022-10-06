using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HastaneSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        void vericekme()
        {
            con = new SqlConnection("server=DESKTOP-RPBUNGP\\SQLEXPRESS;Initial Catalog=HastaneSistemi; Integrated Security=True;TrustServerCertificate=True");
            da = new SqlDataAdapter("Select * from hasta", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "hasta");
            dtg_hastaliste.DataSource = ds.Tables["hasta"];
            con.Close();


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            vericekme();
            string kullaniciadi;
            kullaniciadi = Login.kullanici;
            lbl_kullaniciadi.Text = kullaniciadi;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into hasta(hasta_no,hasta_isim,hasta_soyisim,teshis,ilac) values(" + txt_hastano.Text + ",'" + txt_hastaad.Text + "','" + txt_hastasoyad.Text + "','" + txt_teshis.Text + "','" + txt_ilac.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            vericekme();
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update hasta set hasta_isim = '" + txt_hastaad.Text + "',hasta_soyisim='" + txt_hastasoyad.Text + "',teshis='" + txt_teshis.Text + "',ilac='" + txt_ilac.Text + "' where hasta_no= " + txt_hastano.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            vericekme();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from hasta where hasta_no = "+txt_hastano.Text+"";
            cmd.ExecuteNonQuery();
            con.Close();
            vericekme();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtg_hastaliste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
