namespace КурсоваяРаботаТП
{
    partial class Form_Dictionary
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Info = new System.Windows.Forms.Label();
            this.button_show_table = new System.Windows.Forms.Button();
            this.button_reload = new System.Windows.Forms.Button();
            this.button_open_add_form = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox_search_author = new System.Windows.Forms.TextBox();
            this.textBox_search_type_phrase = new System.Windows.Forms.TextBox();
            this.textBox_search_phrase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(299, 726);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.Info);
            this.panel1.Controls.Add(this.button_show_table);
            this.panel1.Controls.Add(this.button_reload);
            this.panel1.Controls.Add(this.button_open_add_form);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.textBox_search_author);
            this.panel1.Controls.Add(this.textBox_search_type_phrase);
            this.panel1.Controls.Add(this.textBox_search_phrase);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 720);
            this.panel1.TabIndex = 0;
            // 
            // Info
            // 
            this.Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info.Location = new System.Drawing.Point(252, 6);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(39, 28);
            this.Info.TabIndex = 23;
            this.Info.Text = "ℹ";
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // button_show_table
            // 
            this.button_show_table.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_show_table.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_show_table.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_show_table.FlatAppearance.BorderSize = 0;
            this.button_show_table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_show_table.Font = new System.Drawing.Font("Segoe UI Black", 12.2F, System.Drawing.FontStyle.Bold);
            this.button_show_table.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_show_table.Location = new System.Drawing.Point(10, 325);
            this.button_show_table.MaximumSize = new System.Drawing.Size(264, 79);
            this.button_show_table.Name = "button_show_table";
            this.button_show_table.Size = new System.Drawing.Size(264, 79);
            this.button_show_table.TabIndex = 22;
            this.button_show_table.Text = "Показать таблицу";
            this.button_show_table.UseVisualStyleBackColor = false;
            this.button_show_table.Click += new System.EventHandler(this.button_show_table_Click);
            // 
            // button_reload
            // 
            this.button_reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_reload.AutoSize = true;
            this.button_reload.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_reload.Enabled = false;
            this.button_reload.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_reload.FlatAppearance.BorderSize = 0;
            this.button_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_reload.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_reload.Location = new System.Drawing.Point(10, 544);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(264, 40);
            this.button_reload.TabIndex = 21;
            this.button_reload.Text = "Обновить";
            this.button_reload.UseVisualStyleBackColor = false;
            this.button_reload.Click += new System.EventHandler(this.button_reload_Click);
            // 
            // button_open_add_form
            // 
            this.button_open_add_form.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_open_add_form.AutoSize = true;
            this.button_open_add_form.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_open_add_form.Enabled = false;
            this.button_open_add_form.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_open_add_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_open_add_form.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_open_add_form.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_open_add_form.Location = new System.Drawing.Point(10, 601);
            this.button_open_add_form.Name = "button_open_add_form";
            this.button_open_add_form.Size = new System.Drawing.Size(264, 40);
            this.button_open_add_form.TabIndex = 20;
            this.button_open_add_form.Text = "Добавить";
            this.button_open_add_form.UseVisualStyleBackColor = false;
            this.button_open_add_form.Click += new System.EventHandler(this.button_open_add_form_Click);
            // 
            // button_delete
            // 
            this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_delete.AutoSize = true;
            this.button_delete.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_delete.Enabled = false;
            this.button_delete.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.ForeColor = System.Drawing.Color.Crimson;
            this.button_delete.Location = new System.Drawing.Point(10, 657);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(264, 40);
            this.button_delete.TabIndex = 19;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // textBox_search_author
            // 
            this.textBox_search_author.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_search_author.Enabled = false;
            this.textBox_search_author.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_search_author.Location = new System.Drawing.Point(9, 161);
            this.textBox_search_author.Name = "textBox_search_author";
            this.textBox_search_author.Size = new System.Drawing.Size(261, 27);
            this.textBox_search_author.TabIndex = 18;
            this.textBox_search_author.TextChanged += new System.EventHandler(this.textBox_search_author_TextChanged);
            // 
            // textBox_search_type_phrase
            // 
            this.textBox_search_type_phrase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search_type_phrase.BackColor = System.Drawing.Color.White;
            this.textBox_search_type_phrase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_search_type_phrase.Enabled = false;
            this.textBox_search_type_phrase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_search_type_phrase.Location = new System.Drawing.Point(9, 254);
            this.textBox_search_type_phrase.Name = "textBox_search_type_phrase";
            this.textBox_search_type_phrase.Size = new System.Drawing.Size(261, 27);
            this.textBox_search_type_phrase.TabIndex = 17;
            this.textBox_search_type_phrase.TextChanged += new System.EventHandler(this.textBox_search_type_phrase_TextChanged);
            // 
            // textBox_search_phrase
            // 
            this.textBox_search_phrase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search_phrase.BackColor = System.Drawing.Color.White;
            this.textBox_search_phrase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_search_phrase.Enabled = false;
            this.textBox_search_phrase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_search_phrase.Location = new System.Drawing.Point(9, 75);
            this.textBox_search_phrase.Name = "textBox_search_phrase";
            this.textBox_search_phrase.Size = new System.Drawing.Size(261, 27);
            this.textBox_search_phrase.TabIndex = 15;
            this.textBox_search_phrase.TextChanged += new System.EventHandler(this.textBox_search_phrase_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Поиск по автору:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Поиск по типу фразы:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Поиск по фразе:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(303, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 720);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form_Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 726);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form_Dictionary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник Крылатых Фраз";
            this.Load += new System.EventHandler(this.Form_Dictionary_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_search_author;
        private System.Windows.Forms.TextBox textBox_search_type_phrase;
        private System.Windows.Forms.TextBox textBox_search_phrase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_reload;
        private System.Windows.Forms.Button button_open_add_form;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_show_table;
        private System.Windows.Forms.Label Info;
    }
}

