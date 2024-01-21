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
using System.Configuration;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace КурсоваяРаботаТП
{
    public partial class Form_Dictionary : Form
    {
        private SqlConnection sqlConnection = null;

        private SqlDataAdapter sqlDataAdapter = null;

        private DataSet dataSet = null;
        public Form_Dictionary()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Крылатые_Фразы", sqlConnection);

                dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "Крылатые_Фразы");

                dataGridView1.DataSource = dataSet.Tables["Крылатые_Фразы"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form_Dictionary_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Dictionary_DB"].ConnectionString); //в качестве параметра строка подключения

            sqlConnection.Open();

            
        }

        private void ReloadData()
        {
            try
            {
                dataSet.Tables["Крылатые_Фразы"].Clear();

                sqlDataAdapter.Fill(dataSet, "Крылатые_Фразы");

                dataGridView1.DataSource = dataSet.Tables["Крылатые_Фразы"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_open_add_form_Click(object sender, EventArgs e)
        {
            Form_Add form = new Form_Add(); //создаем новую форму
            form.ShowDialog();
            ReloadData();
        }

        private void button_reload_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void textBox_search_phrase_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Крылатая_Фраза LIKE '%{textBox_search_phrase.Text}%'";
        }

        private void textBox_search_author_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Автор LIKE '%{textBox_search_author.Text}%'";
        }

        private void textBox_search_type_phrase_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Тип_Фразы LIKE '%{textBox_search_type_phrase.Text}%'";
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               int Rowindex = dataGridView1.CurrentCell.RowIndex;
              
               var id = Convert.ToInt32(dataGridView1.Rows[Rowindex].Cells[0].Value);
               var deleteQuery = $"delete from Крылатые_Фразы where id = {id}";
        
               var command = new SqlCommand(deleteQuery, sqlConnection);
               command.ExecuteNonQuery();
        
               ReloadData();
            }
        }

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приймакова А.Э.\n\nЧекунова В. М.\n\nГруппа ИС-22, 2023 год", "Информация об авторах",
                MessageBoxButtons.OK);
        }

        private void button_show_table_Click(object sender, EventArgs e)
        {
            textBox_search_phrase.Enabled = true;
            textBox_search_author.Enabled = true;
            textBox_search_type_phrase.Enabled = true;
            button_reload.Enabled = true;
            button_open_add_form.Enabled = true;
            button_delete.Enabled = true;


            this.Size = new Size (1250, 700);
            this.CenterToScreen();
            LoadData();
        }
    }
}
