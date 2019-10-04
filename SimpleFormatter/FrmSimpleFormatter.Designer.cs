namespace SimpleFormatter
{
    partial class FrmSimpleFormatter
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
            this.rtxtSimpleText = new System.Windows.Forms.RichTextBox();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.btnAlignLeft = new System.Windows.Forms.Button();
            this.btnAlignCenter = new System.Windows.Forms.Button();
            this.btnAlignRight = new System.Windows.Forms.Button();
            this.cbbFont = new System.Windows.Forms.ComboBox();
            this.nudFontSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxtSimpleText
            // 
            this.rtxtSimpleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtSimpleText.Location = new System.Drawing.Point(12, 12);
            this.rtxtSimpleText.Name = "rtxtSimpleText";
            this.rtxtSimpleText.Size = new System.Drawing.Size(336, 309);
            this.rtxtSimpleText.TabIndex = 0;
            this.rtxtSimpleText.Text = "";
            this.rtxtSimpleText.SelectionChanged += new System.EventHandler(this.rtxtSimpleText_SelectionChanged);
            // 
            // btnBold
            // 
            this.btnBold.AutoSize = true;
            this.btnBold.Location = new System.Drawing.Point(354, 46);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(30, 30);
            this.btnBold.TabIndex = 3;
            this.btnBold.Text = "B";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.AutoSize = true;
            this.btnItalic.Location = new System.Drawing.Point(390, 46);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(30, 30);
            this.btnItalic.TabIndex = 3;
            this.btnItalic.Text = "I";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.AutoSize = true;
            this.btnUnderline.Location = new System.Drawing.Point(426, 46);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(31, 30);
            this.btnUnderline.TabIndex = 3;
            this.btnUnderline.Text = "U";
            this.btnUnderline.UseVisualStyleBackColor = true;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // btnAlignLeft
            // 
            this.btnAlignLeft.AutoSize = true;
            this.btnAlignLeft.Location = new System.Drawing.Point(354, 82);
            this.btnAlignLeft.Name = "btnAlignLeft";
            this.btnAlignLeft.Size = new System.Drawing.Size(67, 30);
            this.btnAlignLeft.TabIndex = 3;
            this.btnAlignLeft.Text = "Left";
            this.btnAlignLeft.UseVisualStyleBackColor = true;
            this.btnAlignLeft.Click += new System.EventHandler(this.btnAlignLeft_Click);
            // 
            // btnAlignCenter
            // 
            this.btnAlignCenter.AutoSize = true;
            this.btnAlignCenter.Location = new System.Drawing.Point(426, 82);
            this.btnAlignCenter.Name = "btnAlignCenter";
            this.btnAlignCenter.Size = new System.Drawing.Size(67, 30);
            this.btnAlignCenter.TabIndex = 3;
            this.btnAlignCenter.Text = "Center";
            this.btnAlignCenter.UseVisualStyleBackColor = true;
            this.btnAlignCenter.Click += new System.EventHandler(this.btnAlignCenter_Click);
            // 
            // btnAlignRight
            // 
            this.btnAlignRight.AutoSize = true;
            this.btnAlignRight.Location = new System.Drawing.Point(499, 82);
            this.btnAlignRight.Name = "btnAlignRight";
            this.btnAlignRight.Size = new System.Drawing.Size(67, 30);
            this.btnAlignRight.TabIndex = 3;
            this.btnAlignRight.Text = "Right";
            this.btnAlignRight.UseVisualStyleBackColor = true;
            this.btnAlignRight.Click += new System.EventHandler(this.btnAlignRight_Click);
            // 
            // cbbFont
            // 
            this.cbbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFont.FormattingEnabled = true;
            this.cbbFont.Location = new System.Drawing.Point(354, 12);
            this.cbbFont.Name = "cbbFont";
            this.cbbFont.Size = new System.Drawing.Size(139, 28);
            this.cbbFont.TabIndex = 4;
            // 
            // nudFontSize
            // 
            this.nudFontSize.Location = new System.Drawing.Point(499, 14);
            this.nudFontSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(67, 26);
            this.nudFontSize.TabIndex = 5;
            this.nudFontSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // FrmSimpleFormatter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 333);
            this.Controls.Add(this.nudFontSize);
            this.Controls.Add(this.cbbFont);
            this.Controls.Add(this.btnUnderline);
            this.Controls.Add(this.btnItalic);
            this.Controls.Add(this.btnAlignRight);
            this.Controls.Add(this.btnAlignCenter);
            this.Controls.Add(this.btnAlignLeft);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.rtxtSimpleText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSimpleFormatter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Định dạng đơn giản";
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtSimpleText;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.Button btnAlignLeft;
        private System.Windows.Forms.Button btnAlignCenter;
        private System.Windows.Forms.Button btnAlignRight;
        private System.Windows.Forms.ComboBox cbbFont;
        private System.Windows.Forms.NumericUpDown nudFontSize;
    }
}

