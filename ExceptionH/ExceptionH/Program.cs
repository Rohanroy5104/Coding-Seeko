using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ExceptionH
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"C:\Users\rohan\Documents\note.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                streamReader.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please check if the file {0} exists", ex.FileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
               
                Console.WriteLine("Finally Block");
                    Console.ReadLine();
                }
            }


        }
    }

