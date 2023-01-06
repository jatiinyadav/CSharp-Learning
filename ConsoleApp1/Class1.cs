using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {

        int TutorialId;
        string TutorialName = "Default";

        private void SetTutorial(int id, String name)
        {
            TutorialId = id;
            TutorialName = name;
        }

        public String GetName()
        {
            return TutorialName;
        }

        public int GetIde()
        {
            return TutorialId;
        }

        static void Main(string[] args)
        {
            Class1 cls = new Class1();
            Console.WriteLine(cls.GetName());
            cls.SetTutorial(2, "New Tutorial");
            cls.SetTutorial(3, "New Exams");
        }
    }
}
