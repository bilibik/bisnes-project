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

namespace бизнес_проект
{
    public partial class Singform : Form
    {
        DB db = new DB();

        public Singform()
        {
            InitializeComponent();
        }

        private void close_button_Click(object sender, EventArgs e)
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

        private Boolean checkuser()
        {
            var LoginUser = user_singtext.Text;
            var PassUser = pass_singtext.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select user_id, username, password from users where username = '{LoginUser}' and password = '{PassUser}'";

            SqlCommand command = new SqlCommand(querystring, db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        private void sing_button_Click(object sender, EventArgs e)
        {
            var LoginUser = user_singtext.Text;
            var PassUser = pass_singtext.Text;

            string querystirng = $"INSERT INTO users(username, password) VALUES('{LoginUser}', '{PassUser}')";
            SqlCommand command = new SqlCommand(querystirng, db.getConnection());

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                LoginForm loginform1 = new LoginForm();
                this.Hide();
                loginform1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт уже существует!");
            }
            db.closeConnection();
        }

    }
}
