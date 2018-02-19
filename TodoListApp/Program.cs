using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList list = new TodoList();
            while (true)
            {
                Console.WriteLine("lūdzu izvēlēties darbību:");
                Console.WriteLine("a - pievienot");
                Console.WriteLine("p - parādīt");
                Console.WriteLine("d - dzēst");
                Console.WriteLine("dv - dzēst visu");
                string usersInput = Console.ReadLine();
                switch (usersInput)
                {
                    case "a":
                        // pievienot jaunu darāmo lietu
                        Console.WriteLine("lūdzu ievadiet darāmo lietu:");
                        string todoTask = Console.ReadLine();
                        list.AddNewTodo(todoTask);
                        break;
                    case "p":
                        // izvadīt visas darāmās lietas uz ekrāna
                        list.ShowAllTodos();
                        break;
                    case "d":
                        // dzēst konkrētu lietu
                        Console.WriteLine("lūdzu ievadi dzēšamo numuru");
                        list.ShowAllTodos();
                        int index = int.Parse(Console.ReadLine());
                        list.DeleteTodo(index - 1);
                        break;
                    case "dv":
                        // lai ātri orientētos pa kodu,
                        // iespējams uzspiest F12 uz funkcijas, lai uzreiz
                        // dotos uz to
                        // pievienot funkciju, kas notīra visu sarakstu
                        list.DeleteAllTodos();
                        break;
                    case "s":
                        // saglabājam saturu failā
                        list.SaveToFile();
                        break;
                    case "l":
                        // implementējam ielādi no faila izmantojot funkciju
                       list.LoadFromFile();
                        break;
                }
            }
        }
    }
}
