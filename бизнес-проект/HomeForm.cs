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
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class HomeForm : Form
    {
        DB db = new DB();

        int selectedRow;

        int user_id = Access_user.userID;

        public HomeForm()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("business_plan_id", "id");
            dataGridView1.Columns.Add("name", "название");
            dataGridView1.Columns.Add("description", "описание");
            dataGridView1.Columns.Add("created_at", "Дата создания");
            dataGridView1.Columns.Add("updated_at", "Дата последнего изменения");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetDateTime(3), record.GetDateTime(4), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from business_plans where user_id = '{user_id}'";

            SqlCommand command = new SqlCommand(queryString, db.getConnection());

            db.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
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

        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);

        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            Add_Form addfrm = new Add_Form();
            addfrm.Show();

        }

        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }

        }

        private void Update()
        {
            db.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var description = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    DateTime updated_at = DateTime.Now;

                    var changeQuery = $"update business_plans set name = '{name}', description = '{description}', updated_at = '{updated_at}' where business_plan_id = '{id}'";

                    var command = new SqlCommand(changeQuery, db.getConnection());
                    command.ExecuteNonQuery();
                }
            }

            db.closeConnection();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteRow();

            db.openConnection();

            var id = Convert.ToInt32(textID.Text);

            string sql = $"delete from business_plans where business_plan_id = {id} ";
            SqlCommand command = new SqlCommand(sql, db.getConnection());
            command.ExecuteNonQuery();

            db.closeConnection();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textID.Text;
            var name = textBoxName.Text;
            var description = textBoxDescription.Text;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(id, name, description);
                dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
            }
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void buttonprojekt_Click(object sender, EventArgs e)
        {
            int business_id = Convert.ToInt32(textID.Text);
            Access_user.businessID = business_id;
            bisnes bsnfrm = new bisnes();
            bsnfrm.Show();
        }
    }
}
