﻿namespace ConverterApp
{
    partial class frm_Main
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
            this.lbl_UofM = new System.Windows.Forms.Label();
            this.txt_UnitOfMeasure = new System.Windows.Forms.TextBox();
            this.btn_CM_to_Inches = new System.Windows.Forms.Button();
            this.btn_M_to_Feet = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Display = new System.Windows.Forms.Label();
            this.lbl_Convert = new System.Windows.Forms.Label();
            this.txt_Convert = new System.Windows.Forms.TextBox();
            this.btn_C_to_Fahrenheit = new System.Windows.Forms.Button();
            this.btn_CM_to_Feet = new System.Windows.Forms.Button();
            this.btn_K_to_Miles = new System.Windows.Forms.Button();
            this.readingsBox = new System.Windows.Forms.ListBox();
            this.btn_Clear_All = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_UofM
            // 
            this.lbl_UofM.AutoSize = true;
            this.lbl_UofM.Location = new System.Drawing.Point(129, 21);
            this.lbl_UofM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UofM.Name = "lbl_UofM";
            this.lbl_UofM.Size = new System.Drawing.Size(82, 13);
            this.lbl_UofM.TabIndex = 0;
            this.lbl_UofM.Text = "Unit of Measure";
            // 
            // txt_UnitOfMeasure
            // 
            this.txt_UnitOfMeasure.Location = new System.Drawing.Point(226, 18);
            this.txt_UnitOfMeasure.Margin = new System.Windows.Forms.Padding(2);
            this.txt_UnitOfMeasure.Name = "txt_UnitOfMeasure";
            this.txt_UnitOfMeasure.Size = new System.Drawing.Size(76, 20);
            this.txt_UnitOfMeasure.TabIndex = 1;
            this.txt_UnitOfMeasure.TextChanged += new System.EventHandler(this.txt_UnitOfMeasure_TextChanged);
            // 
            // btn_CM_to_Inches
            // 
            this.btn_CM_to_Inches.Location = new System.Drawing.Point(89, 53);
            this.btn_CM_to_Inches.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CM_to_Inches.Name = "btn_CM_to_Inches";
            this.btn_CM_to_Inches.Size = new System.Drawing.Size(122, 19);
            this.btn_CM_to_Inches.TabIndex = 2;
            this.btn_CM_to_Inches.Text = "Centimetres to Inches";
            this.btn_CM_to_Inches.UseVisualStyleBackColor = true;
            this.btn_CM_to_Inches.Click += new System.EventHandler(this.btn_CM_to_Inches_Click);
            // 
            // btn_M_to_Feet
            // 
            this.btn_M_to_Feet.Location = new System.Drawing.Point(89, 76);
            this.btn_M_to_Feet.Margin = new System.Windows.Forms.Padding(2);
            this.btn_M_to_Feet.Name = "btn_M_to_Feet";
            this.btn_M_to_Feet.Size = new System.Drawing.Size(122, 19);
            this.btn_M_to_Feet.TabIndex = 3;
            this.btn_M_to_Feet.Text = "Metres to Feet";
            this.btn_M_to_Feet.UseVisualStyleBackColor = true;
            this.btn_M_to_Feet.Click += new System.EventHandler(this.btn_M_to_Feet_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(378, 279);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(56, 19);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_Display
            // 
            this.lbl_Display.AutoSize = true;
            this.lbl_Display.Location = new System.Drawing.Point(146, 139);
            this.lbl_Display.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Display.Name = "lbl_Display";
            this.lbl_Display.Size = new System.Drawing.Size(0, 13);
            this.lbl_Display.TabIndex = 5;
            // 
            // lbl_Convert
            // 
            this.lbl_Convert.AutoSize = true;
            this.lbl_Convert.Location = new System.Drawing.Point(146, 198);
            this.lbl_Convert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Convert.Name = "lbl_Convert";
            this.lbl_Convert.Size = new System.Drawing.Size(0, 13);
            this.lbl_Convert.TabIndex = 6;
            // 
            // txt_Convert
            // 
            this.txt_Convert.Location = new System.Drawing.Point(149, 163);
            this.txt_Convert.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Convert.Name = "txt_Convert";
            this.txt_Convert.Size = new System.Drawing.Size(139, 20);
            this.txt_Convert.TabIndex = 7;
            // 
            // btn_C_to_Fahrenheit
            // 
            this.btn_C_to_Fahrenheit.Location = new System.Drawing.Point(226, 53);
            this.btn_C_to_Fahrenheit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_C_to_Fahrenheit.Name = "btn_C_to_Fahrenheit";
            this.btn_C_to_Fahrenheit.Size = new System.Drawing.Size(122, 19);
            this.btn_C_to_Fahrenheit.TabIndex = 8;
            this.btn_C_to_Fahrenheit.Text = "Celsius to Fahrenheit";
            this.btn_C_to_Fahrenheit.UseVisualStyleBackColor = true;
            this.btn_C_to_Fahrenheit.Click += new System.EventHandler(this.btn_C_to_Fahrenheit_Click);
            // 
            // btn_CM_to_Feet
            // 
            this.btn_CM_to_Feet.Location = new System.Drawing.Point(226, 76);
            this.btn_CM_to_Feet.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CM_to_Feet.Name = "btn_CM_to_Feet";
            this.btn_CM_to_Feet.Size = new System.Drawing.Size(122, 19);
            this.btn_CM_to_Feet.TabIndex = 9;
            this.btn_CM_to_Feet.Text = "Centimetres to Feet";
            this.btn_CM_to_Feet.UseVisualStyleBackColor = true;
            this.btn_CM_to_Feet.Click += new System.EventHandler(this.btn_C_to_Feet_Click);
            // 
            // btn_K_to_Miles
            // 
            this.btn_K_to_Miles.Location = new System.Drawing.Point(226, 99);
            this.btn_K_to_Miles.Margin = new System.Windows.Forms.Padding(2);
            this.btn_K_to_Miles.Name = "btn_K_to_Miles";
            this.btn_K_to_Miles.Size = new System.Drawing.Size(122, 19);
            this.btn_K_to_Miles.TabIndex = 10;
            this.btn_K_to_Miles.Text = "Kilometres to Miles";
            this.btn_K_to_Miles.UseVisualStyleBackColor = true;
            this.btn_K_to_Miles.Click += new System.EventHandler(this.btn_K_to_Miles_Click);
            // 
            // readingsBox
            // 
            this.readingsBox.FormattingEnabled = true;
            this.readingsBox.Location = new System.Drawing.Point(12, 203);
            this.readingsBox.Name = "readingsBox";
            this.readingsBox.Size = new System.Drawing.Size(120, 95);
            this.readingsBox.TabIndex = 11;
            this.readingsBox.SelectedIndexChanged += new System.EventHandler(this.readingsBox_SelectedIndexChanged);
            // 
            // btn_Clear_All
            // 
            this.btn_Clear_All.Location = new System.Drawing.Point(12, 174);
            this.btn_Clear_All.Name = "btn_Clear_All";
            this.btn_Clear_All.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear_All.TabIndex = 12;
            this.btn_Clear_All.Text = "Clear All";
            this.btn_Clear_All.UseVisualStyleBackColor = true;
            this.btn_Clear_All.Click += new System.EventHandler(this.btn_Clear_All_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 309);
            this.Controls.Add(this.btn_Clear_All);
            this.Controls.Add(this.readingsBox);
            this.Controls.Add(this.btn_K_to_Miles);
            this.Controls.Add(this.btn_CM_to_Feet);
            this.Controls.Add(this.btn_C_to_Fahrenheit);
            this.Controls.Add(this.txt_Convert);
            this.Controls.Add(this.lbl_Convert);
            this.Controls.Add(this.lbl_Display);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_M_to_Feet);
            this.Controls.Add(this.btn_CM_to_Inches);
            this.Controls.Add(this.txt_UnitOfMeasure);
            this.Controls.Add(this.lbl_UofM);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Main";
            this.Text = "ATCA Gas Converter";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UofM;
        private System.Windows.Forms.TextBox txt_UnitOfMeasure;
        private System.Windows.Forms.Button btn_CM_to_Inches;
        private System.Windows.Forms.Button btn_M_to_Feet;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Display;
        private System.Windows.Forms.Label lbl_Convert;
        private System.Windows.Forms.TextBox txt_Convert;
        private System.Windows.Forms.Button btn_C_to_Fahrenheit;
        private System.Windows.Forms.Button btn_CM_to_Feet;
        private System.Windows.Forms.Button btn_K_to_Miles;
        private System.Windows.Forms.ListBox readingsBox;
        private System.Windows.Forms.Button btn_Clear_All;
    }
}

