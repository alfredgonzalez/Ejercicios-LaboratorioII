using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3_colecciones
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> texto;
        List<string> listaPalabras;
        public Form1()
        {
            InitializeComponent();
            texto = new Dictionary<string, int>();
            listaPalabras = new List<string>();
        }

        public void ContarPalabras(string texto) 
        {
            listaPalabras.AddRange(texto.Split(' ',',',';','.','\t','\n'));

            foreach(string palabra in listaPalabras) 
            {
                if (!this.texto.ContainsKey(palabra)) 
                {
                    this.texto.Add(palabra,1);
                }
                else 
                {
                    this.texto[palabra] += 1;
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            ContarPalabras(rchTexto.Text);
            foreach (KeyValuePair<string, int> elemento in this.texto) 
            {
                sb.AppendLine($"{elemento.Key}\t{elemento.Value}" );
            }
            MessageBox.Show(sb.ToString(), "Texto");
        }
    }
}
