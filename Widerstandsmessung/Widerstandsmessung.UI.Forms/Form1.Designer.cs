namespace Widerstandsmessung.UI.Forms
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
            this.listBoxSOLL = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelVW = new System.Windows.Forms.Label();
            this.labelUW = new System.Windows.Forms.Label();
            this.labelUV = new System.Windows.Forms.Label();
            this.labelMittelwert = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonISTBerechnen = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.comboBoxSoftware = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBoxSOLL
            // 
            this.listBoxSOLL.FormattingEnabled = true;
            this.listBoxSOLL.Location = new System.Drawing.Point(12, 12);
            this.listBoxSOLL.Name = "listBoxSOLL";
            this.listBoxSOLL.Size = new System.Drawing.Size(254, 199);
            this.listBoxSOLL.TabIndex = 0;
            this.listBoxSOLL.SelectedIndexChanged += new System.EventHandler(this.ListBoxSOLL_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "UV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "UW:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "VW:";
            // 
            // labelVW
            // 
            this.labelVW.AutoSize = true;
            this.labelVW.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVW.Location = new System.Drawing.Point(99, 294);
            this.labelVW.Name = "labelVW";
            this.labelVW.Size = new System.Drawing.Size(42, 33);
            this.labelVW.TabIndex = 6;
            this.labelVW.Text = "---";
            // 
            // labelUW
            // 
            this.labelUW.AutoSize = true;
            this.labelUW.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUW.Location = new System.Drawing.Point(99, 261);
            this.labelUW.Name = "labelUW";
            this.labelUW.Size = new System.Drawing.Size(42, 33);
            this.labelUW.TabIndex = 5;
            this.labelUW.Text = "---";
            // 
            // labelUV
            // 
            this.labelUV.AutoSize = true;
            this.labelUV.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUV.Location = new System.Drawing.Point(99, 228);
            this.labelUV.Name = "labelUV";
            this.labelUV.Size = new System.Drawing.Size(42, 33);
            this.labelUV.TabIndex = 4;
            this.labelUV.Text = "---";
            // 
            // labelMittelwert
            // 
            this.labelMittelwert.AutoSize = true;
            this.labelMittelwert.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMittelwert.Location = new System.Drawing.Point(21, 373);
            this.labelMittelwert.Name = "labelMittelwert";
            this.labelMittelwert.Size = new System.Drawing.Size(42, 33);
            this.labelMittelwert.TabIndex = 8;
            this.labelMittelwert.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mittelwert:";
            // 
            // buttonISTBerechnen
            // 
            this.buttonISTBerechnen.Location = new System.Drawing.Point(27, 415);
            this.buttonISTBerechnen.Name = "buttonISTBerechnen";
            this.buttonISTBerechnen.Size = new System.Drawing.Size(218, 23);
            this.buttonISTBerechnen.TabIndex = 9;
            this.buttonISTBerechnen.Text = "Ist-Werte berechnen";
            this.buttonISTBerechnen.UseVisualStyleBackColor = true;
            this.buttonISTBerechnen.Click += new System.EventHandler(this.ButtonISTBerechnen_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLog.Location = new System.Drawing.Point(285, 12);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(274, 199);
            this.textBoxLog.TabIndex = 10;
            // 
            // comboBoxSoftware
            // 
            this.comboBoxSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSoftware.FormattingEnabled = true;
            this.comboBoxSoftware.Location = new System.Drawing.Point(285, 240);
            this.comboBoxSoftware.Name = "comboBoxSoftware";
            this.comboBoxSoftware.Size = new System.Drawing.Size(274, 21);
            this.comboBoxSoftware.TabIndex = 11;
            this.comboBoxSoftware.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSoftware_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.comboBoxSoftware);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.buttonISTBerechnen);
            this.Controls.Add(this.labelMittelwert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelVW);
            this.Controls.Add(this.labelUW);
            this.Controls.Add(this.labelUV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSOLL);
            this.Name = "Form1";
            this.Text = "Widerstand(sberechnung) ist zwecklos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSOLL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelVW;
        private System.Windows.Forms.Label labelUW;
        private System.Windows.Forms.Label labelUV;
        private System.Windows.Forms.Label labelMittelwert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonISTBerechnen;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.ComboBox comboBoxSoftware;
    }
}

