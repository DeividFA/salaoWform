namespace Fashion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            DATA = new DataGridViewTextBoxColumn();
            NOME_CLIENTE = new DataGridViewTextBoxColumn();
            PROCEDIMENTO = new DataGridViewTextBoxColumn();
            VL_PAGO = new DataGridViewTextBoxColumn();
            FORMA_PAG = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(790, 93);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(225, 25);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 23);
            comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 23);
            textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DATA, NOME_CLIENTE, PROCEDIMENTO, VL_PAGO, FORMA_PAG });
            dataGridView1.Location = new Point(12, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(853, 255);
            dataGridView1.TabIndex = 3;
            // 
            // DATA
            // 
            DATA.HeaderText = "Data";
            DATA.Name = "DATA";
            DATA.ReadOnly = true;
            // 
            // NOME_CLIENTE
            // 
            NOME_CLIENTE.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NOME_CLIENTE.HeaderText = "Nome do Cliente";
            NOME_CLIENTE.Name = "NOME_CLIENTE";
            NOME_CLIENTE.ReadOnly = true;
            NOME_CLIENTE.Width = 300;
            // 
            // PROCEDIMENTO
            // 
            PROCEDIMENTO.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            PROCEDIMENTO.HeaderText = "Procedimento Realizado";
            PROCEDIMENTO.Name = "PROCEDIMENTO";
            PROCEDIMENTO.ReadOnly = true;
            PROCEDIMENTO.Width = 150;
            // 
            // VL_PAGO
            // 
            VL_PAGO.HeaderText = "Valor Pago";
            VL_PAGO.Name = "VL_PAGO";
            VL_PAGO.ReadOnly = true;
            // 
            // FORMA_PAG
            // 
            FORMA_PAG.HeaderText = "Forma de Pagamento";
            FORMA_PAG.Name = "FORMA_PAG";
            FORMA_PAG.ReadOnly = true;
            FORMA_PAG.Width = 150;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(12, 25);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(135, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(615, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(147, 23);
            textBox2.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(343, 93);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(213, 23);
            comboBox2.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(240, 94);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 466);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn DATA;
        private DataGridViewTextBoxColumn NOME_CLIENTE;
        private DataGridViewTextBoxColumn PROCEDIMENTO;
        private DataGridViewTextBoxColumn VL_PAGO;
        private DataGridViewTextBoxColumn FORMA_PAG;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private Button button2;
    }
}
