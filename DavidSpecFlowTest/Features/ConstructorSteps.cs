using System;
using TechTalk.SpecFlow;
using Persona;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DavidSpecFlowTest.Features
{
    [Binding]
    public class ConstructorSteps
    {
        Constructor p = new Constructor();

        [Given(@"el nombre es ""(.*)""")]
        public void DadoElNombreEs(string nombre)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"el apellido es ""(.*)""")]
        public void DadoElApellidoEs(string apellido)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"el numero de cedula ""(.*)""")]
        public void DadoElNumeroDeCedula(int cedula)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"la ocupacion ""(.*)""")]
        public void DadoLaOcupacion(string vendedor)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"el lugar de trabajo ""(.*)""")]
        public void DadoElLugarDeTrabajo(string lugarTRabajo)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"el horario ""(.*)""")]
        public void DadoElHorario(string horario)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"las son variables son unidas")]
        public void CuandoLasSonVariablesSonUnidas()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"deberia notificar ""(.*)""")]
        public void EntoncesDeberiaNotificar(string esperado)
        {
            Assert.AreEqual(esperado, p.Resultado);
        }
    }
}
