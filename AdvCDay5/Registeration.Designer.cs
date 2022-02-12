namespace AdvCDay5 {
    partial class Registeration {
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
            System.Windows.Forms.Label EmailLbl;
            System.Windows.Forms.Label NameLbl;
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.MaleRadio = new System.Windows.Forms.RadioButton();
            this.FemaleRadio = new System.Windows.Forms.RadioButton();
            this.HoppiesLbl = new System.Windows.Forms.Label();
            this.TennisCheckBox = new System.Windows.Forms.CheckBox();
            this.FootballChkBox = new System.Windows.Forms.CheckBox();
            this.SwimChkBox = new System.Windows.Forms.CheckBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.NameErrorLbl = new System.Windows.Forms.Label();
            this.EmailErrorLbl = new System.Windows.Forms.Label();
            this.HoppiesErrorLbl = new System.Windows.Forms.Label();
            this.DoneTxt = new System.Windows.Forms.Label();
            EmailLbl = new System.Windows.Forms.Label();
            NameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            EmailLbl.Location = new System.Drawing.Point(46, 179);
            EmailLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new System.Drawing.Size(62, 24);
            EmailLbl.TabIndex = 1;
            EmailLbl.Text = "Email:";
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            NameLbl.Location = new System.Drawing.Point(46, 98);
            NameLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new System.Drawing.Size(66, 24);
            NameLbl.TabIndex = 1;
            NameLbl.Text = "Name:";
            // 
            // NameTxt
            // 
            this.NameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.Location = new System.Drawing.Point(192, 93);
            this.NameTxt.Margin = new System.Windows.Forms.Padding(6);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(224, 29);
            this.NameTxt.TabIndex = 0;
            this.NameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.NameTxt_Validating);
            this.NameTxt.Validated += new System.EventHandler(this.NameTxt_Validated);
            // 
            // EmailTxt
            // 
            this.EmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxt.Location = new System.Drawing.Point(192, 174);
            this.EmailTxt.Margin = new System.Windows.Forms.Padding(6);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(224, 29);
            this.EmailTxt.TabIndex = 0;
            this.EmailTxt.Validating += new System.ComponentModel.CancelEventHandler(this.EmailTxt_Validating);
            this.EmailTxt.Validated += new System.EventHandler(this.EmailTxt_Validated);
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLbl.Location = new System.Drawing.Point(46, 281);
            this.GenderLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(79, 24);
            this.GenderLbl.TabIndex = 1;
            this.GenderLbl.Text = "Gender:";
            // 
            // MaleRadio
            // 
            this.MaleRadio.AutoSize = true;
            this.MaleRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleRadio.Location = new System.Drawing.Point(192, 277);
            this.MaleRadio.Margin = new System.Windows.Forms.Padding(6);
            this.MaleRadio.Name = "MaleRadio";
            this.MaleRadio.Size = new System.Drawing.Size(69, 28);
            this.MaleRadio.TabIndex = 2;
            this.MaleRadio.TabStop = true;
            this.MaleRadio.Text = "Male";
            this.MaleRadio.UseVisualStyleBackColor = true;
            this.MaleRadio.CheckedChanged += new System.EventHandler(this.MaleRadio_CheckedChanged);
            // 
            // FemaleRadio
            // 
            this.FemaleRadio.AutoSize = true;
            this.FemaleRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleRadio.Location = new System.Drawing.Point(330, 277);
            this.FemaleRadio.Margin = new System.Windows.Forms.Padding(6);
            this.FemaleRadio.Name = "FemaleRadio";
            this.FemaleRadio.Size = new System.Drawing.Size(92, 28);
            this.FemaleRadio.TabIndex = 2;
            this.FemaleRadio.TabStop = true;
            this.FemaleRadio.Text = "Female";
            this.FemaleRadio.UseVisualStyleBackColor = true;
            this.FemaleRadio.CheckedChanged += new System.EventHandler(this.MaleRadio_CheckedChanged);
            // 
            // HoppiesLbl
            // 
            this.HoppiesLbl.AutoSize = true;
            this.HoppiesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoppiesLbl.Location = new System.Drawing.Point(46, 387);
            this.HoppiesLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HoppiesLbl.Name = "HoppiesLbl";
            this.HoppiesLbl.Size = new System.Drawing.Size(86, 24);
            this.HoppiesLbl.TabIndex = 1;
            this.HoppiesLbl.Text = "Hoppies:";
            // 
            // TennisCheckBox
            // 
            this.TennisCheckBox.AutoSize = true;
            this.TennisCheckBox.Location = new System.Drawing.Point(192, 387);
            this.TennisCheckBox.Name = "TennisCheckBox";
            this.TennisCheckBox.Size = new System.Drawing.Size(87, 28);
            this.TennisCheckBox.TabIndex = 3;
            this.TennisCheckBox.Text = "Tennis";
            this.TennisCheckBox.UseVisualStyleBackColor = true;
            this.TennisCheckBox.CheckedChanged += new System.EventHandler(this.FootballChkBox_CheckedChanged);
            this.TennisCheckBox.CheckStateChanged += new System.EventHandler(this.ChkBox_Validating);
            // 
            // FootballChkBox
            // 
            this.FootballChkBox.AutoSize = true;
            this.FootballChkBox.Location = new System.Drawing.Point(330, 386);
            this.FootballChkBox.Name = "FootballChkBox";
            this.FootballChkBox.Size = new System.Drawing.Size(96, 28);
            this.FootballChkBox.TabIndex = 3;
            this.FootballChkBox.Text = "Football";
            this.FootballChkBox.UseVisualStyleBackColor = true;
            this.FootballChkBox.CheckedChanged += new System.EventHandler(this.FootballChkBox_CheckedChanged);
            this.FootballChkBox.CheckStateChanged += new System.EventHandler(this.ChkBox_Validating);
            // 
            // SwimChkBox
            // 
            this.SwimChkBox.AutoSize = true;
            this.SwimChkBox.Location = new System.Drawing.Point(468, 383);
            this.SwimChkBox.Name = "SwimChkBox";
            this.SwimChkBox.Size = new System.Drawing.Size(117, 28);
            this.SwimChkBox.TabIndex = 3;
            this.SwimChkBox.Text = "Swimming";
            this.SwimChkBox.UseVisualStyleBackColor = true;
            this.SwimChkBox.CheckedChanged += new System.EventHandler(this.FootballChkBox_CheckedChanged);
            this.SwimChkBox.CheckStateChanged += new System.EventHandler(this.ChkBox_Validating);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.AutoSize = true;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Location = new System.Drawing.Point(410, 503);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(118, 47);
            this.RegisterBtn.TabIndex = 4;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // NameErrorLbl
            // 
            this.NameErrorLbl.AutoSize = true;
            this.NameErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.NameErrorLbl.Location = new System.Drawing.Point(454, 95);
            this.NameErrorLbl.Name = "NameErrorLbl";
            this.NameErrorLbl.Size = new System.Drawing.Size(0, 24);
            this.NameErrorLbl.TabIndex = 5;
            // 
            // EmailErrorLbl
            // 
            this.EmailErrorLbl.AutoSize = true;
            this.EmailErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.EmailErrorLbl.Location = new System.Drawing.Point(454, 179);
            this.EmailErrorLbl.Name = "EmailErrorLbl";
            this.EmailErrorLbl.Size = new System.Drawing.Size(0, 24);
            this.EmailErrorLbl.TabIndex = 5;
            // 
            // HoppiesErrorLbl
            // 
            this.HoppiesErrorLbl.AutoSize = true;
            this.HoppiesErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.HoppiesErrorLbl.Location = new System.Drawing.Point(631, 384);
            this.HoppiesErrorLbl.Name = "HoppiesErrorLbl";
            this.HoppiesErrorLbl.Size = new System.Drawing.Size(0, 24);
            this.HoppiesErrorLbl.TabIndex = 5;
            // 
            // DoneTxt
            // 
            this.DoneTxt.AutoSize = true;
            this.DoneTxt.ForeColor = System.Drawing.Color.Green;
            this.DoneTxt.Location = new System.Drawing.Point(360, 575);
            this.DoneTxt.Name = "DoneTxt";
            this.DoneTxt.Size = new System.Drawing.Size(0, 24);
            this.DoneTxt.TabIndex = 6;
            // 
            // Registeration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 608);
            this.Controls.Add(this.DoneTxt);
            this.Controls.Add(this.HoppiesErrorLbl);
            this.Controls.Add(this.EmailErrorLbl);
            this.Controls.Add(this.NameErrorLbl);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.SwimChkBox);
            this.Controls.Add(this.FootballChkBox);
            this.Controls.Add(this.TennisCheckBox);
            this.Controls.Add(this.FemaleRadio);
            this.Controls.Add(this.MaleRadio);
            this.Controls.Add(this.HoppiesLbl);
            this.Controls.Add(this.GenderLbl);
            this.Controls.Add(EmailLbl);
            this.Controls.Add(NameLbl);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.NameTxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Registeration";
            this.Text = "Registeration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.RadioButton MaleRadio;
        private System.Windows.Forms.RadioButton FemaleRadio;
        private System.Windows.Forms.Label HoppiesLbl;
        private System.Windows.Forms.CheckBox TennisCheckBox;
        private System.Windows.Forms.CheckBox FootballChkBox;
        private System.Windows.Forms.CheckBox SwimChkBox;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label NameErrorLbl;
        private System.Windows.Forms.Label EmailErrorLbl;
        private System.Windows.Forms.Label HoppiesErrorLbl;
        private System.Windows.Forms.Label DoneTxt;
    }
}

