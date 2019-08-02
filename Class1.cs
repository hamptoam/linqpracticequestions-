using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqquestions
{
    public class Questions
    {

        public string input;
     

        List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth, mathematics" };
        List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
        List<string> classGrades = new List<string>()
        {

            "80, 100, 92, 89, 65",
            "93, 81, 78, 84, 69",
            "73, 88, 83, 99, 64",
            "98, 100, 55, 74, 55",

        };

        public Questions()
        {



        }

        public void printThWords()
        {
            var result = from word in words
            where word.Contains("th")
            select word;

            //foreach (var word in words)
            //    Console.Write(word);

            words.Where(w => w.Contains("th"));

            foreach (var word in result)
                Console.Write(word);
        }

        public void returnDupes()
        {
            List<string> distinct = names.Distinct().ToList();
            foreach (string name in distinct)
            {
                Console.WriteLine(name);

            }

        }

        public void GetClassAverage(List<string> classGrades)
        {

            student = string.classGrades;

            //splitting strings into own lists 


              /*  List<string> studentScores = new studentScores();
                    double Average = 0;
                    int numberInClass = 0;
                    foreach (var student in classGrades)
                    {
                classGrades = student.Split(',')
                   .Select
                    */


            public static IList<IList<Task>> Split(IList<T> classGrades)
            {


            }

            foreach (string in classGrades)
            {
                string = classGrades.student;

                int mos = 0;
                var classGrades = student.Split(',')
                                        .Select(mbox => { int.TryParse(mbox, out mos); return mos; });


            }

        }
        public void orderTheLetters()
        {
            Console.WriteLine("Please enter string");
           string input = Console.ReadLine();

            var count = input.Count(x => x == '&');
            var count orderByAsc();

        }
    }
}

