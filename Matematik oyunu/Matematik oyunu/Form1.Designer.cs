namespace Matematik_oyunu
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
            this.components = new System.ComponentModel.Container();
            this.surelbl = new System.Windows.Forms.Label();
            this.SURElabel2 = new System.Windows.Forms.Label();
            this.PUANlabel1 = new System.Windows.Forms.Label();
            this.puanlbl = new System.Windows.Forms.Label();
            this.sayı1 = new System.Windows.Forms.Label();
            this.sayı2 = new System.Windows.Forms.Label();
            this.sayı3 = new System.Windows.Forms.Label();
            this.labelisaret2 = new System.Windows.Forms.Label();
            this.labelisaret1 = new System.Windows.Forms.Label();
            this.SAYI1textBox = new System.Windows.Forms.TextBox();
            this.SAYI2textBox = new System.Windows.Forms.TextBox();
            this.txtcevap = new System.Windows.Forms.TextBox();
            this.tekrarbtn = new System.Windows.Forms.Button();
            this.kontrolbtn = new System.Windows.Forms.Button();
            this.baslabtn = new System.Windows.Forms.Button();
            this.sorubtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // surelbl
            // 
            this.surelbl.AutoSize = true;
            this.surelbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.surelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surelbl.Location = new System.Drawing.Point(517, 13);
            this.surelbl.Name = "surelbl";
            this.surelbl.Size = new System.Drawing.Size(50, 16);
            this.surelbl.TabIndex = 0;
            this.surelbl.Text = "SÜRE";
            this.surelbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // SURElabel2
            // 
            this.SURElabel2.AutoSize = true;
            this.SURElabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SURElabel2.Location = new System.Drawing.Point(577, 16);
            this.SURElabel2.Name = "SURElabel2";
            this.SURElabel2.Size = new System.Drawing.Size(41, 13);
            this.SURElabel2.TabIndex = 1;
            this.SURElabel2.Text = "label2";
            this.SURElabel2.Click += new System.EventHandler(this.SURElabel2_Click);
            // 
            // PUANlabel1
            // 
            this.PUANlabel1.AutoSize = true;
            this.PUANlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PUANlabel1.Location = new System.Drawing.Point(577, 45);
            this.PUANlabel1.Name = "PUANlabel1";
            this.PUANlabel1.Size = new System.Drawing.Size(41, 13);
            this.PUANlabel1.TabIndex = 1;
            this.PUANlabel1.Text = "label2";
            // 
            // puanlbl
            // 
            this.puanlbl.AutoSize = true;
            this.puanlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.puanlbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.puanlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puanlbl.Location = new System.Drawing.Point(517, 42);
            this.puanlbl.Name = "puanlbl";
            this.puanlbl.Size = new System.Drawing.Size(50, 16);
            this.puanlbl.TabIndex = 1;
            this.puanlbl.Text = "PUAN";
            // 
            // sayı1
            // 
            this.sayı1.AutoSize = true;
            this.sayı1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayı1.Location = new System.Drawing.Point(14, 151);
            this.sayı1.Name = "sayı1";
            this.sayı1.Size = new System.Drawing.Size(36, 13);
            this.sayı1.TabIndex = 1;
            this.sayı1.Text = "sayı1";
            // 
            // sayı2
            // 
            this.sayı2.AutoSize = true;
            this.sayı2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayı2.Location = new System.Drawing.Point(235, 155);
            this.sayı2.Name = "sayı2";
            this.sayı2.Size = new System.Drawing.Size(36, 13);
            this.sayı2.TabIndex = 1;
            this.sayı2.Text = "sayı2";
            // 
            // sayı3
            // 
            this.sayı3.AutoSize = true;
            this.sayı3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayı3.Location = new System.Drawing.Point(450, 154);
            this.sayı3.Name = "sayı3";
            this.sayı3.Size = new System.Drawing.Size(47, 13);
            this.sayı3.TabIndex = 1;
            this.sayı3.Text = "CEVAP";
            this.sayı3.Click += new System.EventHandler(this.sayı3_Click);
            // 
            // labelisaret2
            // 
            this.labelisaret2.AutoSize = true;
            this.labelisaret2.Location = new System.Drawing.Point(399, 155);
            this.labelisaret2.Name = "labelisaret2";
            this.labelisaret2.Size = new System.Drawing.Size(13, 13);
            this.labelisaret2.TabIndex = 1;
            this.labelisaret2.Text = "=";
            // 
            // labelisaret1
            // 
            this.labelisaret1.AutoSize = true;
            this.labelisaret1.Location = new System.Drawing.Point(181, 154);
            this.labelisaret1.Name = "labelisaret1";
            this.labelisaret1.Size = new System.Drawing.Size(35, 13);
            this.labelisaret1.TabIndex = 1;
            this.labelisaret1.Text = "label2";
            // 
            // SAYI1textBox
            // 
            this.SAYI1textBox.Location = new System.Drawing.Point(56, 148);
            this.SAYI1textBox.Name = "SAYI1textBox";
            this.SAYI1textBox.Size = new System.Drawing.Size(100, 20);
            this.SAYI1textBox.TabIndex = 2;
            // 
            // SAYI2textBox
            // 
            this.SAYI2textBox.Location = new System.Drawing.Point(277, 151);
            this.SAYI2textBox.Name = "SAYI2textBox";
            this.SAYI2textBox.Size = new System.Drawing.Size(100, 20);
            this.SAYI2textBox.TabIndex = 2;
            // 
            // txtcevap
            // 
            this.txtcevap.Location = new System.Drawing.Point(521, 151);
            this.txtcevap.Name = "txtcevap";
            this.txtcevap.Size = new System.Drawing.Size(100, 20);
            this.txtcevap.TabIndex = 2;
            // 
            // tekrarbtn
            // 
            this.tekrarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tekrarbtn.Location = new System.Drawing.Point(11, 93);
            this.tekrarbtn.Name = "tekrarbtn";
            this.tekrarbtn.Size = new System.Drawing.Size(125, 34);
            this.tekrarbtn.TabIndex = 3;
            this.tekrarbtn.Text = "TEKRAR DENE";
            this.tekrarbtn.UseVisualStyleBackColor = true;
            this.tekrarbtn.Click += new System.EventHandler(this.tekrarbtn_Click);
            // 
            // kontrolbtn
            // 
            this.kontrolbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kontrolbtn.Location = new System.Drawing.Point(17, 206);
            this.kontrolbtn.Name = "kontrolbtn";
            this.kontrolbtn.Size = new System.Drawing.Size(603, 57);
            this.kontrolbtn.TabIndex = 3;
            this.kontrolbtn.Text = "KONTROL";
            this.kontrolbtn.UseVisualStyleBackColor = true;
            this.kontrolbtn.Click += new System.EventHandler(this.KONTROL_Click);
            // 
            // baslabtn
            // 
            this.baslabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslabtn.Location = new System.Drawing.Point(11, 12);
            this.baslabtn.Name = "baslabtn";
            this.baslabtn.Size = new System.Drawing.Size(125, 34);
            this.baslabtn.TabIndex = 3;
            this.baslabtn.Text = "BASLA";
            this.baslabtn.UseVisualStyleBackColor = true;
            this.baslabtn.Click += new System.EventHandler(this.baslabtn_Click);
            // 
            // sorubtn
            // 
            this.sorubtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorubtn.Location = new System.Drawing.Point(11, 52);
            this.sorubtn.Name = "sorubtn";
            this.sorubtn.Size = new System.Drawing.Size(125, 35);
            this.sorubtn.TabIndex = 3;
            this.sorubtn.Text = "SORU GETIR";
            this.sorubtn.UseVisualStyleBackColor = true;
            this.sorubtn.Click += new System.EventHandler(this.sorubtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(633, 282);
            this.Controls.Add(this.sorubtn);
            this.Controls.Add(this.baslabtn);
            this.Controls.Add(this.kontrolbtn);
            this.Controls.Add(this.tekrarbtn);
            this.Controls.Add(this.txtcevap);
            this.Controls.Add(this.SAYI2textBox);
            this.Controls.Add(this.SAYI1textBox);
            this.Controls.Add(this.labelisaret1);
            this.Controls.Add(this.labelisaret2);
            this.Controls.Add(this.sayı3);
            this.Controls.Add(this.sayı2);
            this.Controls.Add(this.sayı1);
            this.Controls.Add(this.puanlbl);
            this.Controls.Add(this.PUANlabel1);
            this.Controls.Add(this.SURElabel2);
            this.Controls.Add(this.surelbl);
            this.Name = "Form1";
            this.Text = "MATEMATİK OYUNU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label surelbl;
        private System.Windows.Forms.Label SURElabel2;
        private System.Windows.Forms.Label PUANlabel1;
        private System.Windows.Forms.Label puanlbl;
        private System.Windows.Forms.Label sayı1;
        private System.Windows.Forms.Label sayı2;
        private System.Windows.Forms.Label sayı3;
        private System.Windows.Forms.Label labelisaret2;
        private System.Windows.Forms.Label labelisaret1;
        private System.Windows.Forms.TextBox SAYI1textBox;
        private System.Windows.Forms.TextBox SAYI2textBox;
        private System.Windows.Forms.TextBox txtcevap;
        private System.Windows.Forms.Button tekrarbtn;
        private System.Windows.Forms.Button kontrolbtn;
        private System.Windows.Forms.Button baslabtn;
        private System.Windows.Forms.Button sorubtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

