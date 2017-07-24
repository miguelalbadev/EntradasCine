using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejercicio14;
using Microsoft.Practices.Unity;

namespace ejercicio14Test {
    [TestClass]
    public class EntradaControllerIntegracionTest {

        private IEntradaController entradaController;

        [TestInitialize]
        public void Initialize() {
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IEntradaRepository, EntradaRepository>();
            unityContainer.RegisterType<IEntradaService, EntradaService>();
            unityContainer.RegisterType<IEntradaConverter, EntradaConverter>();
            unityContainer.RegisterType<IEntradaController, EntradaController>();

            entradaController = unityContainer.Resolve<IEntradaController>();
        }

        [TestMethod]
        public void CreateMethodEntrada() {

            EntradaDTO entradaDTO = new EntradaDTO();
            entradaController.Create(entradaDTO);
        }

        [TestMethod]
        public void LeeMethodEntrada() {

            EntradaDTO entradaDTO = new EntradaDTO();
            entradaController.Read(entradaDTO.Id);
        }

        [TestMethod]
        public void LeeAllMethodEntrada() {

            EntradaDTO entradaDTO = new EntradaDTO();
            entradaController.ReadAll();
        }

        [TestMethod]
        public void DeleteMethodEntrada() {

            EntradaDTO entradaDTO = new EntradaDTO();
            entradaController.Delete(entradaDTO.Id);
        }

        [TestMethod]
        public void UpdateMethodEntrada() {

            EntradaDTO entradaDTO = new EntradaDTO();
            entradaController.Update(entradaDTO);
        }
    }
}
