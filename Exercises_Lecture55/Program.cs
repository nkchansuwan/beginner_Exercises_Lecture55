using System;
using System.Collections.Generic;

namespace Exercises_Lecture55
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();
        }

        public static void Exercise1()
        {
            var names = new List<string>();

            while (true)
            {
                Console.Write("Enter people name like your post (exit press enter): ");
                var name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    break;
                }
                names.Add(name);
            }

            var count = names.Count;
            var like = " like your post.";
            switch (count)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine(names[0] + like);
                    break;
                case 2:
                    Console.WriteLine(string.Format("{0},{1}{2}", names[0], names[1], like));
                    break;
                default:
                    Console.WriteLine(string.Format("{0},{1} and {2} other{3}", names[0], names[1], names.Count - 2, like));
                    break;
            }
        }

        public static void Exercise2()
        {
            Console.Write("Enter your name :");
            var name = Console.ReadLine();
            var charArray = name.ToCharArray();

            Array.Reverse(charArray);

            var reverseName = "";
            foreach (var item in charArray)
            {
                reverseName += item;
            }
            Console.WriteLine(reverseName);
        }

        public static void Exercise3()
        {
            var lists = new List<int>();
            while (lists.Count < 5)
            {
                Console.Write("Enter number :");
                var number = Convert.ToInt32(Console.ReadLine());

                if (!lists.Contains(number))
                    lists.Add(number);
                else
                {
                    Console.Write("Number is same. Enter number again.");
                    continue;
                }

                lists.Sort();

            }
            WriteLineListInt(lists, lists.Count);
        }

        public static void Exercise4()
        {
            var lists = new List<int>();
            while (true)
            {
                Console.Write("Enter number (exit type Quit):");
                var value = Console.ReadLine();
                if (value.ToLower() == "quit")
                    break;

                var number = Convert.ToInt32(value);

                if (!lists.Contains(number))
                    lists.Add(number);

                lists.Sort();
            }
            WriteLineListInt(lists, lists.Count);

        }

        public static void Exercise5()
        {
            while (true)
            {
                Console.Write("Enter the number : ");
                var st = Console.ReadLine();
                var stArr = st.Split(',');
                if (stArr.Length < 5)
                {
                    Console.Write("Enter new numbers");
                    continue;
                }
                else
                {
                    var lists = new List<int>();
                    foreach (var item in stArr)
                    {
                        lists.Add(Convert.ToInt32(item));
                    }
                    lists.Sort();
                    WriteLineListInt(lists, 3);
                    break;
                }
            }
        }

        private static void WriteLineListInt(List<int> lists, int listCount)
        {
            var result = "";

            for (int i = 0; i < listCount; i++)
            {
                result += lists[i] + ",";
            }

            result = result.Remove(result.Length - 1);
            Console.WriteLine(result);
        }
    }
}
