namespace Speech_Recognition
{
    partial class Employee
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
            this.bus_id = new System.Windows.Forms.TextBox();
            this.trevaling_class = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.departure = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Save_Changes = new System.Windows.Forms.Button();
            this.arrival = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bus ID";
            // 
            // bus_id
            // 
            this.bus_id.Location = new System.Drawing.Point(223, 69);
            this.bus_id.Multiline = true;
            this.bus_id.Name = "bus_id";
            this.bus_id.Size = new System.Drawing.Size(200, 26);
            this.bus_id.TabIndex = 1;
            // 
            // trevaling_class
            // 
            this.trevaling_class.Location = new System.Drawing.Point(641, 73);
            this.trevaling_class.Multiline = true;
            this.trevaling_class.Name = "trevaling_class";
            this.trevaling_class.Size = new System.Drawing.Size(200, 26);
            this.trevaling_class.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(469, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trevaling Class";
            // 
            // departure
            // 
            this.departure.Location = new System.Drawing.Point(223, 191);
            this.departure.Multiline = true;
            this.departure.Name = "departure";
            this.departure.Size = new System.Drawing.Size(200, 26);
            this.departure.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "From";
            // 
            // Save_Changes
            // 
            this.Save_Changes.Location = new System.Drawing.Point(428, 414);
            this.Save_Changes.Name = "Save_Changes";
            this.Save_Changes.Size = new System.Drawing.Size(126, 39);
            this.Save_Changes.TabIndex = 6;
            this.Save_Changes.Text = "Save Changes";
            this.Save_Changes.UseVisualStyleBackColor = true;
            this.Save_Changes.Click += new System.EventHandler(this.Save_Changes_Click);
            // 
            // arrival
            // 
            this.arrival.Location = new System.Drawing.Point(641, 191);
            this.arrival.Multiline = true;
            this.arrival.Name = "arrival";
            this.arrival.Size = new System.Drawing.Size(200, 26);
            this.arrival.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "To";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(223, 310);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 495);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.arrival);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Save_Changes);
            this.Controls.Add(this.departure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trevaling_class);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bus_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.Text = "Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bus_id;
        private System.Windows.Forms.TextBox trevaling_class;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox departure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Save_Changes;
        private System.Windows.Forms.TextBox arrival;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
    }
}