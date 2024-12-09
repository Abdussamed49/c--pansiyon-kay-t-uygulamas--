namespace MUŞ_PANSİYON_OTOMASYONU
{
    partial class fmrmesajlar
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
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.frmmesajlar = new System.Windows.Forms.RichTextBox();
            this.btnkaydet3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ad soyad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "mesaj :";
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(116, 45);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(355, 20);
            this.txtadsoyad.TabIndex = 2;
            // 
            // frmmesajlar
            // 
            this.frmmesajlar.Location = new System.Drawing.Point(117, 90);
            this.frmmesajlar.Name = "frmmesajlar";
            this.frmmesajlar.Size = new System.Drawing.Size(354, 213);
            this.frmmesajlar.TabIndex = 3;
            this.frmmesajlar.Text = "";
            // 
            // btnkaydet3
            // 
            this.btnkaydet3.Location = new System.Drawing.Point(170, 309);
            this.btnkaydet3.Name = "btnkaydet3";
            this.btnkaydet3.Size = new System.Drawing.Size(207, 54);
            this.btnkaydet3.TabIndex = 4;
            this.btnkaydet3.Text = "kaydet";
            this.btnkaydet3.UseVisualStyleBackColor = true;
            this.btnkaydet3.Click += new System.EventHandler(this.btnkaydet3_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 369);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(477, 132);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ad soyad";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "mesaj";
            // 
            // fmrmesajlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 523);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnkaydet3);
            this.Controls.Add(this.frmmesajlar);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmrmesajlar";
            this.Text = "fmrmesajlar";
            this.Load += new System.EventHandler(this.fmrmesajlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.RichTextBox frmmesajlar;
        private System.Windows.Forms.Button btnkaydet3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}