using System;

namespace FulCrumExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PreDefined("d456", "123bad456"));
            Console.WriteLine(CustomCompare("d456", "123bad456"));
            Console.ReadKey();
        }

        static bool PreDefined(string a, string b)
        {
            bool ret = false;
            if (b.IndexOf(a) >= 0)
                ret = true;

            return ret;
        }
             
        static bool CustomCompare(string a, string b)
        {
            bool ret = false;
            
            //Console.WriteLine($"Base string: {b} <<<>>> To Search : {a}");

            if (a.Length > 0 && b.Length > 0)
            {
                string tosearch = string.Empty;
                // continue
                for (var x = 0; x < b.Length; x++)
                {
                    int lengthOfA = a.Length;//we already got the first letter
                    //Console.WriteLine($"Len of A : {lengthOfA} \n Current Index : {x}");
                    //Console.WriteLine("*************");
                    tosearch += b[x];

                    int i = 0;
                    if (lengthOfA > 1)
                    {
                        int ctr = a.Length - 1;
                        while (ctr < CounterCompare(lengthOfA))
                        {
                            //Console.WriteLine($"Len of a : {lengthOfA} >>>> ctr : {ctr}");
                            if (ctr == (lengthOfA - 1))
                                i = x + 1;

                            //Console.WriteLine($"Value of i : {i}");
                            try
                            {
                                tosearch += b[i];
                                //Console.WriteLine($"ToSearchInit : {tosearch}");
                            }
                            catch
                            {

                            }
                            i++;
                            ctr++;
                        }
                    }
                   

                    if (a == tosearch)
                        return true;
                    //Console.WriteLine("final: " + tosearch);
                    tosearch = string.Empty;
                }
            }
            if (a.Length == 0 && b.Length == 0)
                ret = true;


            return ret;
        }
        static int CounterCompare(int a)
        {
            int ret = a;
            if (a == 3)
                ret++;
            else if (a > 3)
            {
                ret = a + 2;
            }

            return ret;
        }
    }
}
