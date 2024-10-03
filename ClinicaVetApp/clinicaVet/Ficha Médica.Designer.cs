namespace clinicaVet
{
    partial class Ficha_Médica
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
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            label2 = new Label();
            textBox10 = new TextBox();
            label4 = new Label();
            textBox9 = new TextBox();
            lblSex = new Label();
            textBox7 = new TextBox();
            dateTimePicker3 = new DateTimePicker();
            label3 = new Label();
            btnReset = new Button();
            btnUpdate = new Button();
            btnADD = new Button();
            dateTimePicker1 = new DateTimePicker();
            lblRace = new Label();
            lbType = new Label();
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
            label1 = new Label();
            textBox6 = new TextBox();
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
            tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox10);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(textBox9);
            tabPage1.Controls.Add(lblSex);
            tabPage1.Controls.Add(textBox7);
            tabPage1.Controls.Add(dateTimePicker3);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox6);
            tabPage1.Controls.Add(btnReset);
            tabPage1.Controls.Add(btnUpdate);
            tabPage1.Controls.Add(btnADD);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(lblRace);
            tabPage1.Controls.Add(lbType);
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
            tabPage1.Text = "Ficha Médica";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00" });
            comboBox1.Location = new Point(169, 163);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 28);
            comboBox1.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(436, 221);
            label6.Name = "label6";
            label6.Size = new Size(118, 25);
            label6.TabIndex = 33;
            label6.Text = "Observações:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(576, 221);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(187, 75);
            textBox4.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(29, 162);
            label5.Name = "label5";
            label5.Size = new Size(109, 25);
            label5.TabIndex = 31;
            label5.Text = "Ato Médico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 221);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 29;
            label2.Text = "Diagonóstico:";
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox10.Location = new Point(169, 221);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(187, 75);
            textBox10.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(551, 15);
            label4.Name = "label4";
            label4.Size = new Size(103, 23);
            label4.TabIndex = 27;
            label4.Text = "Funcionário:";
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(660, 12);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 30);
            textBox9.TabIndex = 26;
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSex.Location = new Point(439, 108);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(91, 50);
            lblSex.TabIndex = 23;
            lblSex.Text = "Prescrição\r\nMédica:";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(574, 131);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(160, 27);
            textBox7.TabIndex = 22;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(169, 76);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(187, 24);
            dateTimePicker3.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 76);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 20;
            label3.Text = "Data Consulta:";
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
            dateTimePicker1.Location = new Point(575, 181);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(187, 24);
            dateTimePicker1.TabIndex = 12;
            // 
            // lblRace
            // 
            lblRace.AutoSize = true;
            lblRace.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblRace.Location = new Point(439, 66);
            lblRace.Name = "lblRace";
            lblRace.Size = new Size(53, 25);
            lblRace.TabIndex = 10;
            lblRace.Text = "Peso:";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbType.Location = new Point(29, 118);
            lbType.Name = "lbType";
            lbType.Size = new Size(150, 25);
            lbType.TabIndex = 9;
            lbType.Text = "Tipo de Consulta:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(439, 180);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(127, 25);
            lblDate.TabIndex = 8;
            lblDate.Text = "Proxima Visita:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(237, 14);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(119, 23);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome Animal:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.Location = new Point(8, 14);
            lblID.Name = "lblID";
            lblID.Size = new Size(31, 23);
            lblID.TabIndex = 6;
            lblID.Text = "ID:";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(358, 11);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(187, 30);
            textBox5.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(574, 61);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(160, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(185, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(45, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(43, 30);
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
            tabPage2.Text = "Historico do Animal";
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
            lblSearch.Location = new Point(208, 34);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(94, 14);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 17;
            label1.Text = "Dono ID:";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(178, 12);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(53, 30);
            textBox6.TabIndex = 16;
            // 
            // Ficha_Médica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 453);
            Controls.Add(tabControl);
            Name = "Ficha_Médica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ficha_Médica";
            Load += Ficha_Médica_Load;
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
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private Label label2;
        private TextBox textBox10;
        private Label label4;
        private TextBox textBox9;
        private Label lblSex;
        private TextBox textBox7;
        private DateTimePicker dateTimePicker3;
        private Label label3;
        private Button btnReset;
        private Button btnUpdate;
        private Button btnADD;
        private DateTimePicker dateTimePicker1;
        private Label lblRace;
        private Label lbType;
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
        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox6;
    }
}