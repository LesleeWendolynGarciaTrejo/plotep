using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plotep
{
    public partial class Form1 : Form
    {
        const int CANTIDAD_CARTAS = 54;
        //private PictureBox[] cartas;
        private PictureBox[] tabla;
        public Form1()
        {
            InitializeComponent();
            //cartas = new PictureBox[CANTIDAD_CARTAS];
            tabla = new PictureBox[25];
            inicializarTabla();
        }
        private void inicializarTabla()
        {
            int r = 0, c = 0;

            int[] cartas = new int[34];
            

            for (int i = 0; i < cartas.Length; i++)
            {
                cartas[i] = i + 1;
            }
            // Recorrer el arreglo para SWAP - Triangular INTERCAMBIAR un elemento con otro al azar
            Random rnd = new Random();
            int a, aux;
            for (int i = 0; i < cartas.Length; i++)
            {
                a = rnd.Next(cartas.Length);
                aux = cartas[i];
                cartas[i] = cartas[a];
                cartas[a] = aux;
            }
            for (int i = 0; i < tabla.Length; i++)
            {
                tabla[i] = new PictureBox();
                tabla[i].Location = new System.Drawing.Point(100 + (c*90), 25 + (r*125));
                tabla[i].Name = "picTabla" + i;
                tabla[i].Size = new System.Drawing.Size(85, 120);
                tabla[i].TabIndex = 0 + i;
                tabla[i].SizeMode = PictureBoxSizeMode.StretchImage;
                tabla[i].TabStop = false;
                tabla[i].Image = Image.FromFile(@"cartas\" + (cartas[i])+".jpg");
                this.Controls.Add(tabla[i]);
                c++;
                if (c== 5) ;
                r++;
                c = 0;
            }
        }

       
        

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
