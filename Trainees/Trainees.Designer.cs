namespace Trainees {
    partial class Trainees {
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
            this.TraineeCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.LabCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabComboBox = new System.Windows.Forms.ComboBox();
            this.MovetoLab = new System.Windows.Forms.Button();
            this.MoveAlltoLab = new System.Windows.Forms.Button();
            this.MovetoTrainee = new System.Windows.Forms.Button();
            this.MoveAlltoTrainee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TraineeCheckListBox
            // 
            this.TraineeCheckListBox.CheckOnClick = true;
            this.TraineeCheckListBox.FormattingEnabled = true;
            this.TraineeCheckListBox.Location = new System.Drawing.Point(32, 109);
            this.TraineeCheckListBox.Name = "TraineeCheckListBox";
            this.TraineeCheckListBox.Size = new System.Drawing.Size(250, 268);
            this.TraineeCheckListBox.TabIndex = 0;
            // 
            // LabCheckListBox
            // 
            this.LabCheckListBox.CheckOnClick = true;
            this.LabCheckListBox.FormattingEnabled = true;
            this.LabCheckListBox.Location = new System.Drawing.Point(566, 109);
            this.LabCheckListBox.Name = "LabCheckListBox";
            this.LabCheckListBox.Size = new System.Drawing.Size(250, 268);
            this.LabCheckListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trainees";
            // 
            // LabComboBox
            // 
            this.LabComboBox.FormattingEnabled = true;
            this.LabComboBox.Location = new System.Drawing.Point(608, 61);
            this.LabComboBox.Name = "LabComboBox";
            this.LabComboBox.Size = new System.Drawing.Size(148, 32);
            this.LabComboBox.TabIndex = 3;
            this.LabComboBox.SelectedIndexChanged += new System.EventHandler(this.LabComboBox_SelectedIndexChanged);
            // 
            // MovetoLab
            // 
            this.MovetoLab.Location = new System.Drawing.Point(379, 159);
            this.MovetoLab.Name = "MovetoLab";
            this.MovetoLab.Size = new System.Drawing.Size(85, 33);
            this.MovetoLab.TabIndex = 4;
            this.MovetoLab.Text = ">";
            this.MovetoLab.UseVisualStyleBackColor = true;
            this.MovetoLab.Click += new System.EventHandler(this.MovetoLab_Click);
            // 
            // MoveAlltoLab
            // 
            this.MoveAlltoLab.Location = new System.Drawing.Point(379, 198);
            this.MoveAlltoLab.Name = "MoveAlltoLab";
            this.MoveAlltoLab.Size = new System.Drawing.Size(85, 33);
            this.MoveAlltoLab.TabIndex = 4;
            this.MoveAlltoLab.Text = ">>";
            this.MoveAlltoLab.UseVisualStyleBackColor = true;
            this.MoveAlltoLab.Click += new System.EventHandler(this.MoveAlltoLab_Click);
            // 
            // MovetoTrainee
            // 
            this.MovetoTrainee.Location = new System.Drawing.Point(379, 237);
            this.MovetoTrainee.Name = "MovetoTrainee";
            this.MovetoTrainee.Size = new System.Drawing.Size(85, 33);
            this.MovetoTrainee.TabIndex = 4;
            this.MovetoTrainee.Text = "<";
            this.MovetoTrainee.UseVisualStyleBackColor = true;
            this.MovetoTrainee.Click += new System.EventHandler(this.MovetoTrainee_Click);
            // 
            // MoveAlltoTrainee
            // 
            this.MoveAlltoTrainee.Location = new System.Drawing.Point(379, 276);
            this.MoveAlltoTrainee.Name = "MoveAlltoTrainee";
            this.MoveAlltoTrainee.Size = new System.Drawing.Size(85, 33);
            this.MoveAlltoTrainee.TabIndex = 4;
            this.MoveAlltoTrainee.Text = "<<";
            this.MoveAlltoTrainee.UseVisualStyleBackColor = true;
            this.MoveAlltoTrainee.Click += new System.EventHandler(this.MoveAlltoTrainee_Click);
            // 
            // Trainees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 484);
            this.Controls.Add(this.MoveAlltoTrainee);
            this.Controls.Add(this.MovetoTrainee);
            this.Controls.Add(this.MoveAlltoLab);
            this.Controls.Add(this.MovetoLab);
            this.Controls.Add(this.LabComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabCheckListBox);
            this.Controls.Add(this.TraineeCheckListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Trainees";
            this.Text = "Trainees";
            this.Load += new System.EventHandler(this.Trainees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox TraineeCheckListBox;
        private System.Windows.Forms.CheckedListBox LabCheckListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LabComboBox;
        private System.Windows.Forms.Button MovetoLab;
        private System.Windows.Forms.Button MoveAlltoLab;
        private System.Windows.Forms.Button MovetoTrainee;
        private System.Windows.Forms.Button MoveAlltoTrainee;
    }
}