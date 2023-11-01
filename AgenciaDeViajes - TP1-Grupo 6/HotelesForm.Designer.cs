﻿using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AgenciaDeViajes
{
    partial class HotelesForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePickerFechaDesde = new DateTimePicker();
            dateTimePickerFechaHasta = new DateTimePicker();
            numericUpDownCantidadPersonas = new NumericUpDown();
            listView1 = new ListView();
            comboBox1 = new ComboBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidadPersonas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Hoteles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 69);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Ciudad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 69);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha desde";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 69);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha hasta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(388, 69);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 4;
            label5.Text = "Cantidad personas";
            // 
            // dateTimePickerFechaDesde
            // 
            dateTimePickerFechaDesde.Format = DateTimePickerFormat.Short;
            dateTimePickerFechaDesde.Location = new Point(144, 87);
            dateTimePickerFechaDesde.Name = "dateTimePickerFechaDesde";
            dateTimePickerFechaDesde.Size = new Size(101, 23);
            dateTimePickerFechaDesde.TabIndex = 9;
            // 
            // dateTimePickerFechaHasta
            // 
            dateTimePickerFechaHasta.Format = DateTimePickerFormat.Short;
            dateTimePickerFechaHasta.Location = new Point(270, 87);
            dateTimePickerFechaHasta.Name = "dateTimePickerFechaHasta";
            dateTimePickerFechaHasta.Size = new Size(101, 23);
            dateTimePickerFechaHasta.TabIndex = 10;
            // 
            // numericUpDownCantidadPersonas
            // 
            numericUpDownCantidadPersonas.Location = new Point(392, 87);
            numericUpDownCantidadPersonas.Name = "numericUpDownCantidadPersonas";
            numericUpDownCantidadPersonas.Size = new Size(101, 23);
            numericUpDownCantidadPersonas.TabIndex = 11;
            // 
            // listView1
            // 
            listView1.Location = new Point(22, 160);
            listView1.Name = "listView1";
            listView1.Size = new Size(471, 150);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(22, 86);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(101, 23);
            comboBox1.TabIndex = 13;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(392, 125);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(101, 22);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // Hoteles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 342);
            Controls.Add(btnBuscar);
            Controls.Add(comboBox1);
            Controls.Add(listView1);
            Controls.Add(numericUpDownCantidadPersonas);
            Controls.Add(dateTimePickerFechaHasta);
            Controls.Add(dateTimePickerFechaDesde);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Hoteles";
            Text = "Hotelescs";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidadPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePickerFechaDesde;
        private DateTimePicker dateTimePickerFechaHasta;
        private NumericUpDown numericUpDownCantidadPersonas;
        private ListView listView1;
        private ComboBox comboBox1;
        private Button btnBuscar;
    }
}