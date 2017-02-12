namespace KodiranjeTeksta {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.kod = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dekod = new System.Windows.Forms.RichTextBox();
			this.kljuc = new System.Windows.Forms.TextBox();
			this.kodiraj = new System.Windows.Forms.Button();
			this.dekodiraj = new System.Windows.Forms.Button();
			this.izbrisi_tekst_dekod = new System.Windows.Forms.Button();
			this.izbrisi_tekst_kod = new System.Windows.Forms.Button();
			this.izbrisi_kljuc = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// kod
			// 
			this.kod.Location = new System.Drawing.Point(12, 12);
			this.kod.Name = "kod";
			this.kod.Size = new System.Drawing.Size(364, 100);
			this.kod.TabIndex = 0;
			this.kod.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 138);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ključna riječ";
			// 
			// dekod
			// 
			this.dekod.Location = new System.Drawing.Point(12, 177);
			this.dekod.Name = "dekod";
			this.dekod.Size = new System.Drawing.Size(364, 92);
			this.dekod.TabIndex = 2;
			this.dekod.Text = "";
			// 
			// kljuc
			// 
			this.kljuc.Location = new System.Drawing.Point(83, 135);
			this.kljuc.Name = "kljuc";
			this.kljuc.Size = new System.Drawing.Size(293, 20);
			this.kljuc.TabIndex = 3;
			// 
			// kodiraj
			// 
			this.kodiraj.Location = new System.Drawing.Point(382, 12);
			this.kodiraj.Name = "kodiraj";
			this.kodiraj.Size = new System.Drawing.Size(75, 23);
			this.kodiraj.TabIndex = 4;
			this.kodiraj.Text = "Kodiraj";
			this.kodiraj.UseVisualStyleBackColor = true;
			this.kodiraj.Click += new System.EventHandler(this.kodiraj_Click);
			// 
			// dekodiraj
			// 
			this.dekodiraj.Location = new System.Drawing.Point(382, 177);
			this.dekodiraj.Name = "dekodiraj";
			this.dekodiraj.Size = new System.Drawing.Size(75, 23);
			this.dekodiraj.TabIndex = 5;
			this.dekodiraj.Text = "Dekodiraj";
			this.dekodiraj.UseVisualStyleBackColor = true;
			this.dekodiraj.Click += new System.EventHandler(this.dekodiraj_Click);
			// 
			// izbrisi_tekst_dekod
			// 
			this.izbrisi_tekst_dekod.Location = new System.Drawing.Point(382, 206);
			this.izbrisi_tekst_dekod.Name = "izbrisi_tekst_dekod";
			this.izbrisi_tekst_dekod.Size = new System.Drawing.Size(75, 23);
			this.izbrisi_tekst_dekod.TabIndex = 6;
			this.izbrisi_tekst_dekod.Text = "Izbriši tekst";
			this.izbrisi_tekst_dekod.UseVisualStyleBackColor = true;
			this.izbrisi_tekst_dekod.Click += new System.EventHandler(this.izbrisi_tekst_dekod_Click);
			// 
			// izbrisi_tekst_kod
			// 
			this.izbrisi_tekst_kod.Location = new System.Drawing.Point(382, 41);
			this.izbrisi_tekst_kod.Name = "izbrisi_tekst_kod";
			this.izbrisi_tekst_kod.Size = new System.Drawing.Size(75, 23);
			this.izbrisi_tekst_kod.TabIndex = 7;
			this.izbrisi_tekst_kod.Text = "Izbriši tekst";
			this.izbrisi_tekst_kod.UseVisualStyleBackColor = true;
			this.izbrisi_tekst_kod.Click += new System.EventHandler(this.izbrisi_tekst_kod_Click);
			// 
			// izbrisi_kljuc
			// 
			this.izbrisi_kljuc.Location = new System.Drawing.Point(382, 128);
			this.izbrisi_kljuc.Name = "izbrisi_kljuc";
			this.izbrisi_kljuc.Size = new System.Drawing.Size(75, 23);
			this.izbrisi_kljuc.TabIndex = 8;
			this.izbrisi_kljuc.Text = "Izbriši ključ";
			this.izbrisi_kljuc.UseVisualStyleBackColor = true;
			this.izbrisi_kljuc.Click += new System.EventHandler(this.izbrisi_kljuc_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 300);
			this.Controls.Add(this.izbrisi_kljuc);
			this.Controls.Add(this.izbrisi_tekst_kod);
			this.Controls.Add(this.izbrisi_tekst_dekod);
			this.Controls.Add(this.dekodiraj);
			this.Controls.Add(this.kodiraj);
			this.Controls.Add(this.kljuc);
			this.Controls.Add(this.dekod);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.kod);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Kodiranje teksta";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox kod;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox dekod;
		private System.Windows.Forms.TextBox kljuc;
		private System.Windows.Forms.Button kodiraj;
		private System.Windows.Forms.Button dekodiraj;
		private System.Windows.Forms.Button izbrisi_tekst_dekod;
		private System.Windows.Forms.Button izbrisi_tekst_kod;
		private System.Windows.Forms.Button izbrisi_kljuc;
	}
}

