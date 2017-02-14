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
			this.text_code_form = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.text_dekod_form = new System.Windows.Forms.RichTextBox();
			this.key_from_form = new System.Windows.Forms.TextBox();
			this.kodiraj = new System.Windows.Forms.Button();
			this.dekodiraj = new System.Windows.Forms.Button();
			this.izbrisi_tekst_dekod = new System.Windows.Forms.Button();
			this.izbrisi_tekst_kod = new System.Windows.Forms.Button();
			this.izbrisi_kljuc = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// text_code_form
			// 
			this.text_code_form.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.text_code_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.text_code_form.Location = new System.Drawing.Point(12, 12);
			this.text_code_form.Name = "text_code_form";
			this.text_code_form.Size = new System.Drawing.Size(364, 100);
			this.text_code_form.TabIndex = 0;
			this.text_code_form.Text = "";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 138);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ključna riječ";
			// 
			// text_dekod_form
			// 
			this.text_dekod_form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.text_dekod_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.text_dekod_form.Location = new System.Drawing.Point(12, 177);
			this.text_dekod_form.Name = "text_dekod_form";
			this.text_dekod_form.Size = new System.Drawing.Size(364, 105);
			this.text_dekod_form.TabIndex = 2;
			this.text_dekod_form.Text = "";
			// 
			// key_from_form
			// 
			this.key_from_form.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.key_from_form.BackColor = System.Drawing.Color.Aqua;
			this.key_from_form.Location = new System.Drawing.Point(83, 135);
			this.key_from_form.Name = "key_from_form";
			this.key_from_form.Size = new System.Drawing.Size(293, 20);
			this.key_from_form.TabIndex = 3;
			// 
			// kodiraj
			// 
			this.kodiraj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
			this.dekodiraj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
			this.izbrisi_tekst_dekod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
			this.izbrisi_tekst_kod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
			this.izbrisi_kljuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.izbrisi_kljuc.Location = new System.Drawing.Point(382, 135);
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
			this.ClientSize = new System.Drawing.Size(469, 294);
			this.Controls.Add(this.izbrisi_kljuc);
			this.Controls.Add(this.izbrisi_tekst_kod);
			this.Controls.Add(this.izbrisi_tekst_dekod);
			this.Controls.Add(this.dekodiraj);
			this.Controls.Add(this.kodiraj);
			this.Controls.Add(this.key_from_form);
			this.Controls.Add(this.text_dekod_form);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.text_code_form);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Kodiranje teksta";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox text_code_form;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox text_dekod_form;
		private System.Windows.Forms.TextBox key_from_form;
		private System.Windows.Forms.Button kodiraj;
		private System.Windows.Forms.Button dekodiraj;
		private System.Windows.Forms.Button izbrisi_tekst_dekod;
		private System.Windows.Forms.Button izbrisi_tekst_kod;
		private System.Windows.Forms.Button izbrisi_kljuc;
	}
}

