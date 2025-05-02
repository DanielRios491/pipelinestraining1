using System;

namespace myApp
{
    public class Program
    {
        public static void Main()
        {
            Program helloApp = new();
            Console.WriteLine(helloApp.ToString());
        }

        private Program() {
            this.say_hello();
            this.say_bye();
        }

        private void say_hello()
        {
            try{
                Console.WriteLine(Figgle.FiggleFonts.Standard.Render("Hello, World!"));
                //Console.WriteLine("The current time is " + DateTime.Now);
                //Console.WriteLine(result);
            }catch (Exception ex){
                Console.Error.WriteLine(ex.Message);
            }
        }

        private void say_bye()
        {
            try{
                Console.WriteLine(Figgle.FiggleFonts.Standard.Render("Bye, World!"));
                //Console.WriteLine("The current time is " + DateTime.Now);
                //Console.WriteLine(result);
            }catch (Exception ex){
                Console.Error.WriteLine(ex.Message);
            }
        }

    }
}
