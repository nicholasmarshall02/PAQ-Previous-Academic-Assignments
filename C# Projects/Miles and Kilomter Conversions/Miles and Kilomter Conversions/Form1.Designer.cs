namespace Miles_and_Kilomter_Conversions
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblConvertedDistance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxTo = new System.Windows.Forms.ListBox();
            this.listBoxFrom = new System.Windows.Forms.ListBox();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(246, 264);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 16;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblConvertedDistance
            // 
            this.lblConvertedDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConvertedDistance.Location = new System.Drawing.Point(248, 220);
            this.lblConvertedDistance.Name = "lblConvertedDistance";
            this.lblConvertedDistance.Size = new System.Drawing.Size(100, 23);
            this.lblConvertedDistance.TabIndex = 15;
            this.lblConvertedDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Converted Distance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "From:";
            // 
            // listBoxTo
            // 
            this.listBoxTo.FormattingEnabled = true;
            this.listBoxTo.Items.AddRange(new object[] {
            "Kilometers",
            "Miles"});
            this.listBoxTo.Location = new System.Drawing.Point(246, 130);
            this.listBoxTo.Name = "listBoxTo";
            this.listBoxTo.Size = new System.Drawing.Size(120, 30);
            this.listBoxTo.TabIndex = 12;
            // 
            // listBoxFrom
            // 
            this.listBoxFrom.FormattingEnabled = true;
            this.listBoxFrom.Items.AddRange(new object[] {
            "Kilometers",
            "Miles"});
            this.listBoxFrom.Location = new System.Drawing.Point(60, 130);
            this.listBoxFrom.Name = "listBoxFrom";
            this.listBoxFrom.Size = new System.Drawing.Size(120, 30);
            this.listBoxFrom.TabIndex = 11;
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(248, 53);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(100, 20);
            this.textBoxDistance.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Distance:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 338);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblConvertedDistance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxTo);
            this.Controls.Add(this.listBoxFrom);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Miles and Kilometers Covnersions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblConvertedDistance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxTo;
        private System.Windows.Forms.ListBox listBoxFrom;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.Label label1;
    }
}

