
namespace TEST
{
    partial class info
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labcity = new System.Windows.Forms.Label();
            this.labgender = new System.Windows.Forms.Label();
            this.labage = new System.Windows.Forms.Label();
            this.labname = new System.Windows.Forms.Label();
            this.labip = new System.Windows.Forms.Label();
            this.labtell = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.cbcity = new System.Windows.Forms.ComboBox();
            this.labshow = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labcity
            // 
            this.labcity.AutoSize = true;
            this.labcity.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labcity.Location = new System.Drawing.Point(451, 76);
            this.labcity.Name = "labcity";
            this.labcity.Size = new System.Drawing.Size(56, 32);
            this.labcity.TabIndex = 0;
            this.labcity.Text = "City";
            // 
            // labgender
            // 
            this.labgender.AutoSize = true;
            this.labgender.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labgender.Location = new System.Drawing.Point(155, 76);
            this.labgender.Name = "labgender";
            this.labgender.Size = new System.Drawing.Size(92, 32);
            this.labgender.TabIndex = 1;
            this.labgender.Text = "Gender";
            // 
            // labage
            // 
            this.labage.AutoSize = true;
            this.labage.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labage.Location = new System.Drawing.Point(315, 76);
            this.labage.Name = "labage";
            this.labage.Size = new System.Drawing.Size(56, 32);
            this.labage.TabIndex = 2;
            this.labage.Text = "Age";
            this.labage.Click += new System.EventHandler(this.label3_Click);
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labname.Location = new System.Drawing.Point(12, 76);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(80, 32);
            this.labname.TabIndex = 3;
            this.labname.Text = "Name";
            // 
            // labip
            // 
            this.labip.AutoSize = true;
            this.labip.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labip.Location = new System.Drawing.Point(130, 185);
            this.labip.Name = "labip";
            this.labip.Size = new System.Drawing.Size(156, 32);
            this.labip.TabIndex = 4;
            this.labip.Text = "Info Personal";
            // 
            // labtell
            // 
            this.labtell.AutoSize = true;
            this.labtell.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labtell.Location = new System.Drawing.Point(579, 76);
            this.labtell.Name = "labtell";
            this.labtell.Size = new System.Drawing.Size(81, 32);
            this.labtell.TabIndex = 5;
            this.labtell.Text = "Phone";
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtage.Location = new System.Drawing.Point(284, 123);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(113, 40);
            this.txtage.TabIndex = 7;
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtphone.Location = new System.Drawing.Point(557, 123);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(113, 40);
            this.txtphone.TabIndex = 8;
            // 
            // cbgender
            // 
            this.cbgender.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbgender.Location = new System.Drawing.Point(144, 123);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(121, 40);
            this.cbgender.TabIndex = 9;
            // 
            // cbcity
            // 
            this.cbcity.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cbcity.FormattingEnabled = true;
            this.cbcity.Items.AddRange(new object[] {
            "Erbil",
            "Sulimany",
            "Duhok",
            "Kirkuk",
            "Koya",
            "Taqtaq",
            "Ranya",
            "Hallabja",
            "Chamchamal",
            "Bardarash",
            "Harir",
            "Basrma",
            "Soran",
            "Rawandz"});
            this.cbcity.Location = new System.Drawing.Point(420, 123);
            this.cbcity.Name = "cbcity";
            this.cbcity.Size = new System.Drawing.Size(121, 40);
            this.cbcity.TabIndex = 10;
            // 
            // labshow
            // 
            this.labshow.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labshow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labshow.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labshow.Location = new System.Drawing.Point(12, 232);
            this.labshow.Name = "labshow";
            this.labshow.Size = new System.Drawing.Size(385, 192);
            this.labshow.TabIndex = 12;
            this.labshow.Text = "               ";
            this.labshow.Click += new System.EventHandler(this.labshow_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Orange;
            this.btnsave.Font = new System.Drawing.Font("Shonar Bangla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsave.Location = new System.Drawing.Point(507, 282);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(113, 40);
            this.btnsave.TabIndex = 13;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtname.Location = new System.Drawing.Point(12, 123);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(113, 40);
            this.txtname.TabIndex = 14;
            // 
            // info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 433);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.labshow);
            this.Controls.Add(this.cbcity);
            this.Controls.Add(this.cbgender);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.labtell);
            this.Controls.Add(this.labip);
            this.Controls.Add(this.labname);
            this.Controls.Add(this.labage);
            this.Controls.Add(this.labgender);
            this.Controls.Add(this.labcity);
            this.Name = "info";
            this.Text = "Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labcity;
        private System.Windows.Forms.Label labgender;
        private System.Windows.Forms.Label labage;
        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.Label labip;
        private System.Windows.Forms.Label labtell;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.ComboBox cbcity;
        private System.Windows.Forms.Label labshow;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtname;
    }
}

