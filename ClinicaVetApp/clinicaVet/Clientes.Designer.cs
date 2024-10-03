namespace clinicaVet
{
    partial class Clientes
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
            btnReset = new Button();
            btnUpdate = new Button();
            btnADD = new Button();
            dateTimePicker1 = new DateTimePicker();
            lblState = new Label();
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
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(btnReset);
            tabPage1.Controls.Add(btnUpdate);
            tabPage1.Controls.Add(btnADD);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(lblState);
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
            tabPage1.Text = "Cadastro de Clientes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ativo", "Inativo" });
            comboBox1.Location = new Point(566, 236);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 28);
            comboBox1.TabIndex = 23;
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
            dateTimePicker1.Location = new Point(170, 236);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(187, 24);
            dateTimePicker1.TabIndex = 12;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblState.Location = new Point(425, 213);
            lblState.Name = "lblState";
            lblState.Size = new Size(98, 50);
            lblState.TabIndex = 11;
            lblState.Text = "Estado do \r\nCliente:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.Location = new Point(434, 139);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(80, 25);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Contato:";
            // 
            // lblNIF
            // 
            lblNIF.AutoSize = true;
            lblNIF.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNIF.Location = new Point(471, 70);
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
            lblDate.Location = new Point(26, 213);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(110, 50);
            lblDate.TabIndex = 8;
            lblDate.Text = "Data de \r\nNascimento:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(42, 139);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(65, 25);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.Location = new Point(73, 75);
            lblID.Name = "lblID";
            lblID.Size = new Size(34, 25);
            lblID.TabIndex = 6;
            lblID.Text = "ID:";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(170, 141);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(187, 24);
            textBox5.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(566, 136);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(160, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(566, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 27);
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
            tabPage2.Text = "Clientes";
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
            lblSearch.Location = new Point(202, 28);
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
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 453);
            Controls.Add(tabControl);
            Name = "Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += Clientes_Load;
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
        private DateTimePicker dateTimePicker1;
        private Label lblState;
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
        private Button btnReset;
        private Button btnUpdate;
        private Button btnADD;
        private DataGridView dataGridView1;
        private Label lblSearch;
        private TextBox txtboxSearch;
        private ComboBox comboBox1;
    }
}