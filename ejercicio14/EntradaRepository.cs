using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14 {
    public class EntradaRepository : IEntradaRepository {

        public void Create(Entrada entrada) {
            //throw new NotImplementedException();
        }

        public void Delete(long id) {
            //throw new NotImplementedException();
        }

        public Entrada Read(long id) {
            return new Entrada();
            //throw new NotImplementedException();
        }

        public IList<Entrada> ReadAll() {
            IList<Entrada> listaEntradas = new List<Entrada>();
            return listaEntradas;
            //throw new NotImplementedException();
        }

        public void Update(Entrada entrada) {
            //throw new NotImplementedException();
        }
    }
}
