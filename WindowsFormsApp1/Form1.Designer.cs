
namespace WindowsFormsApp1
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
            this.dgvGolf = new System.Windows.Forms.DataGridView();
            this.btnload_db = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.txtdob = new System.Windows.Forms.TextBox();
            this.txtstreet = new System.Windows.Forms.TextBox();
            this.txtsuburb = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtavailable = new System.Windows.Forms.TextBox();
            this.txthandicap = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGolf)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGolf
            // 
            this.dgvGolf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGolf.Location = new System.Drawing.Point(322, 12);
            this.dgvGolf.Name = "dgvGolf";
            this.dgvGolf.RowHeadersWidth = 51;
            this.dgvGolf.RowTemplate.Height = 24;
            this.dgvGolf.Size = new System.Drawing.Size(538, 323);
            this.dgvGolf.TabIndex = 0;
            // 
            // btnload_db
            // 
            this.btnload_db.Location = new System.Drawing.Point(79, 97);
            this.btnload_db.Name = "btnload_db";
            this.btnload_db.Size = new System.Drawing.Size(146, 23);
            this.btnload_db.TabIndex = 1;
            this.btnload_db.Text = "load data";
            this.btnload_db.UseVisualStyleBackColor = true;
            this.btnload_db.Click += new System.EventHandler(this.btnload_db_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(79, 384);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 2;
            // 
            // txtsurname
            // 
            this.txtsurname.Location = new System.Drawing.Point(297, 384);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(100, 22);
            this.txtsurname.TabIndex = 3;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(513, 384);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(100, 22);
            this.txtfirstname.TabIndex = 4;
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(701, 378);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(100, 22);
            this.txttitle.TabIndex = 5;
            // 
            // txtgender
            // 
            this.txtgender.Location = new System.Drawing.Point(886, 378);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(100, 22);
            this.txtgender.TabIndex = 6;
            // 
            // txtdob
            // 
            this.txtdob.Location = new System.Drawing.Point(1053, 378);
            this.txtdob.Name = "txtdob";
            this.txtdob.Size = new System.Drawing.Size(100, 22);
            this.txtdob.TabIndex = 7;
            // 
            // txtstreet
            // 
            this.txtstreet.Location = new System.Drawing.Point(79, 412);
            this.txtstreet.Name = "txtstreet";
            this.txtstreet.Size = new System.Drawing.Size(100, 22);
            this.txtstreet.TabIndex = 8;
            // 
            // txtsuburb
            // 
            this.txtsuburb.Location = new System.Drawing.Point(297, 412);
            this.txtsuburb.Name = "txtsuburb";
            this.txtsuburb.Size = new System.Drawing.Size(100, 22);
            this.txtsuburb.TabIndex = 9;
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(513, 412);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(100, 22);
            this.txtcity.TabIndex = 10;
            // 
            // txtavailable
            // 
            this.txtavailable.Location = new System.Drawing.Point(701, 412);
            this.txtavailable.Name = "txtavailable";
            this.txtavailable.Size = new System.Drawing.Size(100, 22);
            this.txtavailable.TabIndex = 11;
            // 
            // txthandicap
            // 
            this.txthandicap.Location = new System.Drawing.Point(886, 412);
            this.txthandicap.Name = "txthandicap";
            this.txthandicap.Size = new System.Drawing.Size(100, 22);
            this.txthandicap.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 523);
            this.Controls.Add(this.txthandicap);
            this.Controls.Add(this.txtavailable);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.txtsuburb);
            this.Controls.Add(this.txtstreet);
            this.Controls.Add(this.txtdob);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnload_db);
            this.Controls.Add(this.dgvGolf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGolf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGolf;
        private System.Windows.Forms.Button btnload_db;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.TextBox txtdob;
        private System.Windows.Forms.TextBox txtstreet;
        private System.Windows.Forms.TextBox txtsuburb;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtavailable;
        private System.Windows.Forms.TextBox txthandicap;
    }
}

