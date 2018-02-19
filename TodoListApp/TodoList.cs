using System.Collections.Generic;
using System;

namespace TodoListApp
{
    using System.IO;

    class TodoList
    {
        // šis ir konstruktors, kurš tiek izsaukts kad tiek izveidots
        // objekts, konstruktors nekad neko neatgriež, un vienmēr 
        // saucas tāpat, kā klase
        public TodoList()
        {
            todoEntries = new List<string>();
        }

        List<string> todoEntries;

        public void AddNewTodo(string task)
        {
            // ja vizuālā studija nevar atrast klasi,
            // tad uzspiežam uz klases nosaukuma un
            // piespiežam Ctrl + .
            Console.WriteLine("uzdevums pievienots:" + task);
            todoEntries.Add(task);
        }
        

        public void ShowAllTodos()
        {
            // izgūstam pirmo elementu no saraksta izmantojot indeksatoru
            // skaititajs = skaititajs + 1; IR TAS PATS KAS skaititajs += 1;
            // IR TAS PATS KAS skaititajs++
            // i ir saīsinājums no vārda index, index latviešu valodā nozīmē skaitītājs

            for (int i = 0; i < todoEntries.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + todoEntries[i]);
                Console.WriteLine();
            }
        }

        public void DeleteTodo(int indexOfTodo)
        {
            // neļaut mēģināt izvilkt ierakstu no saraksta, 
            // kura kārtas numurs ir ārpus ierakstu robežām
            if (indexOfTodo >= this.todoEntries.Count)
            {
                // ja sarakstā ir 3 ieraksti, tad pēdējais indekss ir 2
                Console.WriteLine("tāds ieraksts neeksitē");
            }
            else
            {
                todoEntries.RemoveAt(indexOfTodo);
            }
        }

        public void DeleteAllTodos()
        {
            todoEntries.Clear();
        }

        public void SaveToFile()
        {
            // Ctrl + .
            for(int i = 0; i < todoEntries.Count; i++)
            {
                // Append (angļu val) - Pievienot, papildināt
                File.AppendAllText(
                    @"C:\Users\reinis.vesers\Documents\TodoApplicationSettings\todos.txt",
                    todoEntries[i] + "\r\n");
            }
        }

        public void LoadFromFile()
        {
            string[] allLinesFromFile = File.ReadAllLines(@"C:\Users\reinis.vesers\Documents\TodoApplicationSettings\todos.txt");
            foreach (string listEntry in allLinesFromFile)
            {
                todoEntries.Add(listEntry);
            }
        }
    }
}
