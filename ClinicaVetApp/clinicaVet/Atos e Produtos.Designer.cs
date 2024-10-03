namespace clinicaVet
{
    partial class Atos_e_Produtos
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
            dataGridView2 = new DataGridView();
            label4 = new Label();
            textBox5 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            btnReset = new Button();
            btnUpdate = new Button();
            btnADD = new Button();
            lblNIF = new Label();
            textBox2 = new TextBox();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox8 = new TextBox();
            label8 = new Label();
            textBox9 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label9 = new Label();
            textBox10 = new TextBox();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(btnReset);
            tabPage1.Controls.Add(btnUpdate);
            tabPage1.Controls.Add(btnADD);
            tabPage1.Controls.Add(lblNIF);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(799, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Atos Médicos";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(345, 22);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(435, 310);
            dataGridView2.TabIndex = 24;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(41, 213);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 23;
            label4.Text = "Preço:";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(120, 214);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(160, 27);
            textBox5.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 163);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 21;
            label3.Text = "Nome:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(120, 164);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(160, 27);
            textBox4.TabIndex = 20;
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
            btnUpdate.Location = new Point(648, 361);
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
            btnADD.Location = new Point(355, 361);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(117, 42);
            btnADD.TabIndex = 13;
            btnADD.Text = "Adicionar";
            btnADD.UseVisualStyleBackColor = true;
            btnADD.Click += btnADD_Click;
            // 
            // lblNIF
            // 
            lblNIF.AutoSize = true;
            lblNIF.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNIF.Location = new Point(41, 112);
            lblNIF.Name = "lblNIF";
            lblNIF.Size = new Size(34, 25);
            lblNIF.TabIndex = 9;
            lblNIF.Text = "ID:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(120, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 27);
            textBox2.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(textBox8);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(textBox9);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(textBox10);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(799, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Produtos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(349, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(435, 310);
            dataGridView1.TabIndex = 38;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(75, 279);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 37;
            label5.Text = "Preço:";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(154, 280);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(160, 27);
            textBox6.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(75, 96);
            label6.Name = "label6";
            label6.Size = new Size(51, 25);
            label6.TabIndex = 35;
            label6.Text = "Tipo:";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(154, 97);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(160, 27);
            textBox7.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(26, 141);
            label7.Name = "label7";
            label7.Size = new Size(122, 50);
            label7.TabIndex = 33;
            label7.Text = "Quantidade \r\nem Armazem:";
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(154, 164);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(160, 27);
            textBox8.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(34, 217);
            label8.Name = "label8";
            label8.Size = new Size(92, 25);
            label8.TabIndex = 31;
            label8.Text = "Descrição:";
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(154, 215);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(160, 49);
            textBox9.TabIndex = 30;
            // 
            // button1
            // 
            button1.Location = new Point(10, 384);
            button1.Name = "button1";
            button1.Size = new Size(57, 29);
            button1.TabIndex = 29;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(652, 358);
            button2.Name = "button2";
            button2.Size = new Size(117, 42);
            button2.TabIndex = 28;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(359, 358);
            button3.Name = "button3";
            button3.Size = new Size(117, 42);
            button3.TabIndex = 27;
            button3.Text = "Adicionar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(75, 45);
            label9.Name = "label9";
            label9.Size = new Size(34, 25);
            label9.TabIndex = 26;
            label9.Text = "ID:";
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox10.Location = new Point(154, 46);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(160, 27);
            textBox10.TabIndex = 25;
            // 
            // Atos_e_Produtos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 453);
            Controls.Add(tabControl);
            Name = "Atos_e_Produtos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atos_e_Produtos";
            Load += Atos_e_Produtos_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private Button btnReset;
        private Button btnUpdate;
        private Button btnADD;
        private Label lblNIF;
        private TextBox textBox2;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private Label label4;
        private TextBox textBox5;
        private Label label3;
        private TextBox textBox4;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox8;
        private Label label8;
        private TextBox textBox9;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label9;
        private TextBox textBox10;
    }
}