namespace clinicaVet
{
    partial class Agendamento
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
            comboBox1 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            textBox7 = new TextBox();
            btnReset = new Button();
            btnUpdate = new Button();
            btnADD = new Button();
            lblState = new Label();
            lblPhone = new Label();
            lblFunc = new Label();
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
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(dateTimePicker2);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox7);
            tabPage1.Controls.Add(btnReset);
            tabPage1.Controls.Add(btnUpdate);
            tabPage1.Controls.Add(btnADD);
            tabPage1.Controls.Add(lblState);
            tabPage1.Controls.Add(lblPhone);
            tabPage1.Controls.Add(lblFunc);
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
            tabPage1.Text = "Agendamento";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00" });
            comboBox1.Location = new Point(566, 238);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(172, 28);
            comboBox1.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(566, 177);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(172, 24);
            dateTimePicker2.TabIndex = 21;
            dateTimePicker2.Value = new DateTime(2023, 7, 22, 2, 26, 22, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(428, 151);
            label2.Name = "label2";
            label2.Size = new Size(85, 50);
            label2.TabIndex = 20;
            label2.Text = "Data da\r\nConsulta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 216);
            label1.Name = "label1";
            label1.Size = new Size(85, 50);
            label1.TabIndex = 19;
            label1.Text = "Tipo de \r\nConsulta:";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(170, 242);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(187, 24);
            textBox7.TabIndex = 18;
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
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblState.Location = new Point(428, 216);
            lblState.Name = "lblState";
            lblState.Size = new Size(85, 50);
            lblState.TabIndex = 11;
            lblState.Text = "Hora da\r\nConsulta:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.Location = new Point(428, 117);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(80, 25);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Contato:";
            // 
            // lblFunc
            // 
            lblFunc.AutoSize = true;
            lblFunc.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblFunc.Location = new Point(428, 73);
            lblFunc.Name = "lblFunc";
            lblFunc.Size = new Size(108, 25);
            lblFunc.TabIndex = 9;
            lblFunc.Text = "Funcionário:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(45, 151);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(93, 50);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome do \r\nAnimal:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.Location = new Point(45, 73);
            lblID.Name = "lblID";
            lblID.Size = new Size(34, 25);
            lblID.TabIndex = 6;
            lblID.Text = "ID:";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(170, 177);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(187, 24);
            textBox5.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(566, 118);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(566, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(170, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 24);
            textBox1.TabIndex = 0;
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
            tabPage2.Text = "Consultas";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
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
            // Agendamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 453);
            Controls.Add(tabControl);
            Name = "Agendamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agendamento";
            Load += Agendamento_Load;
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
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Label label1;
        private TextBox textBox7;
        private Button btnReset;
        private Button btnUpdate;
        private Button btnADD;
        private Label lblState;
        private Label lblPhone;
        private Label lblFunc;
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
        private ComboBox comboBox1;
    }
}