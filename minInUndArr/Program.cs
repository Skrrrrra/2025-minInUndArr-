using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace minInUndArr
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region
            //путь
            string inputpath = "D:\\solutionsForSpaceApp\\2025\\input.txt";
            string outputpath = "D:\\solutionsForSpaceApp\\2025\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();

            //переменная для обьвления размера массива#1
            string a;
            string secondLine;
            string forMinAndMax;
            using (var readera = new StreamReader(inputpath))
            {
                a = readera.ReadLine();
                secondLine = readera.ReadLine();
                forMinAndMax = readera.ReadLine();

            };
            string[] lineForInt = secondLine.Split(' ');

            int[] minBorder;
            minBorder = new int[Convert.ToInt32(forMinAndMax)];
            int[] maxBorder;
            maxBorder = new int[Convert.ToInt32(forMinAndMax)];
            int[] readyMin;
            readyMin = new int[Convert.ToInt32(a)];
            int[] numbers;
            numbers = new int[Convert.ToInt32(a)];

            int count = 0;
            foreach (var s in lineForInt)
            {
                numbers[count++] = Convert.ToInt32(s);
            }
            string line;
            string[] lineToInt;
            using (var reader = new StreamReader(inputpath))
            {
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();

                for (int i = 0; i < numbers.Length; i++)
                {
                    line = reader.ReadLine();
                    lineToInt = line.Split(' ');
                    minBorder[i] = Convert.ToInt32(lineToInt[0])-1;
                    maxBorder[i] = Convert.ToInt32(lineToInt[1])-1;
                }
            }


            #endregion

            int min = 101;
            for (int i = 0; i < numbers.Length; i++)
            {
                min = minBorder[i];
                for (int j = minBorder[i]; j <= maxBorder[i]; j++)
                {
                    if (minBorder[j] == maxBorder[j])
                    {
                        readyMin[i] = numbers[j];
                    }
                    else if (min >= minBorder[j])
                    {
                        min = numbers[j];
                        readyMin[i] = min;
                        break;


                    }
                    else
                    {
                        readyMin[i] = min;
                    }
                   
                }
            }
            Console.ReadKey();
        }
    }
}
