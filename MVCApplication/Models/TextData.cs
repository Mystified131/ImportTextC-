using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApplication.Models
{
    public class TextData
    {

        static List<string> AllElements = new List<string>();
        static List<string> matches = new List<string>();

        public static List<string> FindAll()
        {
            LoadData();

            // Bonus mission: return a copy
            return AllElements;
        }     

        /**
         * Search all columns for the given term
         */
        public static List<string> FindByValue(string value)
        {

          
            
            LoadData();

            foreach (string row in AllElements)
            {
                string rowtest = row.ToLower();
                string valuetest = value.ToLower();

                if (rowtest.Contains(valuetest))


                    {
                    matches.Add(row);

                }
                
            }

            return matches;
        }


        /*
         * Load and parse data from xml
         */
        private static void LoadData()
        {

            using (StreamReader reader = File.OpenText("Models/EmbedPDF.txt"))
            {
                while (reader.Peek() >= 0)
                {
                    string line = reader.ReadLine();
                    if (line.Length > 0)
                    {
                        AllElements.Add(line);
                    }
                }

            }




        }

    }

}