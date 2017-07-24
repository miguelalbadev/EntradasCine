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
    }
}
