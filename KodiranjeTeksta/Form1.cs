using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KodiranjeTeksta {

	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}


		public static string KeyLonger(string word, string key) {

			string longer = String.Empty;
			
			for (int i = 0;i < word.Length;) {
				for (int j = 0;j < key.Length;++j) {
					longer = longer + key.ElementAt(j);
					++i;
					if (i == word.Length)
						break;
				}
			}
			return longer;
		}

		private void dekodiraj_Click(object sender, EventArgs e) {

			if (dekod.Text == "") {
				dekod.Text = "Morate upisati neki tekst!";
				return;
			}

			if (kljuc.Text == ""){
				kljuc.Text = "Morate upisati neki ključ!";
				return;
			}

			Dictionary<char, int> d = new Dictionary<char, int>();
			string word = dekod.Text;
			string key = kljuc.Text;

			if (key.Length > word.Length) {
				dekod.Text = "Prekratka riječ, duljina teksta mora biti dulja od duljine ključa!";
				return;
			}

			key = KeyLonger(word, key);
			int[] values = new int[word.Length];
			int[] values1 = new int[word.Length];
			int[] result = new int[word.Length];

			for (int i = 0;i < 2048;++i) {

				d.Add((char)(' ' + i), i);
			}

			for (int i = 0;i < word.Length;++i) {

				for (int j = 0;j < 2048;++j) {

					if (word.ElementAt(i) == d.ElementAt(j).Key) {
						values[i] = d.ElementAt(j).Value;
						break;
					}
				}
			}

			for (int i = 0;i < key.Length;++i) {

				for (int j = 0;j < 2048;++j) {

					if (key.ElementAt(i) == d.ElementAt(j).Key) {
						values1[i] = d.ElementAt(j).Value;
						break;
					}
				}
			}

			for (int i = 0;i < key.Length;++i) {

				result[i] = values[i] - values1[i];
				if (result[i] < 0) {
					result[i] = result[i] + 2048;
				}
			}
			string kodtext = string.Empty;

			for (int i = 0;i < key.Length;++i) {


				for (int j = 0;j < 2048;++j) {

					if (result[i] == d.ElementAt(j).Value) {
						kodtext += d.ElementAt(j).Key;
						break;
					}
				}
			}
			kod.Text = kodtext;

		}

		private void kodiraj_Click(object sender, EventArgs e) {

			if (kod.Text == "") {
				kod.Text = "Morate upisati neki text!";
				return;
			}

			if (kljuc.Text == "") {
				kljuc.Text = "Morate upisati neki ključ!";
				return;
			}

			Dictionary<char, int> d = new Dictionary<char, int>();
			string word =kod.Text;
			string key = kljuc.Text;

			if (key.Length > word.Length) {
				kod.Text = "Prekratka riječ, duljina teksta mora biti dulja od duljine ključa!";
				return;
			}

			key =KeyLonger(word, key);
			int[] values = new int[word.Length];
			int[] values1 = new int[word.Length];
			int[] result = new int[word.Length];

			for (int i = 0;i < 2048;++i) {

				d.Add((char)(' ' + i), i);
			}

			for (int i = 0;i < word.Length;++i) {

				for (int j = 0;j < 2048;++j) {

					if (word.ElementAt(i) == d.ElementAt(j).Key) {
						values[i] = d.ElementAt(j).Value;
						break;
					}
				}
			}

			for (int i = 0;i < key.Length;++i) {

				for (int j = 0;j < 1920;++j) {

					if (key.ElementAt(i) == d.ElementAt(j).Key) {
						values1[i] = d.ElementAt(j).Value;
						break;
					}
				}
			}

			for (int i = 0;i < key.Length;++i) {

				result[i] = values[i] + values1[i];                     
				if (result[i] > 2048) {
					result[i] = result[i] % 2048;
				}
			}
			string dekodtext = string.Empty;

			for (int i = 0;i < key.Length;++i) {

				
				for (int j = 0;j < 2048;++j) {

					if (result[i] == d.ElementAt(j).Value) {
						dekodtext+= d.ElementAt(j).Key;
						break;
					}
				}
			}
			dekod.Text = dekodtext;

		}

		private void izbrisi_tekst_kod_Click(object sender, EventArgs e) {
			kod.ResetText();
		}

		private void izbrisi_kljuc_Click(object sender, EventArgs e) {
			kljuc.ResetText();
		}

		private void izbrisi_tekst_dekod_Click(object sender, EventArgs e) {
			dekod.ResetText();
		}
	}
}
