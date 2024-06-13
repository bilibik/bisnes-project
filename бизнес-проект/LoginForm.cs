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
using System.Xml.Linq;


namespace бизнес_проект
{

    
    public partial class LoginForm : Form
    {
        DB db = new DB();

        public LoginForm()
        {
            InitializeComponent();

            this.pass_text.AutoSize = false;
            this.pass_text.Size = new Size(this.pass_text.Size.Width, 50);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_button_MouseEnter(object sender, EventArgs e)
        {
            close_button.ForeColor = Color.Red;
        }

        private void close_button_MouseLeave(object sender, EventArgs e)
        {
            close_button.ForeColor = Color.WhiteSmoke;
        }

        private void authorization_button_Click(object sender, EventArgs e)
        {

            var LoginUser = user_text.Text;
            var PassUser = pass_text.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"SELECT user_id, username, password FROM users WHERE username = '{LoginUser}' AND password = '{PassUser}'";
            SqlCommand command = new SqlCommand(querystring, db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                int user_id = Convert.ToInt32(table.Rows[0]["user_id"]);
                Access_user.userID = user_id;
                
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HomeForm homeform1 = new HomeForm();
                this.Hide();
                homeform1.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Singform singforw1 = new Singform();
            singforw1.Show();
            this.Hide();
        }
    }
}