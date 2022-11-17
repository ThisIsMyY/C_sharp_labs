/*
- Сбор инфы о студенческой группе
- 3 массива: одномерный для имен, одномерный для предметов, трехмерный нерегулярный для оценок по каждому предмету каждого студента
- имена и предметы считываются с клавы
- количество оценок и сами оценки - генерируются рандомом
- 7 запросов по собранной инфе
*/
using System;

namespace TP_Lab2
{
    internal class Program
    {
        static void ShowNumberOfStudents(int studentsNumber)
        {
            Console.WriteLine("The group has "+studentsNumber+" students");
        }
        static void ShowNumberOfSubjects(int subjectsNumber)
        {
            Console.WriteLine("The group has " + subjectsNumber + " students");
        }
        static void ShowStudentGrades(int student_id, int studentsNumber, int subjectsNumber, string[] subjects, int[,,] notes)
        {
            for (int i = 0; i < studentsNumber; i++)
            {
                Console.WriteLine();
                Console.Write(subjects[i] + ":  ");
                for (int j = 0; j < subjectsNumber; j++)
                {
                    Console.Write(notes[0, i, j] + "  ");
                }
            }
        }
        static void TotalGradesNumber(int[,,] notes)
        {
            int totalNotesNumber = notes.Length;
            Console.WriteLine("Total number of grades: " + totalNotesNumber);
        }
        static void AmountOfEachGrade(int[,,] notes, int studentsNumber, int subjectsNumber, int notesNumber, Random random)
        {
            int grade_2 = 0;
            int grade_3 = 0;
            int grade_4 = 0;
            int grade_5 = 0;
            int grade_6 = 0;
            int grade_7 = 0;
            int grade_8 = 0;
            int grade_9 = 0;
            int grade_10 = 0;

            for (int stud = 0; stud < studentsNumber; stud++)
            {
                for (int subj = 0; subj < subjectsNumber; subj++)
                {
                    for (int n = 0; n < notesNumber; n++)
                    {
                        switch(notes[stud, subj, n])
                        {
                            case 2:
                                grade_2++;
                                break;
                            case 3:
                                grade_3++;
                                break;
                            case 4:
                                grade_4++;
                                break;
                            case 5:
                                grade_5++;
                                break;
                            case 6:
                                grade_6++;
                                break;
                            case 7:
                                grade_7++;
                                break;
                            case 8:
                                grade_8++;
                                break;
                            case 9:
                                grade_9++;
                                break;
                            case 10:
                                grade_10++;
                                break;
                        }
                    }
                }
            }
            Console.WriteLine("Number of each grades:\n2: " + grade_2 + "\n3: " + grade_3 + "\n4: " + grade_4 + "\n5: " + grade_5 + "\n6: " + grade_6 + "\n7: " + grade_7 + "\n8: " + grade_8 + "\n9: " + grade_9 + "\n10: " + grade_10 + "\n");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number of strudents: ");
            int studentsNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter number of subjects: ");
            int subjectsNumber = int.Parse(Console.ReadLine());

            if(studentsNumber < 5) studentsNumber = 5;
            if(subjectsNumber < 5) subjectsNumber = 5;

            string[] students = new string[studentsNumber];
            string[] subjects = new string[subjectsNumber];

            for (int i = 0; i < studentsNumber; i++)
            {
                Console.Write("students[" + i + "]: ");
                students[i] = Console.ReadLine();
            }

            for (int i = 0; i < subjectsNumber; i++)
            {
                Console.Write("subjects[" + i + "]: ");
                subjects[i] = Console.ReadLine();
            }

            Random random = new Random();
            int notesNumber = random.Next(5, 10);
            Console.WriteLine(notesNumber);

            int[,,] notes = new int[studentsNumber, subjectsNumber, notesNumber];

            for (int stud = 0; stud < studentsNumber; stud++)
            {
                for (int subj = 0; subj < subjectsNumber; subj++)
                {
                    for (int n = 0; n < notesNumber; n++)
                    {
                        notes[stud, subj, n] = random.Next(2, 11);
                    }
                }
            }

            while(true)
            {
                Console.WriteLine("\n1. Show number of students. 2. Show number of subjects. 3. Show student grades. 4.Total grades number. 5. Amount of each grade.");
                Console.Write("Select menu element: ");
                string menuElem = Console.ReadLine();
                switch (menuElem)
                {
                    case "1":
                        ShowNumberOfStudents(studentsNumber);
                        break;

                    case "2":
                        ShowNumberOfSubjects(studentsNumber);
                        break;

                    case "3":
                        for (int i = 0; i < studentsNumber; i++)
                        {
                            Console.Write(i + "." + students[i] + "  ");
                        }
                        Console.Write("\n\nEnter student number: ");
                        int student_id = int.Parse(Console.ReadLine());
                        ShowStudentGrades(student_id, studentsNumber, subjectsNumber, subjects, notes);
                        break;

                    case "4":
                        TotalGradesNumber(notes);
                        break;

                    case "5":
                        AmountOfEachGrade(notes, studentsNumber, subjectsNumber, notesNumber, random);
                        break;

                    default:
                        Console.WriteLine("Wrong value!");
                        break;
                }
                Console.WriteLine("\n\nType \"exit\" for finish the program or just press any key...");
                if(Console.ReadLine() == "exit")
                {
                    break;
                }
            }

            Console.ReadLine();

        }
    }
}
