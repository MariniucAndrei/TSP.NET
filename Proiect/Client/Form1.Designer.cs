namespace Client
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
            this.nume = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.TextBox();
            this.calea = new System.Windows.Forms.TextBox();
            this.idZona = new System.Windows.Forms.TextBox();
            this.idGrup = new System.Windows.Forms.TextBox();
            this.idEveniment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.esteStearsa = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.numenou = new System.Windows.Forms.TextBox();
            this.label100 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nume
            // 
            this.nume.Location = new System.Drawing.Point(41, 193);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(474, 22);
            this.nume.TabIndex = 1;
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(41, 278);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(474, 22);
            this.data.TabIndex = 2;
            // 
            // calea
            // 
            this.calea.Location = new System.Drawing.Point(41, 365);
            this.calea.Name = "calea";
            this.calea.Size = new System.Drawing.Size(474, 22);
            this.calea.TabIndex = 3;
            // 
            // idZona
            // 
            this.idZona.Location = new System.Drawing.Point(41, 523);
            this.idZona.Name = "idZona";
            this.idZona.Size = new System.Drawing.Size(474, 22);
            this.idZona.TabIndex = 5;
            // 
            // idGrup
            // 
            this.idGrup.Location = new System.Drawing.Point(41, 601);
            this.idGrup.Name = "idGrup";
            this.idGrup.Size = new System.Drawing.Size(474, 22);
            this.idGrup.TabIndex = 6;
            // 
            // idEveniment
            // 
            this.idEveniment.Location = new System.Drawing.Point(41, 682);
            this.idEveniment.Name = "idEveniment";
            this.idEveniment.Size = new System.Drawing.Size(474, 22);
            this.idEveniment.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Path";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Deleted";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "IdZone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 569);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "IdGroup";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 652);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "IdEvent";
            // 
            // esteStearsa
            // 
            this.esteStearsa.FormattingEnabled = true;
            this.esteStearsa.Items.AddRange(new object[] {
            "false",
            "true"});
            this.esteStearsa.Location = new System.Drawing.Point(41, 442);
            this.esteStearsa.Name = "esteStearsa";
            this.esteStearsa.Size = new System.Drawing.Size(474, 24);
            this.esteStearsa.TabIndex = 17;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(41, 735);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(136, 34);
            this.btnCreate.TabIndex = 18;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(199, 735);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(136, 34);
            this.btnRead.TabIndex = 19;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(354, 735);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 34);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(520, 735);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 34);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(685, 735);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 34);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(850, 735);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(136, 34);
            this.btnFilter.TabIndex = 23;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(42, 789);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(944, 47);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // numenou
            // 
            this.numenou.Location = new System.Drawing.Point(649, 193);
            this.numenou.Name = "numenou";
            this.numenou.Size = new System.Drawing.Size(337, 22);
            this.numenou.TabIndex = 25;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(646, 160);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(74, 17);
            this.label100.TabIndex = 26;
            this.label100.Text = "New name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 845);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.numenou);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.esteStearsa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idEveniment);
            this.Controls.Add(this.idGrup);
            this.Controls.Add(this.idZona);
            this.Controls.Add(this.calea);
            this.Controls.Add(this.data);
            this.Controls.Add(this.nume);
            this.Name = "Form1";
            this.Text = "Media";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.TextBox calea;
        private System.Windows.Forms.TextBox idZona;
        private System.Windows.Forms.TextBox idGrup;
        private System.Windows.Forms.TextBox idEveniment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox esteStearsa;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox numenou;
        private System.Windows.Forms.Label label100;
    }
}

