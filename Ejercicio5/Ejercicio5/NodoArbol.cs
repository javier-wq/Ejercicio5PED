using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Ejercicio5
{
    public struct FormatoNodo
    {
        public int diametro;

        public Pen lapiz;

        public Brush colorFondo;

        public Font fuente;
        public Font fuentep;


        public Brush colorfuente;
        public Brush colorfuentep;

        public StringFormat alineac;
        public Rectangle cuadro;
    }


    public class NodoArbol
    {
        public NodoArbol nodoIzq;
        public NodoArbol nodoDer;

        public int valor;
        public int nivel;
        public int FB;

        public Point posic;
        public char tiponodo;

        public NodoArbol(int valornodo, int nivel, NodoArbol hijoizq, NodoArbol hijoder)
        {
            this.valor = valornodo;
            this.nodoIzq = hijoizq;
            this.nodoDer = hijoder;
            this.nivel = nivel;
            FB = 0; 
            posic = new Point(0, 0);
        }

        public bool EsHoja()
        {
            if (nodoIzq == null && nodoDer == null)
                return true;
            return false;
        }

        public int AlturaSubArbol()
        {
            int maxNizq = 0, maxNder = 0;

            if (this.EsHoja())
                return 1 + nivel;
            if(this.nodoIzq != null)
                maxNizq = nodoIzq.AlturaSubArbol();
            if(this.nodoDer != null)
                maxNder = nodoDer.AlturaSubArbol();

            return Math.Max(maxNizq, maxNder);
        }

        public NodoArbol Antecesor()
        {
            NodoArbol Ant = this.nodoIzq;
            if(Ant != null)
                while(Ant.nodoDer != null)
                    Ant = Ant.nodoDer;

            return Ant;
        }

        public NodoArbol Sucesor()
        {
            NodoArbol Sig = this.nodoDer;
            if(Sig != null)
                while (Sig.nodoIzq != null)
                    Sig = Sig.nodoDer;

            return Sig;
        }
    }
}
