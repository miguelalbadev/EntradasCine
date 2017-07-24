using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14 {
    public interface IEntradaController {

        void Create(EntradaDTO entradaDTO);
        EntradaDTO Read(long id);
        //EntradaDTO Read(EntradaDTO entradaDTO);
        IList<EntradaDTO> ReadAll();
        void Update(EntradaDTO entradaDTO);
        void Delete(long id);
    }
}
