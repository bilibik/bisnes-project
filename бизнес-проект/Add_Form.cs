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

namespace бизнес_проект
{
    public partial class Add_Form : Form
    {
        DB db = new DB();

        public Add_Form()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.openConnection();

            var name = textBoxName2.Text;
            var description = textBoxDescription2.Text;
            int user_id = Access_user.userID;

            var addquery = $"insert into business_plans (name, description, user_id) values ('{name}', '{description}', '{user_id}')";

            var command = new SqlCommand(addquery, db.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            db.closeConnection();
        }
    }
}
