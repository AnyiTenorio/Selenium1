using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace Selenium1
{
    public class Tests
    {
        //Declaración de la variable a utilizar
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            //Levantar un navegador limpio, nada de nuestros registros
            var options = new EdgeOptions();
            //options.AddArguments("--start-maximized");
            driver = new EdgeDriver(options);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            //Navega en la ruta indicada
            driver.Navigate().GoToUrl("https://www.bing.com");
        }

        [TearDown]
        public void finalizar()
        {
            //Cierra el navegador
            driver.Quit();
        }
    }
}