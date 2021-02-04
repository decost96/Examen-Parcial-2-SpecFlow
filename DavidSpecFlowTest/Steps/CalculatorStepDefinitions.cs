using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace DavidSpecFlowTest.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        IWebDriver driver = new FirefoxDriver();

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("https://localhost:64659");
        }

        [Given("the name is (.*)")]
        public void GivenTheNameis(string nombre)
        {
            driver.FindElement(By.Name("Nombre")).SendKeys(Keys.Tab);
        }

        [Given("the last name is (.*)")]
        public void GivenTheLastNameIs(string apelldio)
        {
            driver.FindElement(By.Name("Apellido")).SendKeys(Keys.Tab);
        }

        [Given("the cedula is (.*)")]
        public void GivenTheCedulaIs(int cedula)
        {
            driver.FindElement(By.Name("Cedula")).SendKeys(cedula.ToString() + Keys.Tab);
        }

        [Given("the occupation is (.*)")]
        public void GivenTheOccupationIs(string opcupacion)
        {
            driver.FindElement(By.Name("Ocupacion")).SendKeys(Keys.Tab);
        }

        [Given("the Workplace is (.*)")]
        public void GivenTheWorkPlaceIs(string lugarTRabajo)
        {
            driver.FindElement(By.Name("LugarTrabajo")).SendKeys(Keys.Tab);
        }

        [Given("the schedule is (.*)")]
        public void GivenTheScheduleIs(string horario)
        {
            driver.FindElement(By.Name("Horario")).SendKeys(Keys.Tab);
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            driver.FindElement(By.Name("construir")).Click();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(string esperado)
        {
            var respuesta = driver.FindElement(By.Name("respuesta")).Text;
            Assert.AreEqual(esperado, respuesta);
        }
    }
}
