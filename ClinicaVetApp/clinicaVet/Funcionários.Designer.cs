namespace clinicaVet
{
    partial class Funcionários
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
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            dateTimePicker3 = new DateTimePicker();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            textBox7 = new TextBox();
            label1 = new Label();
            textBox6 = new TextBox();
            btnReset = new Button();
            btnUpdate = new Button();
            btnADD = new Button();
            dateTimePicker1 = new DateTimePicker();
            lblPhone = new Label();
            lblNIF = new Label();
            lblDate = new Label();
            lblNome = new Label();
            lblID = new Label();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            lblSearch = new Label();
            txtboxSearch = new TextBox();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Location = new Point(0, -1);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(807, 455);
            tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dateTimePicker3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(dateTimePicker2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox7);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox6);
            tabPage1.Controls.Add(btnReset);
            tabPage1.Controls.Add(btnUpdate);
            tabPage1.Controls.Add(btnADD);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(lblPhone);
            tabPage1.Controls.Add(lblNIF);
            tabPage1.Controls.Add(lblDate);
            tabPage1.Controls.Add(lblNome);
            tabPage1.Controls.Add(lblID);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(799, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro de Funcionários";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(566, 239);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(187, 24);
            dateTimePicker3.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(437, 239);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 22;
            label4.Text = "Termino:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(566, 196);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(187, 24);
            dateTimePicker2.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(437, 195);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 20;
            label3.Text = "Incio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(437, 105);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 19;
            label2.Text = "Função:";
            label2.Click += label2_Click;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(566, 99);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(160, 27);
            textBox7.TabIndex = 18;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(446, 54);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 17;
            label1.Text = "Tipo:";
            label1.Click += label1_Click;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(566, 52);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(160, 27);
            textBox6.TabIndex = 16;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(6, 387);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(57, 29);
            btnReset.TabIndex = 15;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(485, 332);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(117, 42);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Atualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnADD
            // 
            btnADD.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnADD.Location = new Point(192, 332);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(117, 42);
            btnADD.TabIndex = 13;
            btnADD.Text = "Adicionar";
            btnADD.UseVisualStyleBackColor = true;
            btnADD.Click += btnADD_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(168, 190);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(187, 24);
            dateTimePicker1.TabIndex = 12;
            dateTimePicker1.Value = new DateTime(2023, 7, 22, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.Location = new Point(437, 151);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(80, 25);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Contato:";
            lblPhone.Click += lblPhone_Click;
            // 
            // lblNIF
            // 
            lblNIF.AutoSize = true;
            lblNIF.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNIF.Location = new Point(76, 238);
            lblNIF.Name = "lblNIF";
            lblNIF.Size = new Size(43, 25);
            lblNIF.TabIndex = 9;
            lblNIF.Text = "NIF:";
            lblNIF.Click += lblNIF_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(29, 164);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(110, 50);
            lblDate.TabIndex = 8;
            lblDate.Text = "Data de \r\nNascimento:";
            lblDate.Click += lblDate_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(45, 118);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(65, 25);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome:";
            lblNome.Click += lblNome_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.Location = new Point(76, 65);
            lblID.Name = "lblID";
            lblID.Size = new Size(34, 25);
            lblID.TabIndex = 6;
            lblID.Text = "ID:";
            lblID.Click += lblID_Click;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(168, 119);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(187, 24);
            textBox5.TabIndex = 4;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(566, 145);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(160, 27);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(168, 236);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(168, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 24);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(lblSearch);
            tabPage2.Controls.Add(txtboxSearch);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(799, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Funcionários";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(787, 338);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.Location = new Point(205, 31);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(96, 25);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Pesquisar:";
            // 
            // txtboxSearch
            // 
            txtboxSearch.Location = new Point(326, 29);
            txtboxSearch.Name = "txtboxSearch";
            txtboxSearch.Size = new Size(307, 27);
            txtboxSearch.TabIndex = 0;
            txtboxSearch.TextChanged += txtboxSearch_TextChanged;
            // 
            // Funcionários
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 453);
            Controls.Add(tabControl);
            Name = "Funcionários";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funcionários";
            Load += Funcionários_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private Label label2;
        private TextBox textBox7;
        private Label label1;
        private TextBox textBox6;
        private Button btnReset;
        private Button btnUpdate;
        private Button btnADD;
        private DateTimePicker dateTimePicker1;
        private Label lblPhone;
        private Label lblNIF;
        private Label lblDate;
        private Label lblNome;
        private Label lblID;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private Label lblSearch;
        private TextBox txtboxSearch;
        private DateTimePicker dateTimePicker3;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Label label3;
    }
}