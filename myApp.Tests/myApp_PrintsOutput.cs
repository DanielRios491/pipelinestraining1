using Microsoft.VisualStudio.TestTools.UnitTesting;
using myApp;

namespace myApp.Tests
{
    [TestClass]
    public class myApp_PrintsOutput
    {
        [TestMethod]
        public void IsConsoleOutput_Printed()
        {
            
            // Program _program = new Program();
            // _program.say_hello();
            // _program.say_bye();
         
            Program.Main();
           
        }
    }
}
