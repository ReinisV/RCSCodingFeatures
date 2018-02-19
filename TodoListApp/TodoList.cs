using System.Collections.Generic;
using System;

namespace TodoListApp
{

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
                Console.WriteLine("your todo list entry is " + todoEntries[i]);
            }
            
        }
    }
}
