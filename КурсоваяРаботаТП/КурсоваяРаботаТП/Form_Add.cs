using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace КурсоваяРаботаТП
{
    public partial class Form_Add : Form
    {
        private SqlConnection sqlConnection = null;

        public Form_Add()
        {
            InitializeComponent();
        }

        private void Form_Add_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Dictionary_DB"].ConnectionString);

            sqlConnection.Open();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите выйти?", "Отмена", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }

            else if (dialog == DialogResult.No)
            {

            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Крылатые_Фразы (Крылатая_фраза, Тип_Фразы, Источник, Автор)" + " VALUES (@Крылатая_Фраза, @Тип_Фразы, @Источник, @Автор)", sqlConnection);

            command.Parameters.AddWithValue("Крылатая_фраза", textBox_new_phrase.Text);
            command.Parameters.AddWithValue("Тип_Фразы", textBox_author.Text);
            command.Parameters.AddWithValue("Источник", textBox_source.Text);
            command.Parameters.AddWithValue("Автор", textBox_type_phrase.Text);

            if (textBox_type_phrase.Text == "" || textBox_new_phrase.Text == "")
            {
                button_add.Enabled = false;

                MessageBox.Show("Обязательные поля не заполнены!", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                button_add.Enabled = true;
            }

            else
            {
                button_add.Enabled = true;

                command.ExecuteNonQuery();

                MessageBox.Show("Вы добавили новую фразу!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Крылатые_Фразы", sqlConnection);

                textBox_author.Text = "";
                textBox_new_phrase.Text = "";
                textBox_source.Text = "";
                textBox_type_phrase.Text = "";

                DataSet database = new DataSet();

                dataAdapter.Fill(database);
            }
        }
    }
}
