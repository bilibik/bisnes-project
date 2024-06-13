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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace бизнес_проект
{

    public partial class bisnes : Form
    {
        DB db = new DB();
        int business_id = Access_user.businessID;
        int selectedRow;

        public bisnes()
        {
            InitializeComponent();
        }
        private void CreateColumns1()
        {
            dataGridView1.Columns.Add("section_id", "id");
            dataGridView1.Columns.Add("name", "Цели");
            dataGridView1.Columns.Add("tasks", "Задачи");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void CreateColumns2()
        {
            dataGridViewPersonal.Columns.Add("personal_id", "id");
            dataGridViewPersonal.Columns.Add("name", "Должность");
            dataGridViewPersonal.Columns.Add("count", "Количество");
            dataGridViewPersonal.Columns.Add("price", "Заработная плата в месяц руб.");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void CreateColumns3()
        {
            dataGridViewAssest.Columns.Add("assest_id", "id");
            dataGridViewAssest.Columns.Add("name", "Название");
            dataGridViewAssest.Columns.Add("count", "Количество");
            dataGridViewAssest.Columns.Add("price", "Стоимость");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void CreateColumns4()
        {
            dataGridViewMaterial.Columns.Add("material_id", "id");
            dataGridViewMaterial.Columns.Add("name", "Название");
            dataGridViewMaterial.Columns.Add("count", "Количество");
            dataGridViewMaterial.Columns.Add("unit", "Единица измерения");
            dataGridViewMaterial.Columns.Add("price", "Стоимость");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow1(IDataRecord record)
        {
            dataGridView1.Rows.Add(record.GetInt32(0), record.GetString(2), record.GetString(3), RowState.ModifiedNew);
        }
        private void ReadSingleRow2(IDataRecord record)
        {
            dataGridViewPersonal.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4), RowState.ModifiedNew);
        }
        private void ReadSingleRow3(IDataRecord record)
        {
            dataGridViewAssest.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), RowState.ModifiedNew);
        }
        private void ReadSingleRow4(IDataRecord record)
        {
            dataGridViewMaterial.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3), record.GetInt32(4), RowState.ModifiedNew);
        }


        private void RefreshDataGrid1()
        {
            dataGridView1.Rows.Clear();

            string queryString = $"select * from sections where business_plan_id = '{business_id}'";

            SqlCommand command = new SqlCommand(queryString, db.getConnection());

            db.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow1(reader);
            }
            reader.Close();
        }

        private void RefreshDataGrid2()
        {
            dataGridViewPersonal.Rows.Clear();

            string queryString = $"select * from personals where business_plan_id = '{business_id}'";

            SqlCommand command = new SqlCommand(queryString, db.getConnection());

            db.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow2(reader);
            }
            reader.Close();
        }

        private void RefreshDataGrid3()
        {
            dataGridViewAssest.Rows.Clear();

            string queryString = $"select * from assests where business_plan_id = '{business_id}'";

            SqlCommand command = new SqlCommand(queryString, db.getConnection());

            db.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow3(reader);
            }
            reader.Close();
        }

        private void RefreshDataGrid4()
        {
            dataGridViewMaterial.Rows.Clear();

            string queryString = $"select * from materials where business_plan_id = '{business_id}'";

            SqlCommand command = new SqlCommand(queryString, db.getConnection());

            db.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow4(reader);
            }
            reader.Close();
        }

        private void bisnes_Load(object sender, EventArgs e)
        {
            CreateColumns1();
            CreateColumns2();
            CreateColumns3();
            CreateColumns4();
            RefreshDataGrid1();
            RefreshDataGrid2();
            RefreshDataGrid3();
            RefreshDataGrid4();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textID.Text = row.Cells[0].Value.ToString();
                textBoxName.Text = row.Cells[1].Value.ToString();
                textBoxDescription.Text = row.Cells[2].Value.ToString();
            }
        }
        private void dataGridViewPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPersonal.Rows[selectedRow];

                textBoxidP.Text = row.Cells[0].Value.ToString();
                textBoxnameP.Text = row.Cells[1].Value.ToString();
                textBoxcountP.Text = row.Cells[2].Value.ToString();
                textBoxpriceP.Text = row.Cells[3].Value.ToString();
            }
        }
        private void dataGridViewAssest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewAssest.Rows[selectedRow];

                textBoxidA.Text = row.Cells[0].Value.ToString();
                textBoxnameA.Text = row.Cells[1].Value.ToString();
                textBoxcountA.Text = row.Cells[2].Value.ToString();
                textBoxpriceA.Text = row.Cells[3].Value.ToString();
            }
        }
        private void dataGridViewMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMaterial.Rows[selectedRow];

                textBoxidM.Text = row.Cells[0].Value.ToString();
                textBoxnameM.Text = row.Cells[1].Value.ToString();
                textBoxcountM.Text = row.Cells[2].Value.ToString();
                textBoxunit.Text = row.Cells[3].Value.ToString();
                textBoxpriceM.Text = row.Cells[4].Value.ToString();
            }
        }


        private void Change1()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textID.Text;
            var name = textBoxName.Text;
            var tasks = textBoxDescription.Text;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(id, name, tasks);
                dataGridView1.Rows[selectedRowIndex].Cells[3].Value = RowState.Modified;
            }
        }
        private void Change2()
        {
            var selectedRowIndex = dataGridViewPersonal.CurrentCell.RowIndex;

            var id = textBoxidP.Text;
            var name = textBoxnameP.Text;
            var count = textBoxcountP.Text;
            var price = textBoxpriceP.Text;

            dataGridViewPersonal.Rows[selectedRowIndex].SetValues(id, name, count, price);

        }
        private void Change3()
        {
            var selectedRowIndex = dataGridViewAssest.CurrentCell.RowIndex;

            var id = textBoxidA.Text;
            var name = textBoxnameA.Text;
            var count = textBoxcountA.Text;
            var price = textBoxpriceA.Text;

            dataGridViewAssest.Rows[selectedRowIndex].SetValues(id, name, count, price);
        }
        private void Change4()
        {
            var selectedRowIndex = dataGridViewMaterial.CurrentCell.RowIndex;

            var id = textBoxidM.Text;
            var name = textBoxnameM.Text;
            var count = textBoxcountM.Text;
            var unit = textBoxunit.Text;
            var price = textBoxpriceM.Text;

                dataGridViewMaterial.Rows[selectedRowIndex].SetValues(id, name, count, unit, price);
        }


        private void Update1()
        {
            db.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[3].Value;

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var tasks = dataGridView1.Rows[index].Cells[2].Value.ToString();

                    var changeQuery = $"update sections set name = '{name}', tasks = '{tasks}' where section_id = '{id}'";

                    var command = new SqlCommand(changeQuery, db.getConnection());
                    command.ExecuteNonQuery();
                }
            }

            db.closeConnection();
        }
        private void Update2()
        {
            db.openConnection();

            for (int index = 0; index < dataGridViewPersonal.Rows.Count; index++)
            {

                var id = dataGridViewPersonal.Rows[index].Cells[0].Value.ToString();
                var name = dataGridViewPersonal.Rows[index].Cells[1].Value.ToString();
                var count = dataGridViewPersonal.Rows[index].Cells[2].Value.ToString();
                var price = dataGridViewPersonal.Rows[index].Cells[3].Value.ToString();

                var changeQuery = $"update personals set name = '{name}', count = '{count}', price = '{price}' where personal_id = '{id}'";

                var command = new SqlCommand(changeQuery, db.getConnection());
                command.ExecuteNonQuery();
            }

            db.closeConnection();
        }
        private void Update3()
        {
            db.openConnection();

            for (int index = 0; index < dataGridViewAssest.Rows.Count; index++)
            {
                var id = dataGridViewAssest.Rows[index].Cells[0].Value.ToString();
                var name = dataGridViewAssest.Rows[index].Cells[1].Value.ToString();
                var count = dataGridViewAssest.Rows[index].Cells[2].Value.ToString();
                var price = dataGridViewAssest.Rows[index].Cells[3].Value.ToString();

                var changeQuery = $"update assests set name = '{name}', count = '{count}', price = '{price}' where assest_id = '{id}'";

                var command = new SqlCommand(changeQuery, db.getConnection());
                command.ExecuteNonQuery();
            }

            db.closeConnection();
        }
        private void Update4()
        {
            db.openConnection();

            for (int index = 0; index < dataGridViewMaterial.Rows.Count; index++)
            {
                var id = dataGridViewMaterial.Rows[index].Cells[0].Value.ToString();
                var name = dataGridViewMaterial.Rows[index].Cells[1].Value.ToString();
                var count = dataGridViewMaterial.Rows[index].Cells[2].Value.ToString();
                var unit = dataGridViewMaterial.Rows[index].Cells[3].Value.ToString();
                var price = dataGridViewMaterial.Rows[index].Cells[4].Value.ToString();

                var changeQuery = $"update materials set name = '{name}', count = '{count}', unit = '{unit}', price = '{price}' where material_id = '{id}'";

                var command = new SqlCommand(changeQuery, db.getConnection());
                command.ExecuteNonQuery();
            }

            db.closeConnection();
        }


        private void ButtonNew_Click(object sender, EventArgs e)
        {

            AddTasks_Form addtasksfrm = new AddTasks_Form();
            addtasksfrm.Show();

        }
        private void refresh_Click_1(object sender, EventArgs e)
        {
            RefreshDataGrid1();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid2();
            RefreshDataGrid3();
            RefreshDataGrid4();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            db.openConnection();

            var id = Convert.ToInt32(textID.Text);

            string sql = $"delete from sections where section_id = {id} ";
            SqlCommand command = new SqlCommand(sql, db.getConnection());
            command.ExecuteNonQuery();

            db.closeConnection();
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            Change1();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Update1();
        }


        private void ButtonAdd_P_Click(object sender, EventArgs e)
        {
            db.openConnection();

            var name = textBoxnameP.Text;
            var count = textBoxcountP.Text;
            var price = textBoxpriceP.Text;
            int business_id = Access_user.businessID;

            var addquery = $"insert into personals (name, count, price, business_plan_id) values ('{name}', '{count}', '{price}', '{business_id}')";

            var command = new SqlCommand(addquery, db.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            db.closeConnection();

            RefreshDataGrid2();
        }
        private void ButtonAdd_A_Click(object sender, EventArgs e)
        {
            db.openConnection();

            var name = textBoxnameA.Text;
            var count = textBoxcountA.Text;
            var price = textBoxpriceA.Text;
            int business_id = Access_user.businessID;

            var addquery = $"insert into assests (name, count, price, business_plan_id) values ('{name}', '{count}', '{price}', '{business_id}')";

            var command = new SqlCommand(addquery, db.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            db.closeConnection();

            RefreshDataGrid3();
        }
        private void ButtonAdd_M_Click(object sender, EventArgs e)
        {
            db.openConnection();

            var name = textBoxnameM.Text;
            var count = textBoxcountM.Text;
            var unit = textBoxunit.Text;
            var price = textBoxpriceM.Text;
            int business_id = Access_user.businessID;

            var addquery = $"insert into materials (name, count, unit, price, business_plan_id) values ('{name}', '{count}', '{unit}', '{price}', '{business_id}')";

            var command = new SqlCommand(addquery, db.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            db.closeConnection();

            RefreshDataGrid4();
        }

        private void ButtonDelete_P_Click(object sender, EventArgs e)
        {
            db.openConnection();

            var id = Convert.ToInt32(textBoxidP.Text);

            string sql = $"delete from personals where personal_id = {id} ";
            SqlCommand command = new SqlCommand(sql, db.getConnection());
            command.ExecuteNonQuery();

            db.closeConnection();
            RefreshDataGrid2();
        }

        private void ButtonDelete_A_Click(object sender, EventArgs e)
        {
            db.openConnection();

            var id = Convert.ToInt32(textBoxidA.Text);

            string sql = $"delete from assests where assest_id = {id} ";
            SqlCommand command = new SqlCommand(sql, db.getConnection());
            command.ExecuteNonQuery();

            db.closeConnection();
            RefreshDataGrid3();
        }

        private void ButtonDelete_M_Click(object sender, EventArgs e)
        {
            db.openConnection();

            var id = Convert.ToInt32(textBoxidM.Text);

            string sql = $"delete from materials where material_id = {id} ";
            SqlCommand command = new SqlCommand(sql, db.getConnection());
            command.ExecuteNonQuery();

            db.closeConnection();
            RefreshDataGrid4();
        }

        private void ButtonEdit_P_Click(object sender, EventArgs e)
        {
            Change2();
            Update2();
            RefreshDataGrid2();
        }

        private void ButtonEdit_A_Click(object sender, EventArgs e)
        {
            Change3();
            Update3();
            RefreshDataGrid3();
        }

        private void ButtonEdit_M_Click(object sender, EventArgs e)
        {
            Change4();
            Update4();
            RefreshDataGrid4();
        }
    }
}
