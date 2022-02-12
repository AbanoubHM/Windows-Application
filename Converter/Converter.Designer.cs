namespace Converter {
    partial class Converter {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ValueLbl = new System.Windows.Forms.Label();
            this.ResultLbl = new System.Windows.Forms.Label();
            this.ResultTxtBox = new System.Windows.Forms.TextBox();
            this.Conversion = new System.Windows.Forms.GroupBox();
            this.MitoM = new System.Windows.Forms.RadioButton();
            this.MtoMi = new System.Windows.Forms.RadioButton();
            this.MtoKM = new System.Windows.Forms.RadioButton();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.ValueNum = new System.Windows.Forms.NumericUpDown();
            this.Conversion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValueNum)).BeginInit();
            this.SuspendLayout();
            // 
            // ValueLbl
            // 
            this.ValueLbl.AutoSize = true;
            this.ValueLbl.Location = new System.Drawing.Point(32, 85);
            this.ValueLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ValueLbl.Name = "ValueLbl";
            this.ValueLbl.Size = new System.Drawing.Size(59, 24);
            this.ValueLbl.TabIndex = 0;
            this.ValueLbl.Text = "Value";
            // 
            // ResultLbl
            // 
            this.ResultLbl.AutoSize = true;
            this.ResultLbl.Location = new System.Drawing.Point(32, 203);
            this.ResultLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Size = new System.Drawing.Size(62, 24);
            this.ResultLbl.TabIndex = 0;
            this.ResultLbl.Text = "Result";
            // 
            // ResultTxtBox
            // 
            this.ResultTxtBox.Enabled = false;
            this.ResultTxtBox.Location = new System.Drawing.Point(143, 198);
            this.ResultTxtBox.Name = "ResultTxtBox";
            this.ResultTxtBox.Size = new System.Drawing.Size(157, 29);
            this.ResultTxtBox.TabIndex = 1;
            // 
            // Conversion
            // 
            this.Conversion.Controls.Add(this.MitoM);
            this.Conversion.Controls.Add(this.MtoMi);
            this.Conversion.Controls.Add(this.MtoKM);
            this.Conversion.Location = new System.Drawing.Point(551, 45);
            this.Conversion.Name = "Conversion";
            this.Conversion.Size = new System.Drawing.Size(296, 309);
            this.Conversion.TabIndex = 2;
            this.Conversion.TabStop = false;
            // 
            // MitoM
            // 
            this.MitoM.AutoSize = true;
            this.MitoM.Location = new System.Drawing.Point(49, 202);
            this.MitoM.Name = "MitoM";
            this.MitoM.Size = new System.Drawing.Size(144, 28);
            this.MitoM.TabIndex = 0;
            this.MitoM.TabStop = true;
            this.MitoM.Text = "Mile To Meter";
            this.MitoM.UseVisualStyleBackColor = true;
            this.MitoM.CheckedChanged += new System.EventHandler(this.ConverterChkbox);
            // 
            // MtoMi
            // 
            this.MtoMi.AutoSize = true;
            this.MtoMi.Location = new System.Drawing.Point(49, 136);
            this.MtoMi.Name = "MtoMi";
            this.MtoMi.Size = new System.Drawing.Size(144, 28);
            this.MtoMi.TabIndex = 0;
            this.MtoMi.TabStop = true;
            this.MtoMi.Text = "Meter To Mile";
            this.MtoMi.UseVisualStyleBackColor = true;
            this.MtoMi.CheckedChanged += new System.EventHandler(this.ConverterChkbox);
            // 
            // MtoKM
            // 
            this.MtoKM.AutoSize = true;
            this.MtoKM.Checked = true;
            this.MtoKM.Location = new System.Drawing.Point(49, 73);
            this.MtoKM.Name = "MtoKM";
            this.MtoKM.Size = new System.Drawing.Size(188, 28);
            this.MtoKM.TabIndex = 0;
            this.MtoKM.TabStop = true;
            this.MtoKM.Text = "Meter To Kilometer";
            this.MtoKM.UseVisualStyleBackColor = true;
            this.MtoKM.CheckedChanged += new System.EventHandler(this.ConverterChkbox);
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Location = new System.Drawing.Point(395, 419);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(101, 50);
            this.ConvertBtn.TabIndex = 3;
            this.ConvertBtn.Text = "Convert";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // ValueNum
            // 
            this.ValueNum.DecimalPlaces = 4;
            this.ValueNum.Location = new System.Drawing.Point(143, 85);
            this.ValueNum.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ValueNum.Name = "ValueNum";
            this.ValueNum.Size = new System.Drawing.Size(157, 29);
            this.ValueNum.TabIndex = 4;
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 512);
            this.Controls.Add(this.ValueNum);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.Conversion);
            this.Controls.Add(this.ResultTxtBox);
            this.Controls.Add(this.ResultLbl);
            this.Controls.Add(this.ValueLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Converter";
            this.Text = "Converter";
            this.Conversion.ResumeLayout(false);
            this.Conversion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValueNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ValueLbl;
        private System.Windows.Forms.Label ResultLbl;
        private System.Windows.Forms.TextBox ResultTxtBox;
        private System.Windows.Forms.GroupBox Conversion;
        private System.Windows.Forms.RadioButton MitoM;
        private System.Windows.Forms.RadioButton MtoMi;
        private System.Windows.Forms.RadioButton MtoKM;
        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.NumericUpDown ValueNum;
    }
}