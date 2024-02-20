namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1name = new System.Windows.Forms.Label();
            this.label2number = new System.Windows.Forms.Label();
            this.label3city = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.имеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.градDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bazaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new WindowsFormsApp1.databaseDataSet();
            this.button1clear = new System.Windows.Forms.Button();
            this.button2close = new System.Windows.Forms.Button();
            this.button3load = new System.Windows.Forms.Button();
            this.button4delete = new System.Windows.Forms.Button();
            this.button5add = new System.Windows.Forms.Button();
            this.bazaTableAdapter = new WindowsFormsApp1.databaseDataSetTableAdapters.bazaTableAdapter();
            this.button6_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bazaBindingSource, "Име", true));
            this.textBox1.Location = new System.Drawing.Point(37, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bazaBindingSource, "Номер", true));
            this.textBox2.Location = new System.Drawing.Point(37, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bazaBindingSource, "Град", true));
            this.textBox3.Location = new System.Drawing.Point(37, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1name
            // 
            this.label1name.AutoSize = true;
            this.label1name.Location = new System.Drawing.Point(34, 23);
            this.label1name.Name = "label1name";
            this.label1name.Size = new System.Drawing.Size(29, 13);
            this.label1name.TabIndex = 3;
            this.label1name.Text = "Име";
            // 
            // label2number
            // 
            this.label2number.AutoSize = true;
            this.label2number.Location = new System.Drawing.Point(34, 83);
            this.label2number.Name = "label2number";
            this.label2number.Size = new System.Drawing.Size(41, 13);
            this.label2number.TabIndex = 4;
            this.label2number.Text = "Номер";
            // 
            // label3city
            // 
            this.label3city.AutoSize = true;
            this.label3city.Location = new System.Drawing.Point(34, 139);
            this.label3city.Name = "label3city";
            this.label3city.Size = new System.Drawing.Size(31, 13);
            this.label3city.TabIndex = 5;
            this.label3city.Text = "Град";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.имеDataGridViewTextBoxColumn,
            this.номерDataGridViewTextBoxColumn,
            this.градDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bazaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(226, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 247);
            this.dataGridView1.TabIndex = 6;
            // 
            // имеDataGridViewTextBoxColumn
            // 
            this.имеDataGridViewTextBoxColumn.DataPropertyName = "Име";
            this.имеDataGridViewTextBoxColumn.HeaderText = "Име";
            this.имеDataGridViewTextBoxColumn.Name = "имеDataGridViewTextBoxColumn";
            // 
            // номерDataGridViewTextBoxColumn
            // 
            this.номерDataGridViewTextBoxColumn.DataPropertyName = "Номер";
            this.номерDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.номерDataGridViewTextBoxColumn.Name = "номерDataGridViewTextBoxColumn";
            // 
            // градDataGridViewTextBoxColumn
            // 
            this.градDataGridViewTextBoxColumn.DataPropertyName = "Град";
            this.градDataGridViewTextBoxColumn.HeaderText = "Град";
            this.градDataGridViewTextBoxColumn.Name = "градDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // bazaBindingSource
            // 
            this.bazaBindingSource.DataMember = "baza";
            this.bazaBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1clear
            // 
            this.button1clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1clear.Location = new System.Drawing.Point(32, 328);
            this.button1clear.Name = "button1clear";
            this.button1clear.Size = new System.Drawing.Size(75, 23);
            this.button1clear.TabIndex = 7;
            this.button1clear.Text = "Изчисти";
            this.button1clear.UseVisualStyleBackColor = true;
            this.button1clear.Click += new System.EventHandler(this.button1clear_Click);
            // 
            // button2close
            // 
            this.button2close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2close.Location = new System.Drawing.Point(113, 328);
            this.button2close.Name = "button2close";
            this.button2close.Size = new System.Drawing.Size(75, 23);
            this.button2close.TabIndex = 8;
            this.button2close.Text = "Затвори";
            this.button2close.UseVisualStyleBackColor = true;
            this.button2close.Click += new System.EventHandler(this.button2close_Click);
            // 
            // button3load
            // 
            this.button3load.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3load.Location = new System.Drawing.Point(194, 328);
            this.button3load.Name = "button3load";
            this.button3load.Size = new System.Drawing.Size(75, 23);
            this.button3load.TabIndex = 9;
            this.button3load.Text = "Зареди база";
            this.button3load.UseVisualStyleBackColor = true;
            this.button3load.Click += new System.EventHandler(this.button3load_Click);
            // 
            // button4delete
            // 
            this.button4delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4delete.Location = new System.Drawing.Point(275, 328);
            this.button4delete.Name = "button4delete";
            this.button4delete.Size = new System.Drawing.Size(75, 23);
            this.button4delete.TabIndex = 10;
            this.button4delete.Text = "Изтрий";
            this.button4delete.UseVisualStyleBackColor = true;
            this.button4delete.Click += new System.EventHandler(this.button4delete_Click);
            // 
            // button5add
            // 
            this.button5add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5add.Location = new System.Drawing.Point(356, 328);
            this.button5add.Name = "button5add";
            this.button5add.Size = new System.Drawing.Size(75, 23);
            this.button5add.TabIndex = 11;
            this.button5add.Text = "Добави";
            this.button5add.UseVisualStyleBackColor = true;
            this.button5add.Click += new System.EventHandler(this.button5add_Click);
            // 
            // bazaTableAdapter
            // 
            this.bazaTableAdapter.ClearBeforeFill = true;
            // 
            // button6_save
            // 
            this.button6_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6_save.Location = new System.Drawing.Point(437, 328);
            this.button6_save.Name = "button6_save";
            this.button6_save.Size = new System.Drawing.Size(75, 23);
            this.button6_save.TabIndex = 12;
            this.button6_save.Text = "Запази";
            this.button6_save.UseVisualStyleBackColor = true;
            this.button6_save.Click += new System.EventHandler(this.button6_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 393);
            this.Controls.Add(this.button6_save);
            this.Controls.Add(this.button5add);
            this.Controls.Add(this.button4delete);
            this.Controls.Add(this.button3load);
            this.Controls.Add(this.button2close);
            this.Controls.Add(this.button1clear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3city);
            this.Controls.Add(this.label2number);
            this.Controls.Add(this.label1name);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1name;
        private System.Windows.Forms.Label label2number;
        private System.Windows.Forms.Label label3city;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1clear;
        private System.Windows.Forms.Button button2close;
        private System.Windows.Forms.Button button3load;
        private System.Windows.Forms.Button button4delete;
        private System.Windows.Forms.Button button5add;
        private databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource bazaBindingSource;
        private databaseDataSetTableAdapters.bazaTableAdapter bazaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn имеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn градDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button6_save;
    }
}

