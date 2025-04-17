using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDoble {
    internal class LEDoble {
        Nodo Primero { get; set; }
        Nodo Ultimo { get; set; }

        //agrega un valor al inicio de LE Doble
        public void AgregaPrimero(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (this.Primero == null)
            {
                this.Primero = nuevo;
                this.Ultimo = nuevo;
            }
            else
            {
                Nodo prim = this.Primero;
                nuevo.Sig = prim;
                nuevo.Ant = null;
                nuevo.Sig = prim;
                this.Primero = nuevo;
            }
        }

        //agrega un valor al final de LE Doble
        public void AgregaFinal(int valor) 
        {
            Nodo final = new Nodo(valor);
            if (this.Primero == null)
            {
                this.Primero = final;
                this.Ultimo = final;
            }
            else
            {
                this.Ultimo.Sig = final;
                final.Ant = this.Ultimo;
                this.Ultimo = final;
            }
        }

        //ve valores separados por comas de la LEDoble
        public override string ToString() 
        {
            string listaVag = "";
            Nodo tmp = this.Primero;
            while (tmp != null)
            {
                listaVag += tmp.Dato + ", ";
                tmp = tmp.Sig;
            }
            return listaVag;
        }

        public int Largo()
        {
            if (this.Primero == null)
            {
                return 0;
            }
            else
            {
                int cant = 0;
                Nodo tmp = this.Primero;
                while (tmp != null)
                {
                    cant++;
                    tmp = tmp.Sig;
                }
                return cant;
            }
        }

        public int GetValor(int pos)
        {
            int indice = 0;
            Nodo tmp = this.Primero;
            while (tmp != null)
            {
                if (indice == pos)
                {
                    return tmp.Dato;
                }
                indice++;
                tmp = tmp.Sig;
            }
            return int.MinValue;
        }
        public void EliminarPrimero()
        {
            if (this.Primero == null) 
            {
                return ;
            }
            else if (this.Primero == this.Ultimo)
            {
                this.Primero = null;
                this.Ultimo = null;
            }
            else
            {
                this.Primero = this.Primero.Sig;
                this.Primero.Ant = null;
            }
        }
        public void EliminarUltimo()
        {
            if (this.Ultimo == null)
            {
                return ;
            }
            else if (this.Primero == this.Ultimo)
            {
                this.Primero = null;
                this.Ultimo = null;
            }
            else
            {
                Nodo actual = this.Primero;
                while (actual.Sig != this.Ultimo) 
                {
                    actual = actual.Sig;
                }
                actual.Sig = null;
                this.Ultimo = actual;
            }
        }
        public string VerUltimoAlPrimero()
        {
            string listaVag = "";
            Nodo tmp = this.Ultimo;
            while (tmp != null)
            {
                listaVag += tmp.Dato + ", ";
                tmp = tmp.Ant;
            }
            return listaVag;
        }
    }
}
