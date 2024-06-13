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
    public partial class AddTasks_Form : Form
    {
        DB db = new DB();

        public AddTasks_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.openConnection();

            var name = textBoxName2.Text;
            var tasks = textBoxDescription2.Text;
            int business_id = Access_user.businessID;

            var addquery = $"insert into sections (business_plan_id, name, tasks) values ('{business_id}', '{name}', '{tasks}')";

            var command = new SqlCommand(addquery, db.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            db.closeConnection();
        }
    }
}
