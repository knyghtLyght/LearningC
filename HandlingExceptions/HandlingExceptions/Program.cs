using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Users\User\Source\Repos\LearningC\Break.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem");
                Console.WriteLine("Make sure the name of the file is correcct");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Make sure the path of the file is correcct");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Code to finialize
                //Setting objects to null
                //Closing database connections
                Console.WriteLine("closing application...");
            }
            Console.ReadLine();
        }
    }
}
