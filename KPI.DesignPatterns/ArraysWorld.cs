using System;
using System.Collections.Generic;
using System.Text;
using Lab3.Arrays;

namespace KPI.DesignPatterns
{
    class ArraysWorld : World
    {
        private readonly MultidimensionalArray _array;
        public ArraysWorld()
        {
            Console.WriteLine("Type in the dimensions");
            int dimensions;

            try
            {
                dimensions = int.Parse(Console.ReadLine());
                if (dimensions < 1)
                    throw new Exception();
            }
            catch (Exception e)
            {
                WriteError();
                return;
            }

            _array = MultidimensionalArrayCreator.FromDimensions(dimensions);
            _array.InitializeWithRandom();
        }

        protected override void RunIteration()
        {
            _array.InitializeWithRandom();
            Console.WriteLine("Type in commands : sort, inverse, get {i, j, k, ...} (note: the length of all directions is 3), exit");
            string[] commandParts;
            do
            {
                var command = Console.ReadLine();
                commandParts = command.Split(' ');
            } while (ProcessCommand(commandParts));
        }

        private bool ProcessCommand(string[] commandParts)
        {
            switch (commandParts[0])
            {
                case "sort":
                {
                    _array.Sort();
                }
                    break;
                case "inverse":
                {
                    _array.Inverse();
                }
                    break;
                case "get":
                {
                    int[] indexes;
                    try
                    {
                        string[] stringIndexes = new string[commandParts.Length - 1];
                        Array.Copy(commandParts, 1, stringIndexes, 0, stringIndexes.Length);
                        indexes = GetIndexes(stringIndexes);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Sorry, there was an error in your formatting");
                        break;
                    }

                    try
                    {
                        var value = _array.GetValue(indexes);
                        Console.WriteLine(value);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Incorrect dimensions");
                    }
                }
                    break;
                case "exit":
                    return false;
                default:
                    Console.WriteLine("Incorrect command");
                    break;
            }
            return true;
        }

        private int[] GetIndexes(string[] stringIndexes)
        {
            int[] indexes = new int[stringIndexes.Length];
            for (int i = 0; i < stringIndexes.Length; i++)
            {
                indexes[i] = int.Parse(stringIndexes[i]);
            }

            return indexes;
        }

        private void WriteError()
        {
            Console.WriteLine("Sorry, incorrect dimensions");
        }
    }
}
