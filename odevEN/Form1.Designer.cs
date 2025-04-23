namespace OdevGP
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtİl = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblİller = new System.Windows.Forms.ListBox();
            this.lblİller2 = new System.Windows.Forms.ListBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(275, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "İL:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtİl
            // 
            this.txtİl.Location = new System.Drawing.Point(314, 131);
            this.txtİl.Name = "txtİl";
            this.txtİl.Size = new System.Drawing.Size(149, 22);
            this.txtİl.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(469, 128);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(88, 29);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblİller
            // 
            this.lblİller.FormattingEnabled = true;
            this.lblİller.ItemHeight = 16;
            this.lblİller.Location = new System.Drawing.Point(114, 184);
            this.lblİller.Name = "lblİller";
            this.lblİller.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lblİller.Size = new System.Drawing.Size(198, 196);
            this.lblİller.TabIndex = 3;
            // 
            // lblİller2
            // 
            this.lblİller2.FormattingEnabled = true;
            this.lblİller2.ItemHeight = 16;
            this.lblİller2.Location = new System.Drawing.Point(528, 184);
            this.lblİller2.Name = "lblİller2";
            this.lblİller2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lblİller2.Size = new System.Drawing.Size(198, 196);
            this.lblİller2.TabIndex = 4;
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Black;
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRight.ForeColor = System.Drawing.Color.White;
            this.btnRight.Location = new System.Drawing.Point(331, 193);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(173, 65);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = "List2\'e Aktar";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 73);
            this.label2.TabIndex = 7;
            this.label2.Text = "İL LİSTELEME PROGRAMI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Black;
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLeft.ForeColor = System.Drawing.Color.White;
            this.btnLeft.Location = new System.Drawing.Point(331, 319);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(173, 61);
            this.btnLeft.TabIndex = 8;
            this.btnLeft.Text = "List1\'e Aktar";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.lblİller2);
            this.Controls.Add(this.lblİller);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtİl);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listbox Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtİl;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lblİller;
        private System.Windows.Forms.ListBox lblİller2;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLeft;
    }
}

