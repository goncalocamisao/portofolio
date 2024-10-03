namespace clinicaVet
{
    partial class Animais
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
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            lblWeight = new Label();
            textBox8 = new TextBox();
            lblSex = new Label();
            dateTimePicker3 = new DateTimePicker();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            btnReset = new Button();
            btnUpdate = new Button();
            btnADD = new Button();
            dateTimePicker1 = new DateTimePicker();
            lblState = new Label();
            lblRace = new Label();
            lbType = new Label();
            lblDate = new Label();
            lblNome = new Label();
            lblID = new Label();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
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
            tabPage1.Controls.Add(comboBox3);
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(lblWeight);
            tabPage1.Controls.Add(textBox8);
            tabPage1.Controls.Add(lblSex);
            tabPage1.Controls.Add(dateTimePicker3);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(dateTimePicker2);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(btnReset);
            tabPage1.Controls.Add(btnUpdate);
            tabPage1.Controls.Add(btnADD);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(lblState);
            tabPage1.Controls.Add(lblRace);
            tabPage1.Controls.Add(lbType);
            tabPage1.Controls.Add(lblDate);
            tabPage1.Controls.Add(lblNome);
            tabPage1.Controls.Add(lblID);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(799, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro de Animais";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Cão", "Gato" });
            comboBox3.Location = new Point(566, 110);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(160, 28);
            comboBox3.TabIndex = 28;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Ativo", "Inativo" });
            comboBox2.Location = new Point(566, 277);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(160, 28);
            comboBox2.TabIndex = 27;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Macho", "Fêmea" });
            comboBox1.Location = new Point(566, 179);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 28);
            comboBox1.TabIndex = 26;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblWeight.Location = new Point(428, 221);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(53, 25);
            lblWeight.TabIndex = 25;
            lblWeight.Text = "Peso:";
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(566, 219);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(160, 27);
            textBox8.TabIndex = 24;
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSex.Location = new Point(428, 183);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(54, 25);
            lblSex.TabIndex = 23;
            lblSex.Text = "Sexo:";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(566, 72);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(187, 24);
            dateTimePicker3.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(428, 46);
            label3.Name = "label3";
            label3.Size = new Size(116, 50);
            label3.TabIndex = 20;
            label3.Text = "Data da\r\nUlt. Consulta:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(170, 269);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(187, 24);
            dateTimePicker2.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 243);
            label2.Name = "label2";
            label2.Size = new Size(110, 50);
            label2.TabIndex = 18;
            label2.Text = "Data de\r\nFalecimento:";
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
            dateTimePicker1.Location = new Point(170, 206);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(187, 24);
            dateTimePicker1.TabIndex = 12;
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblState.Location = new Point(428, 255);
            lblState.Name = "lblState";
            lblState.Size = new Size(98, 50);
            lblState.TabIndex = 11;
            lblState.Text = "Estado do \r\nAnimal:";
            // 
            // lblRace
            // 
            lblRace.AutoSize = true;
            lblRace.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblRace.Location = new Point(428, 148);
            lblRace.Name = "lblRace";
            lblRace.Size = new Size(53, 25);
            lblRace.TabIndex = 10;
            lblRace.Text = "Raça:";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbType.Location = new Point(428, 112);
            lbType.Name = "lbType";
            lbType.Size = new Size(51, 25);
            lbType.TabIndex = 9;
            lbType.Text = "Tipo:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(26, 180);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(110, 50);
            lblDate.TabIndex = 8;
            lblDate.Text = "Data de \r\nNascimento:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(26, 141);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(65, 25);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.Location = new Point(26, 72);
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
            textBox3.Location = new Point(566, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(160, 27);
            textBox3.TabIndex = 2;
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
            tabPage2.Text = "Animais";
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
            // Animais
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 453);
            Controls.Add(tabControl);
            Name = "Animais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Animais";
            Load += Animais_Load;
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
        private Label lblWeight;
        private TextBox textBox8;
        private Label lblSex;
        private DateTimePicker dateTimePicker3;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Button btnReset;
        private Button btnUpdate;
        private Button btnADD;
        private DateTimePicker dateTimePicker1;
        private Label lblState;
        private Label lblRace;
        private Label lbType;
        private Label lblDate;
        private Label lblNome;
        private Label lblID;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private Label lblSearch;
        private TextBox txtboxSearch;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}