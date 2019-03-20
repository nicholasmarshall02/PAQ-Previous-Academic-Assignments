namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.textBoxMedical = new System.Windows.Forms.TextBox();
            this.textBoxSurgical = new System.Windows.Forms.TextBox();
            this.textBoxLab = new System.Windows.Forms.TextBox();
            this.textBoxRehab = new System.Windows.Forms.TextBox();
            this.labelDays = new System.Windows.Forms.Label();
            this.labelMedical = new System.Windows.Forms.Label();
            this.labelSurgical = new System.Windows.Forms.Label();
            this.labelLab = new System.Windows.Forms.Label();
            this.labelRehab = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelStay = new System.Windows.Forms.Label();
            this.labelMisc = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDays
            // 
            this.textBoxDays.Location = new System.Drawing.Point(154, 24);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.Size = new System.Drawing.Size(100, 20);
            this.textBoxDays.TabIndex = 0;
            // 
            // textBoxMedical
            // 
            this.textBoxMedical.Location = new System.Drawing.Point(154, 62);
            this.textBoxMedical.Name = "textBoxMedical";
            this.textBoxMedical.Size = new System.Drawing.Size(100, 20);
            this.textBoxMedical.TabIndex = 1;
            // 
            // textBoxSurgical
            // 
            this.textBoxSurgical.Location = new System.Drawing.Point(154, 103);
            this.textBoxSurgical.Name = "textBoxSurgical";
            this.textBoxSurgical.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurgical.TabIndex = 2;
            // 
            // textBoxLab
            // 
            this.textBoxLab.Location = new System.Drawing.Point(154, 141);
            this.textBoxLab.Name = "textBoxLab";
            this.textBoxLab.Size = new System.Drawing.Size(100, 20);
            this.textBoxLab.TabIndex = 3;
            // 
            // textBoxRehab
            // 
            this.textBoxRehab.Location = new System.Drawing.Point(154, 186);
            this.textBoxRehab.Name = "textBoxRehab";
            this.textBoxRehab.Size = new System.Drawing.Size(100, 20);
            this.textBoxRehab.TabIndex = 4;
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Location = new System.Drawing.Point(53, 27);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(83, 13);
            this.labelDays.TabIndex = 5;
            this.labelDays.Text = "Days in Hospital";
            // 
            // labelMedical
            // 
            this.labelMedical.AutoSize = true;
            this.labelMedical.Location = new System.Drawing.Point(53, 65);
            this.labelMedical.Name = "labelMedical";
            this.labelMedical.Size = new System.Drawing.Size(80, 13);
            this.labelMedical.TabIndex = 6;
            this.labelMedical.Text = "Medication Fee";
            // 
            // labelSurgical
            // 
            this.labelSurgical.AutoSize = true;
            this.labelSurgical.Location = new System.Drawing.Point(67, 106);
            this.labelSurgical.Name = "labelSurgical";
            this.labelSurgical.Size = new System.Drawing.Size(66, 13);
            this.labelSurgical.TabIndex = 7;
            this.labelSurgical.Text = "Surgical Fee";
            // 
            // labelLab
            // 
            this.labelLab.AutoSize = true;
            this.labelLab.Location = new System.Drawing.Point(83, 148);
            this.labelLab.Name = "labelLab";
            this.labelLab.Size = new System.Drawing.Size(46, 13);
            this.labelLab.TabIndex = 8;
            this.labelLab.Text = "Lab Fee";
            // 
            // labelRehab
            // 
            this.labelRehab.AutoSize = true;
            this.labelRehab.Location = new System.Drawing.Point(27, 189);
            this.labelRehab.Name = "labelRehab";
            this.labelRehab.Size = new System.Drawing.Size(102, 13);
            this.labelRehab.TabIndex = 9;
            this.labelRehab.Text = "Physical Rehab Fee";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Stay Charges:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Misc Charges:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Total Charges:";
            // 
            // labelStay
            // 
            this.labelStay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStay.Location = new System.Drawing.Point(154, 219);
            this.labelStay.Name = "labelStay";
            this.labelStay.Size = new System.Drawing.Size(100, 23);
            this.labelStay.TabIndex = 13;
            // 
            // labelMisc
            // 
            this.labelMisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMisc.Location = new System.Drawing.Point(154, 251);
            this.labelMisc.Name = "labelMisc";
            this.labelMisc.Size = new System.Drawing.Size(100, 23);
            this.labelMisc.TabIndex = 14;
            // 
            // labelTotal
            // 
            this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotal.Location = new System.Drawing.Point(154, 287);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(100, 23);
            this.labelTotal.TabIndex = 15;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(30, 333);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonCalc.TabIndex = 16;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(138, 333);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(249, 333);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 18;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 377);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelMisc);
            this.Controls.Add(this.labelStay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelRehab);
            this.Controls.Add(this.labelLab);
            this.Controls.Add(this.labelSurgical);
            this.Controls.Add(this.labelMedical);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.textBoxRehab);
            this.Controls.Add(this.textBoxLab);
            this.Controls.Add(this.textBoxSurgical);
            this.Controls.Add(this.textBoxMedical);
            this.Controls.Add(this.textBoxDays);
            this.Name = "Form1";
            this.Text = "Hospital Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDays;
        private System.Windows.Forms.TextBox textBoxMedical;
        private System.Windows.Forms.TextBox textBoxSurgical;
        private System.Windows.Forms.TextBox textBoxLab;
        private System.Windows.Forms.TextBox textBoxRehab;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Label labelMedical;
        private System.Windows.Forms.Label labelSurgical;
        private System.Windows.Forms.Label labelLab;
        private System.Windows.Forms.Label labelRehab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelStay;
        private System.Windows.Forms.Label labelMisc;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClose;
    }
}

