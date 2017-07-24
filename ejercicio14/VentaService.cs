using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14 {
    public class VentaService : IVentaService {

        private IVentaRepository ventaRepository;

        public VentaService (IVentaRepository _ventaRepository) {
            this.ventaRepository = _ventaRepository;
        }

        public void Create(Venta venta) {
            ventaRepository.Create(venta);
        }

        public void Delete(long id) {
            ventaRepository.Delete(id);
        }

        public Venta Read(long id) {
            return ventaRepository.Read(id);
        }

        public IList<Venta> ReadAll() {
            return ventaRepository.ReadAll();
        }

        public void Update(Venta venta) {
            ventaRepository.Update(venta);
        }
    }
}
