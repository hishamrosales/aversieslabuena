namespace ola
{
    partial class FrmDatos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BttAdd = new System.Windows.Forms.Button();
            this.BttDelete = new System.Windows.Forms.Button();
            this.TxtStudent = new System.Windows.Forms.TextBox();
            this.LstStudents = new System.Windows.Forms.ListBox();
            this.LblAge = new System.Windows.Forms.Label();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BttShow = new System.Windows.Forms.Button();
            this.BttAge = new System.Windows.Forms.Button();
            this.MntDate = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // BttAdd
            // 
            this.BttAdd.Location = new System.Drawing.Point(171, 15);
            this.BttAdd.Name = "BttAdd";
            this.BttAdd.Size = new System.Drawing.Size(75, 23);
            this.BttAdd.TabIndex = 0;
            this.BttAdd.Text = "Add";
            this.BttAdd.UseVisualStyleBackColor = true;
            this.BttAdd.Click += new System.EventHandler(this.BttAdd_Click);
            // 
            // BttDelete
            // 
            this.BttDelete.Location = new System.Drawing.Point(274, 15);
            this.BttDelete.Name = "BttDelete";
            this.BttDelete.Size = new System.Drawing.Size(75, 23);
            this.BttDelete.TabIndex = 1;
            this.BttDelete.Text = "Delete";
            this.BttDelete.UseVisualStyleBackColor = true;
            this.BttDelete.Click += new System.EventHandler(this.BttDelete_Click);
            // 
            // TxtStudent
            // 
            this.TxtStudent.Location = new System.Drawing.Point(35, 15);
            this.TxtStudent.Name = "TxtStudent";
            this.TxtStudent.Size = new System.Drawing.Size(100, 20);
            this.TxtStudent.TabIndex = 2;
            this.TxtStudent.TextChanged += new System.EventHandler(this.TxtStudent_TextChanged);
            // 
            // LstStudents
            // 
            this.LstStudents.FormattingEnabled = true;
            this.LstStudents.Location = new System.Drawing.Point(35, 54);
            this.LstStudents.Name = "LstStudents";
            this.LstStudents.Size = new System.Drawing.Size(186, 147);
            this.LstStudents.TabIndex = 3;
            this.LstStudents.SelectedIndexChanged += new System.EventHandler(this.LstStudents_SelectedIndexChanged);
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Location = new System.Drawing.Point(299, 130);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(26, 13);
            this.LblAge.TabIndex = 4;
            this.LblAge.Text = "Age";
            this.LblAge.Click += new System.EventHandler(this.LblAge_Click);
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(371, 127);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(100, 20);
            this.TxtAge.TabIndex = 5;
            this.TxtAge.TextChanged += new System.EventHandler(this.TxtAge_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(552, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // BttShow
            // 
            this.BttShow.Location = new System.Drawing.Point(601, 90);
            this.BttShow.Name = "BttShow";
            this.BttShow.Size = new System.Drawing.Size(75, 23);
            this.BttShow.TabIndex = 7;
            this.BttShow.Text = "Show";
            this.BttShow.UseVisualStyleBackColor = true;
            this.BttShow.Click += new System.EventHandler(this.BttShow_Click);
            // 
            // BttAge
            // 
            this.BttAge.Location = new System.Drawing.Point(601, 178);
            this.BttAge.Name = "BttAge";
            this.BttAge.Size = new System.Drawing.Size(75, 23);
            this.BttAge.TabIndex = 8;
            this.BttAge.Text = "Age";
            this.BttAge.UseVisualStyleBackColor = true;
            this.BttAge.Click += new System.EventHandler(this.BttAge_Click);
            this.BttAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BttAge_KeyPress);
            // 
            // MntDate
            // 
            this.MntDate.Location = new System.Drawing.Point(302, 270);
            this.MntDate.Name = "MntDate";
            this.MntDate.TabIndex = 9;
            this.MntDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // FrmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MntDate);
            this.Controls.Add(this.BttAge);
            this.Controls.Add(this.BttShow);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.LstStudents);
            this.Controls.Add(this.TxtStudent);
            this.Controls.Add(this.BttDelete);
            this.Controls.Add(this.BttAdd);
            this.Name = "FrmDatos";
            this.Text = "FrmDatos";
            this.Load += new System.EventHandler(this.FrmDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BttAdd;
        private System.Windows.Forms.Button BttDelete;
        private System.Windows.Forms.TextBox TxtStudent;
        private System.Windows.Forms.ListBox LstStudents;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BttShow;
        private System.Windows.Forms.Button BttAge;
        private System.Windows.Forms.MonthCalendar MntDate;
    }
}

