namespace lms_system
{
    partial class EditStudents
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Gselect = new Guna.UI.WinForms.GunaComboBox();
            this.removebtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Editbtn = new System.Windows.Forms.Button();
            this.stText1 = new Guna.UI.WinForms.GunaTextBox();
            this.stText2 = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(508, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(508, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(508, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gender";
            // 
            // Gselect
            // 
            this.Gselect.BackColor = System.Drawing.Color.Transparent;
            this.Gselect.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.Gselect.BorderColor = System.Drawing.Color.Silver;
            this.Gselect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Gselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gselect.FocusedColor = System.Drawing.Color.Empty;
            this.Gselect.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Gselect.ForeColor = System.Drawing.Color.White;
            this.Gselect.FormattingEnabled = true;
            this.Gselect.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gselect.Location = new System.Drawing.Point(651, 318);
            this.Gselect.Name = "Gselect";
            this.Gselect.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Gselect.OnHoverItemForeColor = System.Drawing.Color.White;
            this.Gselect.Radius = 6;
            this.Gselect.Size = new System.Drawing.Size(317, 31);
            this.Gselect.TabIndex = 2;
            // 
            // removebtn
            // 
            this.removebtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.removebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removebtn.Location = new System.Drawing.Point(691, 715);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(97, 48);
            this.removebtn.TabIndex = 3;
            this.removebtn.Text = "Remove";
            this.removebtn.UseVisualStyleBackColor = false;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(22, 715);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::lms_system.Properties.Resources.Custom_Icon_Design_Flatastic_7_Student_id_512;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(41, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 492);
            this.panel1.TabIndex = 7;
            // 
            // Editbtn
            // 
            this.Editbtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Editbtn.Location = new System.Drawing.Point(824, 715);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(165, 49);
            this.Editbtn.TabIndex = 8;
            this.Editbtn.Text = "Edit and Save";
            this.Editbtn.UseVisualStyleBackColor = false;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // stText1
            // 
            this.stText1.BackColor = System.Drawing.Color.Transparent;
            this.stText1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.stText1.BorderColor = System.Drawing.Color.White;
            this.stText1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stText1.FocusedBaseColor = System.Drawing.Color.White;
            this.stText1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.stText1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.stText1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stText1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stText1.Location = new System.Drawing.Point(651, 73);
            this.stText1.Name = "stText1";
            this.stText1.PasswordChar = '\0';
            this.stText1.Radius = 8;
            this.stText1.SelectedText = "";
            this.stText1.Size = new System.Drawing.Size(317, 46);
            this.stText1.TabIndex = 9;
            // 
            // stText2
            // 
            this.stText2.BackColor = System.Drawing.Color.Transparent;
            this.stText2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.stText2.BorderColor = System.Drawing.Color.White;
            this.stText2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stText2.FocusedBaseColor = System.Drawing.Color.White;
            this.stText2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.stText2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.stText2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stText2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stText2.Location = new System.Drawing.Point(651, 174);
            this.stText2.Name = "stText2";
            this.stText2.PasswordChar = '\0';
            this.stText2.Radius = 8;
            this.stText2.SelectedText = "";
            this.stText2.Size = new System.Drawing.Size(317, 46);
            this.stText2.TabIndex = 10;
            // 
            // EditStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1029, 791);
            this.Controls.Add(this.stText2);
            this.Controls.Add(this.stText1);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.Gselect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditStudents";
            this.Load += new System.EventHandler(this.EditStudents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaComboBox Gselect;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Editbtn;
        private Guna.UI.WinForms.GunaTextBox stText1;
        private Guna.UI.WinForms.GunaTextBox stText2;
    }
}