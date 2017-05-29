namespace Forms
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.MotionComboBox = new System.Windows.Forms.ComboBox();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.StartSpeedTextBox = new System.Windows.Forms.TextBox();
            this.Acceleration = new System.Windows.Forms.TextBox();
            this.StartCoordinateTextBox = new System.Windows.Forms.TextBox();
            this.FreequencyTextBox = new System.Windows.Forms.TextBox();
            this.AmplitudeTextBox = new System.Windows.Forms.TextBox();
            this.StartPhaseTextBox = new System.Windows.Forms.TextBox();
            this.AddFormGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddFormGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(12, 288);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(107, 288);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(68, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // MotionComboBox
            // 
            this.MotionComboBox.FormattingEnabled = true;
            this.MotionComboBox.Items.AddRange(new object[] {
            "Равноускоренное",
            "Равномерное",
            "Колебательное"});
            this.MotionComboBox.Location = new System.Drawing.Point(24, 25);
            this.MotionComboBox.Name = "MotionComboBox";
            this.MotionComboBox.Size = new System.Drawing.Size(133, 21);
            this.MotionComboBox.TabIndex = 0;
            this.MotionComboBox.SelectedIndexChanged += new System.EventHandler(this.MotionComboBox_SelectedIndexChanged);
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(12, 32);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(124, 20);
            this.TimeTextBox.TabIndex = 3;
            this.TimeTextBox.TextChanged += new System.EventHandler(this.TimeTextBox_TextChanged);
            // 
            // StartSpeedTextBox
            // 
            this.StartSpeedTextBox.Location = new System.Drawing.Point(12, 110);
            this.StartSpeedTextBox.Name = "StartSpeedTextBox";
            this.StartSpeedTextBox.Size = new System.Drawing.Size(124, 20);
            this.StartSpeedTextBox.TabIndex = 4;
            // 
            // Acceleration
            // 
            this.Acceleration.Location = new System.Drawing.Point(12, 153);
            this.Acceleration.Name = "Acceleration";
            this.Acceleration.Size = new System.Drawing.Size(124, 20);
            this.Acceleration.TabIndex = 5;
            // 
            // StartCoordinateTextBox
            // 
            this.StartCoordinateTextBox.Location = new System.Drawing.Point(12, 71);
            this.StartCoordinateTextBox.Name = "StartCoordinateTextBox";
            this.StartCoordinateTextBox.Size = new System.Drawing.Size(124, 20);
            this.StartCoordinateTextBox.TabIndex = 6;
            // 
            // FreequencyTextBox
            // 
            this.FreequencyTextBox.Location = new System.Drawing.Point(145, 32);
            this.FreequencyTextBox.Name = "FreequencyTextBox";
            this.FreequencyTextBox.Size = new System.Drawing.Size(121, 20);
            this.FreequencyTextBox.TabIndex = 7;
            this.FreequencyTextBox.TextChanged += new System.EventHandler(this.FreequencyTextBox_TextChanged);
            // 
            // AmplitudeTextBox
            // 
            this.AmplitudeTextBox.Location = new System.Drawing.Point(145, 71);
            this.AmplitudeTextBox.Name = "AmplitudeTextBox";
            this.AmplitudeTextBox.Size = new System.Drawing.Size(121, 20);
            this.AmplitudeTextBox.TabIndex = 8;
            // 
            // StartPhaseTextBox
            // 
            this.StartPhaseTextBox.Location = new System.Drawing.Point(145, 110);
            this.StartPhaseTextBox.Name = "StartPhaseTextBox";
            this.StartPhaseTextBox.Size = new System.Drawing.Size(121, 20);
            this.StartPhaseTextBox.TabIndex = 9;
            // 
            // AddFormGroupBox
            // 
            this.AddFormGroupBox.Controls.Add(this.label7);
            this.AddFormGroupBox.Controls.Add(this.label6);
            this.AddFormGroupBox.Controls.Add(this.label5);
            this.AddFormGroupBox.Controls.Add(this.label4);
            this.AddFormGroupBox.Controls.Add(this.label3);
            this.AddFormGroupBox.Controls.Add(this.label2);
            this.AddFormGroupBox.Controls.Add(this.label1);
            this.AddFormGroupBox.Controls.Add(this.TimeTextBox);
            this.AddFormGroupBox.Controls.Add(this.StartSpeedTextBox);
            this.AddFormGroupBox.Controls.Add(this.Acceleration);
            this.AddFormGroupBox.Controls.Add(this.StartCoordinateTextBox);
            this.AddFormGroupBox.Controls.Add(this.StartPhaseTextBox);
            this.AddFormGroupBox.Controls.Add(this.FreequencyTextBox);
            this.AddFormGroupBox.Controls.Add(this.AmplitudeTextBox);
            this.AddFormGroupBox.Location = new System.Drawing.Point(12, 51);
            this.AddFormGroupBox.Name = "AddFormGroupBox";
            this.AddFormGroupBox.Size = new System.Drawing.Size(275, 231);
            this.AddFormGroupBox.TabIndex = 10;
            this.AddFormGroupBox.TabStop = false;
            this.AddFormGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Частота:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Начальная фаза:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Амплитуда:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Начальная скорость:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ускорение:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Начальная координата:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Время:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Выберите тип движения:";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 327);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddFormGroupBox);
            this.Controls.Add(this.MotionComboBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddForm";
            this.Text = "AddForms";
            this.Load += new System.EventHandler(this.AddForms_Load);
            this.AddFormGroupBox.ResumeLayout(false);
            this.AddFormGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox MotionComboBox;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.TextBox StartSpeedTextBox;
        private System.Windows.Forms.TextBox Acceleration;
        private System.Windows.Forms.TextBox StartCoordinateTextBox;
        private System.Windows.Forms.TextBox FreequencyTextBox;
        private System.Windows.Forms.TextBox AmplitudeTextBox;
        private System.Windows.Forms.TextBox StartPhaseTextBox;
        private System.Windows.Forms.GroupBox AddFormGroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}