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


		 string KeyLonger(string word, string key) {	//	metoda vraća prošireni ključ

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

		void SetValuesFromText(TextValues text_values,int length,string text,Dictionary<char,int> d) {
		   //postavljanje vrijednosti znakova iz teksta u niz 
			for (int i = 0;i < length;++i) {

				for (int j = 0;j < 2048;++j) {

					if (text.ElementAt(i) == d.ElementAt(j).Key) {
						text_values[i]= d.ElementAt(j).Value;
						break;
					}
				}
			}
		}

		void SetValuesFromKey(KeyValues key_values, int length, string text, Dictionary<char, int> d) {
			//postavljanje vrijednosti znakova iz ključa u niz 
			for (int i = 0;i < length;++i) {

				for (int j = 0;j < 2048;++j) {

					if (text.ElementAt(i) == d.ElementAt(j).Key) {
						key_values[i] = d.ElementAt(j).Value;
						break;
					}
				}
			}
		}

		private void dekodiraj_Click(object sender, EventArgs e) {

			if (text_dekod_form.Text == "") {
				text_dekod_form.Text = "Morate upisati neki tekst!";
				return;
			}

			if (key_from_form.Text == ""){
				key_from_form.Text = "Morate upisati neki ključ!";
				return;
			}

			Dictionary<char, int> d = new Dictionary<char, int>();

			for (int i = 0;i < 2048;++i) {

				d.Add((char)(' ' + i), i);
			}

			string text_to_decode = text_dekod_form.Text;
			string key = key_from_form.Text;

			if (key.Length > text_to_decode.Length) {
				text_dekod_form.Text = "Prekratka riječ, duljina teksta mora biti dulja od duljine ključa!";
				return;
			}

			key = KeyLonger(text_to_decode, key);  //poziv funkcije za proširenje ključa

			TextValues text_values = new TextValues(text_to_decode.Length);
			KeyValues key_values = new KeyValues(text_to_decode.Length);
			ResultValues result_values = new ResultValues(text_to_decode.Length);	

			SetValuesFromText(text_values, text_to_decode.Length, text_to_decode, d);
			SetValuesFromKey(key_values, key.Length, key, d);


			for (int i = 0;i < key.Length;++i) {

				result_values[i] = text_values[i] - key_values[i];
				if (result_values[i] < 0) {
					result_values[i] = result_values[i] + 2048;
				}
			}
			string kodtext = string.Empty;

			for (int i = 0;i < key.Length;++i) {


				for (int j = 0;j < 2048;++j) {

					if (result_values[i] == d.ElementAt(j).Value) {
						kodtext += d.ElementAt(j).Key;
						break;
					}
				}
			}

			text_code_form.Text = kodtext;

		}

		private void kodiraj_Click(object sender, EventArgs e) {

			if (text_code_form.Text == "") {
				text_code_form.Text = "Morate upisati neki text!";
				return;
			}

			if (key_from_form.Text == "") {
				key_from_form.Text = "Morate upisati neki ključ!";
				return;
			}

			Dictionary<char, int> d = new Dictionary<char, int>();

			for (int i = 0;i < 2048;++i) {

				d.Add((char)(' ' + i), i);
			}

			string text_to_code =text_code_form.Text;
			string key = key_from_form.Text;

			if (key.Length > text_to_code.Length) {
				text_code_form.Text = "Prekratka riječ, duljina teksta mora biti dulja od duljine ključa!";
				return;
			}

			key=KeyLonger(text_to_code, key);  //poziv funkcije za proširenje ključa

			TextValues text_values = new TextValues(text_to_code.Length);
			KeyValues key_values = new KeyValues(text_to_code.Length);
			ResultValues result_values = new ResultValues(text_to_code.Length);

			SetValuesFromText(text_values, text_to_code.Length, text_to_code, d);
			SetValuesFromKey(key_values, text_to_code.Length, key, d);
			

			for (int i = 0;i < key.Length;++i) {

				result_values[i] = text_values[i] + key_values[i];                     
				if (result_values[i] > 2048) {
					result_values[i] = result_values[i] % 2048;
				}
			}
			string dekodtext = string.Empty;

			for (int i = 0;i < key.Length;++i) {

				
				for (int j = 0;j < 2048;++j) {

					if (result_values[i] == d.ElementAt(j).Value) {
						dekodtext+= d.ElementAt(j).Key;
						break;
					}
				}
			}

			text_dekod_form.Text = dekodtext;
		}

		private void izbrisi_tekst_kod_Click(object sender, EventArgs e) {
			text_code_form.ResetText();
		}

		private void izbrisi_kljuc_Click(object sender, EventArgs e) {
			key_from_form.ResetText();
		}

		private void izbrisi_tekst_dekod_Click(object sender, EventArgs e) {
			text_dekod_form.ResetText();
		}
	}
}
