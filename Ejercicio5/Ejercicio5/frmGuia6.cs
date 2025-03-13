using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace Ejercicio5
{
    public partial class frmGuia6 : Form
    {
        ArbolBinario Arbol;
        FormatoNodo[] formatonodo;
        public frmGuia6()
        {
            InitializeComponent();

            cmbTiposRecorrido.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTiposRecorrido.SelectedIndex = 0;

            formatonodo = new FormatoNodo[6];

            formatonodo[0] = new FormatoNodo
            {
                diametro = 40,
                lapiz = new Pen(Color.Black, 1.5f),
                colorFondo = Brushes.White,
                fuente = new Font(FontFamily.GenericSansSerif, 12.0f, FontStyle.Bold),
                fuentep = new Font(FontFamily.GenericSansSerif, 11.5f, FontStyle.Bold),
                colorfuente = Brushes.Blue,
                colorfuentep = Brushes.OrangeRed,
                alineac = new StringFormat()
            };

            formatonodo[0].alineac.Alignment = StringAlignment.Far;

            for (int c = 1; c < formatonodo.Length; c++)
                formatonodo[c] = formatonodo[0];

            formatonodo[1].colorfuente = Brushes.Black;
            formatonodo[1].colorFondo = Brushes.Yellow;

            formatonodo[2].colorfuente = Brushes.Black;
            formatonodo[2].colorFondo = Brushes.LawnGreen;

            formatonodo[3].colorfuente = Brushes.White;
            formatonodo[3].colorFondo = Brushes.Red;

            formatonodo[4].colorfuente = Brushes.White;
            formatonodo[4].colorFondo = Brushes.BlueViolet;

            formatonodo[5].colorfuente = Brushes.Black;
            formatonodo[5].colorFondo = Brushes.Gold;

            panel1.BackColor = this.BackColor;
            panel1.BorderStyle = BorderStyle.FixedSingle;

            Arbol = new ArbolBinario();
            Arbol.PrepararPizarra(panel1, formatonodo);

            Arbol.ResaltarNodos = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Arbol.VerArbol();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            if (Arbol != null)
            {
                Arbol.PrepararPizarra(panel1, formatonodo);
                Arbol.VerArbol();
            }
        }

        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "ABB Files (*.abb)|*.abb|All Files (*.*)|*.*";
            openFileDialog.Title = "Abrir Archivo ABB";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string urlArchivo = openFileDialog.FileName;
                bool cargaExitosa = Arbol.CargarABB(urlArchivo);

                if (!cargaExitosa)
                {
                    MessageBox.Show("No se pudo cargar el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEscribirArchivo_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "ABB Files (*.abb)|*.abb|All Files (*.*)|*.*";
            saveFileDialog.Title = "Guardar Archivo ABB";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string urlArchivo = saveFileDialog.FileName;
                Arbol.SalvarABB(urlArchivo);
            }
        }

        private void btnNuevoNum_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int n))
            {
                if (!Arbol.InsertarValor(n))
                {
                    MessageBox.Show($"valor {n} ya existe en Arbol", "Error de insercion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtValor.Clear();
                txtValor.Focus();
            }
        }

        private void btnBorrarNum_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int n))
            {
                if (Arbol.BorrarValor(n))
                    MessageBox.Show($"Valor {n} fue removido del Arbol", "Operacion exitorsa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"Valor {n} no existe en Arbol", "Error al remover valor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtValor.Clear();
            txtValor.Focus();
        }

        private void btnBuscarNum_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int n))
            {
                if (Arbol.ExisteNodo(n))
                    MessageBox.Show($"Valor {n} fue encontrado en Arbol", "Operacion exitorsa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"Valor {n} NO existe en Arbol", "Error al buscar valor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtValor.Clear();
            txtValor.Focus();
        }

        private void btnRecorrerArbol_Click_1(object sender, EventArgs e)
        {
            string[] valores;
            Arbol.ResaltarNodos = true;

            lstRecorrido.Items.Clear();

            int tiporecorrido = cmbTiposRecorrido.SelectedIndex + 1;

            valores = Arbol.RecorridoNodos(tiporecorrido);

            foreach (string V in valores)
                lstRecorrido.Items.Add(V);
        }
    }
}
