namespace RegistroArticulos.UI.Consultas
{
    partial class cArticulos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Consultar_button = new System.Windows.Forms.Button();
            this.Criterio_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Filtro_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fecha_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Consulta_dataGridView = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Desde_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Hasta_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Rango_groupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Consulta_dataGridView)).BeginInit();
            this.Rango_groupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 59);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RegistroArticulos.Properties.Resources.Modify;
            this.pictureBox1.Location = new System.Drawing.Point(69, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(145, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Sobre Un Producto o Articulo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Consultar_button);
            this.groupBox2.Controls.Add(this.Criterio_textBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Filtro_comboBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(4, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 71);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones Consulta";
            // 
            // Consultar_button
            // 
            this.Consultar_button.Image = global::RegistroArticulos.Properties.Resources.find;
            this.Consultar_button.Location = new System.Drawing.Point(574, 22);
            this.Consultar_button.Name = "Consultar_button";
            this.Consultar_button.Size = new System.Drawing.Size(41, 37);
            this.Consultar_button.TabIndex = 2;
            this.toolTip1.SetToolTip(this.Consultar_button, "Consultar Articulo");
            this.Consultar_button.UseVisualStyleBackColor = true;
            this.Consultar_button.Click += new System.EventHandler(this.Consultar_button_Click);
            // 
            // Criterio_textBox
            // 
            this.Criterio_textBox.Enabled = false;
            this.Criterio_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Criterio_textBox.Location = new System.Drawing.Point(299, 31);
            this.Criterio_textBox.Name = "Criterio_textBox";
            this.Criterio_textBox.Size = new System.Drawing.Size(263, 22);
            this.Criterio_textBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Criterio_textBox, "Introduzca Un Criterio De La Opcion Selecionada");
            this.Criterio_textBox.TextChanged += new System.EventHandler(this.Criterio_textBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Criterio";
            // 
            // Filtro_comboBox
            // 
            this.Filtro_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filtro_comboBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtro_comboBox.FormattingEnabled = true;
            this.Filtro_comboBox.Items.AddRange(new object[] {
            "Todos",
            "Articulo Id",
            "Descripcion",
            "Fecha Vencimiento",
            "Rango De Fecha",
            "Descripcion & Rango"});
            this.Filtro_comboBox.Location = new System.Drawing.Point(68, 30);
            this.Filtro_comboBox.Name = "Filtro_comboBox";
            this.Filtro_comboBox.Size = new System.Drawing.Size(145, 23);
            this.Filtro_comboBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Filtro_comboBox, "Seleccione El Filtro Deseado Para Consultar");
            this.Filtro_comboBox.SelectedIndexChanged += new System.EventHandler(this.Filtro_comboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filtro";
            // 
            // Fecha_dateTimePicker
            // 
            this.Fecha_dateTimePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_dateTimePicker.Enabled = false;
            this.Fecha_dateTimePicker.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha_dateTimePicker.Location = new System.Drawing.Point(144, 16);
            this.Fecha_dateTimePicker.Name = "Fecha_dateTimePicker";
            this.Fecha_dateTimePicker.Size = new System.Drawing.Size(104, 22);
            this.Fecha_dateTimePicker.TabIndex = 3;
            this.toolTip1.SetToolTip(this.Fecha_dateTimePicker, "Seleccione Una Fecha Exacta ");
            // 
            // Consulta_dataGridView
            // 
            this.Consulta_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Consulta_dataGridView.Location = new System.Drawing.Point(4, 179);
            this.Consulta_dataGridView.Name = "Consulta_dataGridView";
            this.Consulta_dataGridView.ReadOnly = true;
            this.Consulta_dataGridView.Size = new System.Drawing.Size(696, 343);
            this.Consulta_dataGridView.TabIndex = 12;
            // 
            // Desde_dateTimePicker
            // 
            this.Desde_dateTimePicker.Enabled = false;
            this.Desde_dateTimePicker.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desde_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Desde_dateTimePicker.Location = new System.Drawing.Point(67, 15);
            this.Desde_dateTimePicker.Name = "Desde_dateTimePicker";
            this.Desde_dateTimePicker.Size = new System.Drawing.Size(106, 22);
            this.Desde_dateTimePicker.TabIndex = 3;
            this.toolTip1.SetToolTip(this.Desde_dateTimePicker, "De Que Fecha Empezara");
            // 
            // Hasta_dateTimePicker
            // 
            this.Hasta_dateTimePicker.Enabled = false;
            this.Hasta_dateTimePicker.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hasta_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Hasta_dateTimePicker.Location = new System.Drawing.Point(264, 16);
            this.Hasta_dateTimePicker.Name = "Hasta_dateTimePicker";
            this.Hasta_dateTimePicker.Size = new System.Drawing.Size(103, 22);
            this.Hasta_dateTimePicker.TabIndex = 4;
            this.toolTip1.SetToolTip(this.Hasta_dateTimePicker, "En Que Fecha Terminara");
            // 
            // Rango_groupBox
            // 
            this.Rango_groupBox.Controls.Add(this.Hasta_dateTimePicker);
            this.Rango_groupBox.Controls.Add(this.Desde_dateTimePicker);
            this.Rango_groupBox.Controls.Add(this.label5);
            this.Rango_groupBox.Controls.Add(this.label4);
            this.Rango_groupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rango_groupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.Rango_groupBox.Location = new System.Drawing.Point(4, 126);
            this.Rango_groupBox.Name = "Rango_groupBox";
            this.Rango_groupBox.Size = new System.Drawing.Size(408, 47);
            this.Rango_groupBox.TabIndex = 13;
            this.Rango_groupBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Desde";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Fecha_dateTimePicker);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(433, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 47);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fecha Vencimiento";
            // 
            // cArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(707, 528);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Rango_groupBox);
            this.Controls.Add(this.Consulta_dataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "cArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Articulos";
            this.Load += new System.EventHandler(this.cArticulos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Consulta_dataGridView)).EndInit();
            this.Rango_groupBox.ResumeLayout(false);
            this.Rango_groupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Criterio_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Filtro_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Consulta_dataGridView;
        private System.Windows.Forms.Button Consultar_button;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker Fecha_dateTimePicker;
        private System.Windows.Forms.GroupBox Rango_groupBox;
        private System.Windows.Forms.DateTimePicker Hasta_dateTimePicker;
        private System.Windows.Forms.DateTimePicker Desde_dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
    }
}