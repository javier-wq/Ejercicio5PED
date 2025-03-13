using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public class ArbolBinario
    {
        protected NodoArbol NodoRaiz;
        protected int totnodos;

        protected NodoArbol NodoPadre;

        protected NodoArbol NuevoNodo;

        protected Graphics AreaDibujo;
        protected Point Origen;
        protected Color ColorFondo;

        protected FormatoNodo[] formatonodon;

        protected int SeparacH, separacV;
        protected int DiametroNodo;

        protected int cnodo;
        public bool ResaltarNodos;

        private void InicializarCampos()
        {
            NodoRaiz = null;
            totnodos = 0;
            NodoPadre = null;
            ResaltarNodos = false;
        }

        public ArbolBinario()
        {
            InicializarCampos();
        }

        public int TotNodos()
        {
            return totnodos;
        }

        public void PrepararPizarra(Panel controldibujo, FormatoNodo[] formatonodo)
        {
            AreaDibujo = controldibujo.CreateGraphics();
            ColorFondo = controldibujo.BackColor;
            AreaDibujo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            AreaDibujo.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            formatonodon = formatonodo;

            DiametroNodo = formatonodon[0].diametro;

            SeparacH = 80 * DiametroNodo / 100;

            separacV = 3 * DiametroNodo / 2;

            Origen = new Point(controldibujo.Width / 2, DiametroNodo);

        }

        //Métodos para generar el Gráfico del Árbol binario
        protected virtual void DibujarNodo(NodoArbol nodo, FormatoNodo formatoNodo, int tpausa = 0)
        {
            if (!ResaltarNodos)
            {
                tpausa = 0;
                formatoNodo = formatonodon[0];
            }

            Rectangle limits = new Rectangle(
                nodo.posic.X - DiametroNodo / 2,
                nodo.posic.Y - DiametroNodo / 2,
                DiametroNodo, DiametroNodo);

            //dibuja elipse
            AreaDibujo.FillEllipse(formatoNodo.colorFondo, limits); //color fondo
            AreaDibujo.DrawEllipse(formatoNodo.lapiz, limits);

            //escribe valor del nodo
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;

            AreaDibujo.DrawString(nodo.valor.ToString(), formatoNodo.fuente, formatoNodo.colorfuente, nodo.posic.X, nodo.posic.Y, formato);

            Thread.Sleep(tpausa);
        }

        protected void CoordenadasNodo(ref NodoArbol nodo, ref int xpos)
        {
            if (nodo == null)
                return; //termine recursividad

            //recorre in-orden a nodos (corre desde derecha a izquierda)
            CoordenadasNodo(ref nodo.nodoDer, ref xpos);

            //determina coordenadas del nodo raíz de este subárbol
            nodo.posic.X = xpos;
            nodo.posic.Y = Origen.Y + nodo.nivel * separacV;

            xpos -= SeparacH; //actualiza coordenada X del prox. nodo

            //recorre hasta último nodo a izquierda
            CoordenadasNodo(ref nodo.nodoIzq, ref xpos);
        }

        protected void CalcularPosicNodos()
        {
            int Xlim = Origen.X + (totnodos * SeparacH) / 2;

            //Calcula posiciones para ubicar a nodos
            if (NodoRaiz != null)
                //determina coordenadas (x,y) de cada nodo a graficar
                CoordenadasNodo(ref NodoRaiz, ref Xlim);
        }

        protected void VerLineas(NodoArbol nodopadre)
        {
            //recorre arbol en pares, para dibujar la linea que representa su enlace
            if (nodopadre != null)
            {
                if (nodopadre.nodoDer != null)
                {
                    AreaDibujo.DrawLine(formatonodon[0].lapiz, nodopadre.posic, nodopadre.nodoDer.posic);

                    VerLineas(nodopadre.nodoDer);
                }

                if (nodopadre.nodoIzq != null)
                {
                    AreaDibujo.DrawLine(formatonodon[0].lapiz, nodopadre.posic, nodopadre.nodoIzq.posic);

                    VerLineas(nodopadre.nodoIzq);
                }
            }
        }

        protected void VerNodos(NodoArbol nodo, char tiponodo)
        {
            if (nodo != null)
            {
                nodo.tiponodo = tiponodo;

                DibujarNodo(nodo, formatonodon[0]);

                VerNodos(nodo.nodoIzq, 'i');
                VerNodos(nodo.nodoDer, 'd');
            }
        }

        public virtual void VerArbol()
        {
            if (AreaDibujo != null)
            {
                AreaDibujo.Clear(ColorFondo);
                CalcularPosicNodos();
                VerLineas(NodoRaiz);
                VerNodos(NodoRaiz, 'r');
            }
        }

        private NodoArbol Buscar(NodoArbol nodo, int valorbuscar)
        {
            if (nodo == null) return null;

            DibujarNodo(nodo, formatonodon[2], 500);
            DibujarNodo(nodo, formatonodon[0]);

            if (valorbuscar == nodo.valor)
            {
                DibujarNodo(nodo, formatonodon[1], 500);
                DibujarNodo(nodo, formatonodon[0]);

                return nodo;
            }
            else
                if (valorbuscar > nodo.valor)
                return Buscar(nodo.nodoDer, valorbuscar);
            else
                return Buscar(nodo.nodoIzq, valorbuscar);
        }

        public bool ExisteNodo(int valorbuscar)
        {
            bool res = false;
            NodoArbol nodotemp;
            if (NodoRaiz == null)
                return false;
            else
                nodotemp = Buscar(NodoRaiz, valorbuscar);

            if (nodotemp != null)
                res = true;

            return res;
        }

        protected bool InsertarValor(ref NodoArbol raiz, int valor, int nivel)
        {
            if (raiz == null)
            {
                raiz = new NodoArbol(valor, nivel, null, null);
                totnodos++;
                NuevoNodo = raiz;
                return true;
            }
            else
                if (valor < raiz.valor)
                return InsertarValor(ref raiz.nodoIzq, valor, nivel + 1);
            else
                    if (valor > raiz.valor)
                return InsertarValor(ref raiz.nodoDer, valor, nivel + 1);

            return false;
        }

        public virtual bool InsertarValor(int valornodo)
        {
            bool res = false;

            if (valornodo > 0 && valornodo < 100)
            {
                NuevoNodo = Buscar(NodoRaiz, valornodo);
                if (NuevoNodo == null)
                {
                    InsertarValor(ref NodoRaiz, valornodo, 0);
                    VerArbol();

                    DibujarNodo(NuevoNodo, formatonodon[4], 500);
                    DibujarNodo(NuevoNodo, formatonodon[0]);
                    res = true;
                }
            }
            return res;
        }

        protected void BorrarNodoHoja(ref NodoArbol Hoja)
        {
            DibujarNodo(Hoja, formatonodon[3], 2000);
            totnodos--;

            Hoja = null;
        }

        private void BorrarNodo(int valor, ref NodoArbol raiz)
        {
            NodoArbol nodotemp;

            if (raiz == null)
                return;

            if (!raiz.EsHoja())
            {
                NodoPadre = raiz;
            }

            if (valor < raiz.valor)
                BorrarNodo(valor, ref raiz.nodoIzq);
            else
                if (valor > raiz.valor)
                BorrarNodo(valor, ref raiz.nodoDer);
            else
            {
                DibujarNodo(raiz, formatonodon[2], 2000);

                if (raiz.EsHoja())
                {
                    BorrarNodoHoja(ref raiz);
                    return;
                }

                if (raiz.nodoIzq != null)
                {
                    nodotemp = raiz.Antecesor();
                    DibujarNodo(nodotemp, formatonodon[1], 2000);
                    raiz.valor = nodotemp.valor;

                    DibujarNodo(raiz, formatonodon[0], 2000);

                    BorrarNodo(raiz.valor, ref raiz.nodoIzq);
                }
                else
                {
                    nodotemp = raiz.Sucesor();
                    DibujarNodo(nodotemp, formatonodon[1], 2000);

                    raiz.valor = nodotemp.valor;

                    DibujarNodo(raiz, formatonodon[0], 2000);

                    BorrarNodo(raiz.valor, ref raiz.nodoDer);
                }
            }
        }

        public virtual bool BorrarValor(int valor)
        {
            bool res = false;

            int totalinic = totnodos;

            if (totnodos > 0)
                BorrarNodo(valor, ref NodoRaiz);

            if (totnodos < totalinic)
            {
                res = true;
                VerArbol();
            }
            return res;
        }

        private void VerVisitado(NodoArbol raiz)
        {
            cnodo++;
            if (ResaltarNodos)
            {
                AreaDibujo.DrawString(raiz.valor.ToString(), formatonodon[0].fuente, formatonodon[0].colorfuente, 20, 20 + cnodo * 20);
                DibujarNodo(raiz, formatonodon[1], 2000);
                DibujarNodo(raiz, formatonodon[0]);
            }
        }

        private string Recorrer(NodoArbol raiz, int tiporecorrido)
        {
            string resul = "";
            DibujarNodo(raiz, formatonodon[2], 2000);

            switch (tiporecorrido)
            {
                case 1:
                    if (raiz.nodoIzq != null)
                        resul = Recorrer(raiz.nodoIzq, 1);

                    resul += raiz.valor.ToString() + ",";
                    VerVisitado(raiz);

                    if (raiz.nodoDer != null)
                        resul += Recorrer(raiz.nodoDer, 1);
                    break;
                case 2: // pre-orden
                    break;
                case 3: // pos-orden
                    break;
            }
            return resul;
        }

        public string[] RecorridoNodos(int tiporecorrido)
        {
            string resultado;
            string[] valores;

            if (NodoRaiz == null)
                valores = new string[1] { "Arbol vacio" };
            else
            {
                if (ResaltarNodos)
                    AreaDibujo.DrawString("Nodos del recorrido elegido:", formatonodon[0].fuente, formatonodon[0].colorfuente, 20, 20);
                cnodo = 0;
                resultado = Recorrer(NodoRaiz, tiporecorrido);
                resultado = resultado.TrimEnd(',');
                valores = resultado.Split(',');

                VerArbol();
            }
            return valores;
        }

        public virtual void SalvarABB(string urlArchivo)
        {
            try
            {
                // Crear el archivo en la ruta especificada
                using (StreamWriter writer = new StreamWriter(urlArchivo))
                {
                    // Realizar un recorrido in-orden para obtener los valores de los nodos
                    string valores = Recorrer(NodoRaiz, 1); // 1 para in-orden
                    writer.Write(valores);
                }

                // Confirmar al usuario que se creó una copia de respaldo
                MessageBox.Show("Copia de respaldo del ABB creada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public virtual bool CargarABB(string urlArchivo)
        {
            try
            {
                // Verificar si el archivo existe
                if (!File.Exists(urlArchivo))
                {
                    MessageBox.Show("El archivo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Vaciar el contenido actual del árbol
                NodoRaiz = null;
                totnodos = 0;

                // Leer los valores del archivo
                using (StreamReader reader = new StreamReader(urlArchivo))
                {
                    string contenido = reader.ReadToEnd();
                    string[] valores = contenido.Split(',');

                    // Insertar los valores en el ABB
                    foreach (string valor in valores)
                    {
                        if (int.TryParse(valor, out int valorNodo))
                        {
                            InsertarValor(valorNodo);
                        }
                    }
                }

                // Mostrar el nuevo contenido del ABB en pantalla
                VerArbol();

                // Confirmar que la carga fue exitosa
                MessageBox.Show("Datos cargados exitosamente desde el archivo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }

}
