using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14 {
    public class EntradaController:IEntradaController {

        private IEntradaService entradaService;
        private IEntradaConverter entradaConverter;

        public EntradaController(IEntradaService _entradaService, IEntradaConverter _entradaConverter) {
            this.entradaService = _entradaService;
            this.entradaConverter = _entradaConverter;
        }

        public void Create(EntradaDTO entradaDTO) {
            Entrada entrada = entradaConverter.DTOToEntity(entradaDTO);
            entradaService.Create(entrada);
        }

        public void Delete(long id) {
            entradaService.Delete(id);
        }

        public EntradaDTO Read(long id) {
            Entrada entrada = entradaService.Read(id);
            EntradaDTO entradaDTO = entradaConverter.EntityToDTO(entrada);
            return entradaDTO;
        }

        public IList<EntradaDTO> ReadAll() {
            IList<EntradaDTO> listaResultado = new List<EntradaDTO>();

            IList<Entrada> listaEntrada = entradaService.ReadAll();
            foreach (Entrada v in listaEntrada) {
                EntradaDTO entradaDTO = entradaConverter.EntityToDTO(v);
                listaResultado.Add(entradaDTO);
            }
            return listaResultado;
        }

        public void Update(EntradaDTO entradaDTO) {
            Entrada entrada = entradaConverter.DTOToEntity(entradaDTO);
            entradaService.Update(entrada);
        }
    }
}
