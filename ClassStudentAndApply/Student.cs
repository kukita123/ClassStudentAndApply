using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
     * Дефинирайте клас Student с член-данни име, фамилия, среден успех и следните методи:
        - Метод за четене на обект от класа
        - Методи за достъп до тези от член-данните, които използвате в главната функция
        - Метод за извеждане на данните на екрана
        Във  Main декларирайте масив от 20 обекта от класа, въведете n елемента от масива(n<=20; n>=5), 
        средния успех на въведените студенти и изведете имената на тези от тях, чиито успех е по-висок от средния.
    */
namespace ClassStudentAndApply
{
    class Student
    {
        private string firstName;
        private string family;
        private double avMarks;

        public Student()
        {
            Console.WriteLine("Enter studnet's first name:");
            this.FirstName = Console.ReadLine();
            Console.WriteLine("Enter studnet's family:");
            this.Family = Console.ReadLine();
            Console.WriteLine("Enter student's average marks:");
            this.AvMarks = Convert.ToDouble(Console.ReadLine());
        }
        public Student(string firstName, string family, double avMarks)
        {
            this.FirstName = firstName;
            this.Family = family;
            this.AvMarks = avMarks;
        }

        public string FirstName
        {
            get{ return this.firstName; }
            set { this.firstName=value;}
        }
        public string Family
        {
            get { return this.family; }
            set { this.family = value; }
        }
        public double AvMarks
        {
            get { return this.avMarks; }
            set { this.avMarks = value; }
        }
    }
}
