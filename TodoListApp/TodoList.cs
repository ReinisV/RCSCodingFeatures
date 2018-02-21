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
            todoEntries = new List<TodoListEntry>();
        }

        List<TodoListEntry> todoEntries;
        string pathToTodoFile = @"C:\Users\reinis.vesers\Documents\TodoApplicationSettings\todos.txt";

        public void AddNewTodo(string task)
        {
            // ja vizuālā studija nevar atrast klasi,
            // tad uzspiežam uz klases nosaukuma un
            // piespiežam Ctrl + .
            Console.WriteLine("uzdevums pievienots:" + task);
            // izveidojam jaunu uzdevumu
            TodoListEntry usersTodo = new TodoListEntry();
            // jaunizveidotajam uzdevumam piešķiram nosaukumu, ko ievadījis lietotājis
            usersTodo.Name = task;
            // pievienojam jauno uzdevumu mūsu uzdevumu sarakstam
            todoEntries.Add(usersTodo);
        }
        

        public void ShowAllTodos()
        {
            // izgūstam pirmo elementu no saraksta izmantojot indeksatoru
            // skaititajs = skaititajs + 1; IR TAS PATS KAS skaititajs += 1;
            // IR TAS PATS KAS skaititajs++
            // i ir saīsinājums no vārda index, index latviešu valodā nozīmē skaitītājs

            for (int i = 0; i < todoEntries.Count; i++)
            {
                // izvadām kārtas numuru un uzdevuma nosaukumu (bet bez enter galā)
                Console.Write((i + 1) + ".  " + todoEntries[i].Name);
                // ja uzdevums ir pabeigts (IsCompleted == true)
                if (todoEntries[i].IsCompleted)
                {
                    // tad uzrakstam uz ekrāna "DONE" (bet bez enter)
                    Console.Write(" DONE");
                }

                // nospiežam enter
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
            File.Delete(pathToTodoFile);
            // Ctrl + .
            for(int i = 0; i < todoEntries.Count; i++)
            {
                // Append (angļu val) - Pievienot, papildināt
                string nameOfTodo = todoEntries[i].Name;
                File.AppendAllText(pathToTodoFile, nameOfTodo + "\r\n");
                bool xxxx = todoEntries[i].IsCompleted;
                File.AppendAllText(pathToTodoFile, xxxx + "\r\n");
            }
        }

        public void LoadFromFile()
        {
            // ja funkcija, kas pārbauda vai fails eksistē, atgriež false (tātad neeksistē)
            if (!File.Exists(pathToTodoFile))
            {
                // tad pārtraucam LoadFromFile un atgriežamies atpakaļ
                return;
            }
            
            // citādāk, nolasam faila saturu pa rindām
            string[] allLinesFromFile = File.ReadAllLines(pathToTodoFile);
            
            // pirms saraksta ielādes no faila, to iztīram no vecā satura
            todoEntries.Clear();

            // dodamies cauri sarakstam ar teksta rindām, kas ir ielādētas no faila
            for (var index = 0; index < allLinesFromFile.Length; index += 2)
            {
                string listEntry = allLinesFromFile[index];
                // listEntry mainīgajā ir ierakstīta viena teksta rinda no faila
                // izveidojam jaunu uzdevumu
                TodoListEntry fileTodo = new TodoListEntry();
                // uzdevumam uzdodam par nosaukumu teksta rindu, kas nolasīta no faila
                fileTodo.Name = listEntry;
                // uzdevumam uzdodam par izpildes stāvokli vērtību, kas nolasīta no faila
                fileTodo.IsCompleted = bool.Parse(allLinesFromFile[index + 1]);
                // jaunizveidoto uzdevumu pievienojam kopējo uzdevumu sarakstam
                this.todoEntries.Add(fileTodo);
            }
        }

        public void MarkTodoAsDone(int doneTodoIndex)
        {
            TodoListEntry doneTodo = todoEntries[doneTodoIndex];
            doneTodo.IsCompleted = true;
        }
    }
}
