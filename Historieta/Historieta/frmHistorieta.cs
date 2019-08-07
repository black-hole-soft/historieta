using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Historieta
{
    public partial class frmHistorieta : Form
    {
        Thread[,] secuence = new Thread[3, 3];
        Historieta[,] cuadro = new Historieta[3,3];

        public frmHistorieta()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Black;
        }
        private void frmHistorieta_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    cuadro[i, j] = new Historieta(i, j);
                    this.Controls.Add(cuadro[i, j].img);
                    secuence[i, j] = new Thread(new ThreadStart(cuadro[i, j].hilo));
                    secuence[i, j].Start();
                }
        }
        private void frmHistorieta_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    secuence[i, j].Abort();
        }
    }
}
