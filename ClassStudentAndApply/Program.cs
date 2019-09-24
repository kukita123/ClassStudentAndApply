using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudentAndApply
{
    /*
     * Дефинирайте клас Student с член-данни име, фамилия, среден успех и следните методи:
        - Метод за четене на обект от класа
        - Методи за достъп до тези от член-данните, които използвате в главната функция
        - Метод за извеждане на данните на екрана
        Във  Main декларирайте масив от 20 обекта от класа, въведете n елемента от масива(n<=20; n>=5), 
        средния успех на въведените студенти и изведете имената на тези от тях, чиито успех е по-висок от средния.
    */
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Enter n: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n < 3 || n > 20);

            //създаване на масив от обекти:
            Student[] students = new Student[n];

            //създаване на всеки един обект в масива чрез използване на конструктора по подразбиране:
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
            }

            //прилагане на setter-и:
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Enter studnet's first name:");
                students[i].FirstName = Console.ReadLine();
                Console.WriteLine("Enter studnet's family:");
                students[i].Family = Console.ReadLine();
                Console.WriteLine("Enter student's average marks:");
                students[i].AvMarks = Convert.ToDouble(Console.ReadLine());
            }

            //прилагане на getter-и:
            double average = 0;
            foreach (var item in students)
            {
                average += item.AvMarks;
            }
            foreach (var item in students)
            {
                if (average/ students.Length < item.AvMarks)
                {
                    Console.WriteLine(item.FirstName + " " +item.Family);
                }
            }            
        }
    }
}
