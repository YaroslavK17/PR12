//***********************************************************
//* Практическая работа № 12                                *
//* Выполнил: Кузин. Я. Н., группа 2ИСПд                    *
//* Задание: составить программу работы линейного алгоритма *
//***********************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Pr12
{
    internal class Program
    {
        static void Main(string[] args)
        {
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Title = "Практическая работа номер 12";
                    Console.WriteLine("Здравствуйте!");
                    Console.WriteLine("Введите строку для вывода по диагонали:");
                    string input = Console.ReadLine();
                    PrintDiagonal(input);
                }
            }
           static void PrintDiagonal(string str)
            {
                try
                {
                    int length = str.Length;
                    char[,] array = new char[length, length];
                    for (int i = 0; i < length; i++)
                    {
                        array[i, i] = str[i];
                    }
                    for (int i = 0; i < length; i++)
                    {
                        PrintDiagonalElement(array, i);
                    }
                    string answer = Console.ReadLine().ToLower();
                }
                catch (IndexOutOfRangeException iOfREx)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Возникла ошибка - {iOfREx.Message}");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Возникла ошибка - {ex.Message}");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
            static void
                PrintDiagonalElement(char[,] array, int index)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(array[index, index]);
                Console.ReadKey();
            }
        }
    }
