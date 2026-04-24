using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var schedule = Console.ReadLine()
            .Split(", ")
            .ToList();

        string command;
        while ((command = Console.ReadLine()) != "course start")
        {
            var parts = command.Split(":");

            if (parts[0] == "Add")
            {
                string lesson = parts[1];
                if (!schedule.Contains(lesson))
                    schedule.Add(lesson);
            }
            else if (parts[0] == "Insert")
            {
                string lesson = parts[1];
                int index = int.Parse(parts[2]);
                if (!schedule.Contains(lesson))
                    schedule.Insert(index, lesson);
            }
            else if (parts[0] == "Remove")
            {
                string lesson = parts[1];
                int idx = schedule.IndexOf(lesson);
                if (idx != -1)
                {
                    schedule.RemoveAt(idx);
                    // Remove exercise if it follows
                    if (idx < schedule.Count && schedule[idx] == lesson + "-Exercise")
                        schedule.RemoveAt(idx);
                }
            }
            else if (parts[0] == "Swap")
            {
                string lesson1 = parts[1];
                string lesson2 = parts[2];
                int idx1 = schedule.IndexOf(lesson1);
                int idx2 = schedule.IndexOf(lesson2);

                if (idx1 != -1 && idx2 != -1)
                {
                    schedule[idx1] = lesson2;
                    schedule[idx2] = lesson1;

                    // Swap exercises too
                    string ex1 = lesson1 + "-Exercise";
                    string ex2 = lesson2 + "-Exercise";
                    bool hasEx1 = idx1 + 1 < schedule.Count && schedule[idx1 + 1] == ex2;
                    bool hasEx2 = idx2 + 1 < schedule.Count && schedule[idx2 + 1] == ex1;

                    if (hasEx1 && hasEx2)
                    {
                        schedule[idx1 + 1] = ex1;
                        schedule[idx2 + 1] = ex2;
                    }
                    else if (hasEx1)
                    {
                        schedule[idx1 + 1] = ex1;
                        schedule.Insert(idx2 + 1, ex2);
                        // Remove ex1 from old position (now shifted)
                        // Already replaced above, but ex2 was at idx1+1
                        // Actually need to reconsider — see note below
                    }
                    else if (hasEx2)
                    {
                        schedule[idx2 + 1] = ex2;
                        schedule.Insert(idx1 + 1, ex1);
                    }
                }
            }
            else if (parts[0] == "Exercise")
            {
                string lesson = parts[1];
                string exercise = lesson + "-Exercise";
                int idx = schedule.IndexOf(lesson);

                if (idx != -1)
                {
                    // Lesson exists — add exercise after it if not already there
                    bool exerciseAlreadyExists = idx + 1 < schedule.Count && schedule[idx + 1] == exercise;
                    if (!exerciseAlreadyExists)
                        schedule.Insert(idx + 1, exercise);
                }
                else
                {
                    // Lesson doesn't exist — add lesson then exercise at end
                    schedule.Add(lesson);
                    schedule.Add(exercise);
                }
            }
        }

        for (int i = 0; i < schedule.Count; i++)
            Console.WriteLine($"{i + 1}.{schedule[i]}");
    }
}