using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EstudoWinForm
{
	public partial class Inicio : Form
	{
		public Inicio()
		{
			InitializeComponent();
		}

		private void SalvarClick(object sender, EventArgs e)
		{
			saveFileDialog1.ShowDialog();
		}

		private void SalvarOk(object sender, CancelEventArgs e)
		{
			string caminho = saveFileDialog1.FileName; //pega o nome do diretorio, nome e extenção
			File.WriteAllText(caminho, txbJanela.Text);
		}

		private void AbrirArquivo(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
		}

		private void AbrirOk(object sender, CancelEventArgs e)
		{
			string caminho = openFileDialog1.FileName;
			File.Open(caminho, FileMode.Open);
			
		}
	}
}
