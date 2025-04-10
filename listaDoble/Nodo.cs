using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDoble {
    internal class Nodo {
        public int Dato { get; set; }
        public Nodo Sig { get; set; }
        public Nodo Ant { get; set; }

        public Nodo(int dato) {
            Dato = dato;
        }

        public Nodo() {
        }
    }
}
