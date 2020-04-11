namespace Client
{
    partial class Form3
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
            this.numeEvent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdMedia_Event = new System.Windows.Forms.TextBox();
            this.btnCreate_Event = new System.Windows.Forms.Button();
            this.btnRead_Event = new System.Windows.Forms.Button();
            this.btnSearch_Event = new System.Windows.Forms.Button();
            this.btnDelete_Event = new System.Windows.Forms.Button();
            this.btnSave_Event = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numeEvent
            // 
            this.numeEvent.Location = new System.Drawing.Point(30, 73);
            this.numeEvent.Name = "numeEvent";
            this.numeEvent.Size = new System.Drawing.Size(217, 22);
            this.numeEvent.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "IdMedia";
            // 
            // IdMedia_Event
            // 
            this.IdMedia_Event.Location = new System.Drawing.Point(30, 173);
            this.IdMedia_Event.Name = "IdMedia_Event";
            this.IdMedia_Event.Size = new System.Drawing.Size(217, 22);
            this.IdMedia_Event.TabIndex = 3;
            // 
            // btnCreate_Event
            // 
            this.btnCreate_Event.Location = new System.Drawing.Point(12, 258);
            this.btnCreate_Event.Name = "btnCreate_Event";
            this.btnCreate_Event.Size = new System.Drawing.Size(88, 23);
            this.btnCreate_Event.TabIndex = 4;
            this.btnCreate_Event.Text = "Create";
            this.btnCreate_Event.UseVisualStyleBackColor = true;
            this.btnCreate_Event.Click += new System.EventHandler(this.btnCreate_Event_Click);
            // 
            // btnRead_Event
            // 
            this.btnRead_Event.Location = new System.Drawing.Point(119, 258);
            this.btnRead_Event.Name = "btnRead_Event";
            this.btnRead_Event.Size = new System.Drawing.Size(92, 23);
            this.btnRead_Event.TabIndex = 5;
            this.btnRead_Event.Text = "Read";
            this.btnRead_Event.UseVisualStyleBackColor = true;
            this.btnRead_Event.Click += new System.EventHandler(this.btnRead_Event_Click);
            // 
            // btnSearch_Event
            // 
            this.btnSearch_Event.Location = new System.Drawing.Point(229, 258);
            this.btnSearch_Event.Name = "btnSearch_Event";
            this.btnSearch_Event.Size = new System.Drawing.Size(91, 23);
            this.btnSearch_Event.TabIndex = 6;
            this.btnSearch_Event.Text = "Search";
            this.btnSearch_Event.UseVisualStyleBackColor = true;
            this.btnSearch_Event.Click += new System.EventHandler(this.btnSearch_Event_Click);
            // 
            // btnDelete_Event
            // 
            this.btnDelete_Event.Location = new System.Drawing.Point(340, 258);
            this.btnDelete_Event.Name = "btnDelete_Event";
            this.btnDelete_Event.Size = new System.Drawing.Size(91, 23);
            this.btnDelete_Event.TabIndex = 7;
            this.btnDelete_Event.Text = "Delete";
            this.btnDelete_Event.UseVisualStyleBackColor = true;
            this.btnDelete_Event.Click += new System.EventHandler(this.btnDelete_Event_Click);
            // 
            // btnSave_Event
            // 
            this.btnSave_Event.Location = new System.Drawing.Point(12, 289);
            this.btnSave_Event.Name = "btnSave_Event";
            this.btnSave_Event.Size = new System.Drawing.Size(419, 23);
            this.btnSave_Event.TabIndex = 8;
            this.btnSave_Event.Text = "Save";
            this.btnSave_Event.UseVisualStyleBackColor = true;
            this.btnSave_Event.Click += new System.EventHandler(this.btnSave_Event_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 324);
            this.Controls.Add(this.btnSave_Event);
            this.Controls.Add(this.btnDelete_Event);
            this.Controls.Add(this.btnSearch_Event);
            this.Controls.Add(this.btnRead_Event);
            this.Controls.Add(this.btnCreate_Event);
            this.Controls.Add(this.IdMedia_Event);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeEvent);
            this.Name = "Form3";
            this.Text = "Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numeEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdMedia_Event;
        private System.Windows.Forms.Button btnCreate_Event;
        private System.Windows.Forms.Button btnRead_Event;
        private System.Windows.Forms.Button btnSearch_Event;
        private System.Windows.Forms.Button btnDelete_Event;
        private System.Windows.Forms.Button btnSave_Event;
    }
}