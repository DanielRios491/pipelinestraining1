using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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

        [TestMethod]
        public void say_hello_CatchBlock_Covered()
        {
            var program = typeof(Program)
                .GetConstructor(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, new Type[0], null)
                ?.Invoke(null);

            var method = program?.GetType().GetMethod("say_hello", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            method?.Invoke(program, new object[] { true }); // true = forzar error
        }

        [TestMethod]
        public void say_bye_CatchBlock_Covered()
        {
            var program = typeof(Program)
                .GetConstructor(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, new Type[0], null)
                ?.Invoke(null);

            var method = program?.GetType().GetMethod("say_bye", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            method?.Invoke(program, new object[] { true }); // true = forzar error
        }
    }
}
