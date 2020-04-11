namespace Client
{
    partial class Form4
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
            this.numeZona = new System.Windows.Forms.TextBox();
            this.IdMedia_Zone = new System.Windows.Forms.TextBox();
            this.btnCreate_Zone = new System.Windows.Forms.Button();
            this.btnRead_Zone = new System.Windows.Forms.Button();
            this.btnSearch_Zone = new System.Windows.Forms.Button();
            this.btnDelete_Zone = new System.Windows.Forms.Button();
            this.btnSave_Zones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "IdMedia";
            // 
            // numeZona
            // 
            this.numeZona.Location = new System.Drawing.Point(23, 56);
            this.numeZona.Name = "numeZona";
            this.numeZona.Size = new System.Drawing.Size(213, 22);
            this.numeZona.TabIndex = 2;
            // 
            // IdMedia_Zone
            // 
            this.IdMedia_Zone.Location = new System.Drawing.Point(23, 154);
            this.IdMedia_Zone.Name = "IdMedia_Zone";
            this.IdMedia_Zone.Size = new System.Drawing.Size(213, 22);
            this.IdMedia_Zone.TabIndex = 3;
            // 
            // btnCreate_Zone
            // 
            this.btnCreate_Zone.Location = new System.Drawing.Point(12, 239);
            this.btnCreate_Zone.Name = "btnCreate_Zone";
            this.btnCreate_Zone.Size = new System.Drawing.Size(83, 23);
            this.btnCreate_Zone.TabIndex = 4;
            this.btnCreate_Zone.Text = "Create";
            this.btnCreate_Zone.UseVisualStyleBackColor = true;
            this.btnCreate_Zone.Click += new System.EventHandler(this.btnCreate_Zone_Click);
            // 
            // btnRead_Zone
            // 
            this.btnRead_Zone.Location = new System.Drawing.Point(117, 239);
            this.btnRead_Zone.Name = "btnRead_Zone";
            this.btnRead_Zone.Size = new System.Drawing.Size(82, 23);
            this.btnRead_Zone.TabIndex = 5;
            this.btnRead_Zone.Text = "Read";
            this.btnRead_Zone.UseVisualStyleBackColor = true;
            this.btnRead_Zone.Click += new System.EventHandler(this.btnRead_Zone_Click);
            // 
            // btnSearch_Zone
            // 
            this.btnSearch_Zone.Location = new System.Drawing.Point(220, 239);
            this.btnSearch_Zone.Name = "btnSearch_Zone";
            this.btnSearch_Zone.Size = new System.Drawing.Size(82, 23);
            this.btnSearch_Zone.TabIndex = 6;
            this.btnSearch_Zone.Text = "Search";
            this.btnSearch_Zone.UseVisualStyleBackColor = true;
            this.btnSearch_Zone.Click += new System.EventHandler(this.btnSearch_Zone_Click);
            // 
            // btnDelete_Zone
            // 
            this.btnDelete_Zone.Location = new System.Drawing.Point(320, 239);
            this.btnDelete_Zone.Name = "btnDelete_Zone";
            this.btnDelete_Zone.Size = new System.Drawing.Size(78, 23);
            this.btnDelete_Zone.TabIndex = 7;
            this.btnDelete_Zone.Text = "Delete";
            this.btnDelete_Zone.UseVisualStyleBackColor = true;
            this.btnDelete_Zone.Click += new System.EventHandler(this.btnDelete_Zone_Click);
            // 
            // btnSave_Zones
            // 
            this.btnSave_Zones.Location = new System.Drawing.Point(12, 281);
            this.btnSave_Zones.Name = "btnSave_Zones";
            this.btnSave_Zones.Size = new System.Drawing.Size(386, 23);
            this.btnSave_Zones.TabIndex = 8;
            this.btnSave_Zones.Text = "Save";
            this.btnSave_Zones.UseVisualStyleBackColor = true;
            this.btnSave_Zones.Click += new System.EventHandler(this.btnSave_Zones_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 315);
            this.Controls.Add(this.btnSave_Zones);
            this.Controls.Add(this.btnDelete_Zone);
            this.Controls.Add(this.btnSearch_Zone);
            this.Controls.Add(this.btnRead_Zone);
            this.Controls.Add(this.btnCreate_Zone);
            this.Controls.Add(this.IdMedia_Zone);
            this.Controls.Add(this.numeZona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Zone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numeZona;
        private System.Windows.Forms.TextBox IdMedia_Zone;
        private System.Windows.Forms.Button btnCreate_Zone;
        private System.Windows.Forms.Button btnRead_Zone;
        private System.Windows.Forms.Button btnSearch_Zone;
        private System.Windows.Forms.Button btnDelete_Zone;
        private System.Windows.Forms.Button btnSave_Zones;
    }
}