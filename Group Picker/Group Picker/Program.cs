using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Picker
{
    class Program
    {
        public static Random rng = new Random();
        
        static void Main(string[] args)
        {
            List<string> studentList = new List<string>() {"Andrew", "Andrii", "Juli", "Eugene",
             "Daniel", "Patrick", "Laura", "Brandon E.", "Brandon S", "Sergio", "Nicole", "Michael S", 
             "Michael G", "Tim", "Nate", "Maria", "Linda"};

            PickGroup(studentList, 3);
            
         

            Console.ReadKey();
        }
        /// <summary>
        /// Picks a random student from list, assigns it to new list
        /// </summary>
        /// <param name="studentList">grabs list from Main</param>
        /// <param name="groupSize">intended group size</param>
        static void PickGroup(List<string> studentList , int groupSize)
        {
            List<string> currentGroupList = new List<string>();
            int groupNumber = 1;
            
            while (studentList.Count > 0)
            {
                int i = rng.Next(studentList.Count);
                string currentStudent = studentList[i];
                currentGroupList.Add(currentStudent);
                studentList.RemoveAt(i);
                i++;

                if (currentGroupList.Count() == groupSize || studentList.Count() == 0)
                {
                    Console.WriteLine("GROUP {0}", groupNumber);
                    
                    for (int j = 0; j < currentGroupList.Count; j++)
                    {
                        Console.WriteLine(currentGroupList[j]);
                    }
                    //console.writeline9STRING.JOIN("/N", currentGroupList));
                    currentGroupList.Clear();
                    groupNumber++;
                 
                }
               

                }   
           
        }
    }
}
