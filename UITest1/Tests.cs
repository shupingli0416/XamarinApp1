using System;
using System.IO;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
{
    [TestFixture(Platform.Android)]
  //  [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
           //AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            //app.Screenshot("Welcome screen.");

           // Assert.IsTrue(results.Any());
           app.WaitForElement(c=>c.Marked("Learn more"));
           app.Tap(c => c.Marked("Learn more"));
            //Thread.Sleep(2000);
            //app.Back();
            
        }
        
    }
}
