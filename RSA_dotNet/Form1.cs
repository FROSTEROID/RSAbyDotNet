using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;

using System.Security.Cryptography;

namespace RSA_dotNet
{
	public partial class Form1 : Form
	{

		private const int KEY_LENGTH_BITS = 4096;

		Encoding coder = Encoding.Unicode;

		RSACryptoServiceProvider encryptor1;
		RSACryptoServiceProvider decryptor1;
		RSACryptoServiceProvider encryptor2;
		RSACryptoServiceProvider decryptor2;

		public Form1(){
			InitializeComponent();
		}

		#region Creating!
		private void CB_1dCreate_Click(object sender, EventArgs e){
			decryptor1 = new RSACryptoServiceProvider(KEY_LENGTH_BITS);
		}
		private void CB_2dCreate_Click(object sender, EventArgs e){
			decryptor2 = new RSACryptoServiceProvider(KEY_LENGTH_BITS);
		}

		private void CB_1eCreate_Click(object sender, EventArgs e){
			encryptor1 = new RSACryptoServiceProvider();
			encryptor1.ImportParameters(decryptor2.ExportParameters(false));
		}

		private void CB_2eCreate_Click(object sender, EventArgs e){
			encryptor2 = new RSACryptoServiceProvider();
			encryptor2.ImportParameters(decryptor1.ExportParameters(false));// Why does it work so slowly? %)
		}
		#endregion

		#region Client1 working
		
		private void tB_1encIn_DoubleClick(object sender, EventArgs e) {
			byte[] coded = coder.GetBytes(tB_1encIn.Text);
			byte[] crypted = encryptor1.Encrypt(coded, true);

			tB_1encOut.Text = Convert.ToBase64String(crypted);
		}

		private void tB_1decIn_DoubleClick(object sender, EventArgs e){
			byte[] crypted = Convert.FromBase64String(tB_1decIn.Text);
			byte[] decrypted = decryptor1.Decrypt(crypted, true);

			tB_1decOut.Text = new String(coder.GetChars(decrypted));
		}
		#endregion

		#region Client2 working

		private void tB_2encIn_DoubleClick(object sender, EventArgs e){
			byte[] coded = coder.GetBytes(tB_2encIn.Text);
			byte[] crypted = encryptor2.Encrypt(coded, true);

			tB_2encOut.Text = Convert.ToBase64String(crypted);
		}
		
		private void tB_2decIn_DoubleClick(object sender, EventArgs e){
			byte[] crypted = Convert.FromBase64String(tB_2decIn.Text);
			byte[] decrypted = decryptor2.Decrypt(crypted, true);

			tB_2decOut.Text = new String(coder.GetChars(decrypted));
		}
		#endregion

		#region testing
		private void button1_Click(object sender, EventArgs e)
		{
			String str;
			byte[] a = {0x55, 0x01, 0x11};

			str = "";
			foreach (byte b in a){
				str+= b.ToString() + "; ";
			}
			MessageBox.Show(str);

			str = Convert.ToBase64String(a);
			MessageBox.Show(str);

			a = Convert.FromBase64String(str);
			str = "";
			foreach (byte b in a){
				str += b.ToString() + "; ";
			}
			MessageBox.Show(str);
		}
		#endregion


	}
}
