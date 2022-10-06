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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public static string kullanici;
        private void btn_giris_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM tblUser where usr=@user AND psw=@pass";

            con = new SqlConnection("server=DESKTOP-RPBUNGP\\SQLEXPRESS; Initial Catalog=HastaneSistemi; Integrated Security=True;TrustServerCertificate=True");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", txt_kullaniciadi.Text);
            cmd.Parameters.AddWithValue("@pass", txt_sifre.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler Başarılı Bir Şekilde Giriş Yaptınız");
                this.Hide();
                kullanici = txt_kullaniciadi.Text;
                Form1 frm = new Form1();
                frm.Show();

                
                
            }

            else
            {

                MessageBox.Show("Kullanıcı Adınızı ve Şifrenizi Kontrol Ediniz");

            }
            con.Close();
        }
    }
}
