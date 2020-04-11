namespace Client
{
    partial class Form2
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
            this.btnMedias = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnZones = new System.Windows.Forms.Button();
            this.btnPeopleGroups = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMedias
            // 
            this.btnMedias.Location = new System.Drawing.Point(22, 40);
            this.btnMedias.Name = "btnMedias";
            this.btnMedias.Size = new System.Drawing.Size(110, 42);
            this.btnMedias.TabIndex = 0;
            this.btnMedias.Text = "Medias";
            this.btnMedias.UseVisualStyleBackColor = true;
            this.btnMedias.Click += new System.EventHandler(this.btnMedias_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(22, 131);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(110, 42);
            this.btnEvents.TabIndex = 1;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnZones
            // 
            this.btnZones.Location = new System.Drawing.Point(192, 40);
            this.btnZones.Name = "btnZones";
            this.btnZones.Size = new System.Drawing.Size(100, 42);
            this.btnZones.TabIndex = 2;
            this.btnZones.Text = "Zones";
            this.btnZones.UseVisualStyleBackColor = true;
            this.btnZones.Click += new System.EventHandler(this.btnZones_Click);
            // 
            // btnPeopleGroups
            // 
            this.btnPeopleGroups.Location = new System.Drawing.Point(192, 131);
            this.btnPeopleGroups.Name = "btnPeopleGroups";
            this.btnPeopleGroups.Size = new System.Drawing.Size(111, 42);
            this.btnPeopleGroups.TabIndex = 3;
            this.btnPeopleGroups.Text = "PeopleGroups";
            this.btnPeopleGroups.UseVisualStyleBackColor = true;
            this.btnPeopleGroups.Click += new System.EventHandler(this.btnPeopleGroups_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 220);
            this.Controls.Add(this.btnPeopleGroups);
            this.Controls.Add(this.btnZones);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnMedias);
            this.Name = "Form2";
            this.Text = "MyPhotos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMedias;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnZones;
        private System.Windows.Forms.Button btnPeopleGroups;
    }
}