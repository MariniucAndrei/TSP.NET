namespace MyPhotosGUI
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numeGrup = new System.Windows.Forms.TextBox();
            this.IdMedia_Grup = new System.Windows.Forms.TextBox();
            this.btnCreate_Grup = new System.Windows.Forms.Button();
            this.btnRead_Grup = new System.Windows.Forms.Button();
            this.btnSearch_Grup = new System.Windows.Forms.Button();
            this.btnDelete_Grup = new System.Windows.Forms.Button();
            this.btnSave_Grup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "IdMedia";
            // 
            // numeGrup
            // 
            this.numeGrup.Location = new System.Drawing.Point(27, 67);
            this.numeGrup.Name = "numeGrup";
            this.numeGrup.Size = new System.Drawing.Size(203, 22);
            this.numeGrup.TabIndex = 2;
            // 
            // IdMedia_Grup
            // 
            this.IdMedia_Grup.Location = new System.Drawing.Point(27, 161);
            this.IdMedia_Grup.Name = "IdMedia_Grup";
            this.IdMedia_Grup.Size = new System.Drawing.Size(203, 22);
            this.IdMedia_Grup.TabIndex = 3;
            // 
            // btnCreate_Grup
            // 
            this.btnCreate_Grup.Location = new System.Drawing.Point(12, 254);
            this.btnCreate_Grup.Name = "btnCreate_Grup";
            this.btnCreate_Grup.Size = new System.Drawing.Size(90, 23);
            this.btnCreate_Grup.TabIndex = 4;
            this.btnCreate_Grup.Text = "Create";
            this.btnCreate_Grup.UseVisualStyleBackColor = true;
            this.btnCreate_Grup.Click += new System.EventHandler(this.btnCreate_Grup_Click);
            // 
            // btnRead_Grup
            // 
            this.btnRead_Grup.Location = new System.Drawing.Point(125, 254);
            this.btnRead_Grup.Name = "btnRead_Grup";
            this.btnRead_Grup.Size = new System.Drawing.Size(86, 23);
            this.btnRead_Grup.TabIndex = 5;
            this.btnRead_Grup.Text = "Read";
            this.btnRead_Grup.UseVisualStyleBackColor = true;
            this.btnRead_Grup.Click += new System.EventHandler(this.btnRead_Grup_Click);
            // 
            // btnSearch_Grup
            // 
            this.btnSearch_Grup.Location = new System.Drawing.Point(241, 254);
            this.btnSearch_Grup.Name = "btnSearch_Grup";
            this.btnSearch_Grup.Size = new System.Drawing.Size(80, 23);
            this.btnSearch_Grup.TabIndex = 6;
            this.btnSearch_Grup.Text = "Search";
            this.btnSearch_Grup.UseVisualStyleBackColor = true;
            this.btnSearch_Grup.Click += new System.EventHandler(this.btnSearch_Grup_Click);
            // 
            // btnDelete_Grup
            // 
            this.btnDelete_Grup.Location = new System.Drawing.Point(345, 254);
            this.btnDelete_Grup.Name = "btnDelete_Grup";
            this.btnDelete_Grup.Size = new System.Drawing.Size(87, 23);
            this.btnDelete_Grup.TabIndex = 7;
            this.btnDelete_Grup.Text = "Delete";
            this.btnDelete_Grup.UseVisualStyleBackColor = true;
            this.btnDelete_Grup.Click += new System.EventHandler(this.btnDelete_Grup_Click);
            // 
            // btnSave_Grup
            // 
            this.btnSave_Grup.Location = new System.Drawing.Point(12, 287);
            this.btnSave_Grup.Name = "btnSave_Grup";
            this.btnSave_Grup.Size = new System.Drawing.Size(420, 23);
            this.btnSave_Grup.TabIndex = 8;
            this.btnSave_Grup.Text = "Save";
            this.btnSave_Grup.UseVisualStyleBackColor = true;
            this.btnSave_Grup.Click += new System.EventHandler(this.btnSave_Grup_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 322);
            this.Controls.Add(this.btnSave_Grup);
            this.Controls.Add(this.btnDelete_Grup);
            this.Controls.Add(this.btnSearch_Grup);
            this.Controls.Add(this.btnRead_Grup);
            this.Controls.Add(this.btnCreate_Grup);
            this.Controls.Add(this.IdMedia_Grup);
            this.Controls.Add(this.numeGrup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "PeopleGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numeGrup;
        private System.Windows.Forms.TextBox IdMedia_Grup;
        private System.Windows.Forms.Button btnCreate_Grup;
        private System.Windows.Forms.Button btnRead_Grup;
        private System.Windows.Forms.Button btnSearch_Grup;
        private System.Windows.Forms.Button btnDelete_Grup;
        private System.Windows.Forms.Button btnSave_Grup;
    }
}