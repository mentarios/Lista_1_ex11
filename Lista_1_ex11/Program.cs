using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string res;
            Console.WriteLine("ele é mamífero?");
            res = Console.ReadLine();
            if (res == "sim")
            {
                Console.WriteLine("ele é quadrupíde?");
                res = Console.ReadLine();
                if (res == "sim")
                {
                    Console.WriteLine("ele é carnívoro?");
                    res = Console.ReadLine();
                    if (res == "sim")
                    {
                        Console.WriteLine("seu animal é leão");
                    }
                    else
                    {
                        Console.WriteLine("seu animal é cavalo");
                    }
                }
                else
                {
                    Console.WriteLine("ele é bípede?");
                    res = Console.ReadLine();
                    if (res == "sim")
                    {
                        Console.WriteLine("ele é onívoro?");
                        res = Console.ReadLine();
                        if (res == "sim")
                        {
                            Console.WriteLine("seu animal é homem");
                        }
                        else
                        {
                            Console.WriteLine("seu animal é macaco");
                        }
                    }
                    else
                    {
                        Console.WriteLine("seu animal é voador?");
                        res = Console.ReadLine();
                        if (res == "sim")
                        {
                            Console.WriteLine("seu animal é morcego");
                        }
                        else
                        {
                            Console.WriteLine("seu animal é aquatico?");
                            res = Console.ReadLine();
                            if (res == "sim")
                            {
                                Console.WriteLine("seu animal é baleia");
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("seu animal é uma ave?");
                res =Console.ReadLine();
                if(res == "sim")
                {
                    Console.WriteLine("seu animal é terrestre");
                   
                    res = Console.ReadLine();
                    if (res== "sim")
                    {
                        Console.WriteLine("seu animal é avestruz");
                    }
                    else
                    {
                        Console.WriteLine("seu animal é do gelo?");
                        res = Console.ReadLine();
                        if(res == "sim")
                        {
                            Console.WriteLine("seu animal é pinguim");
                        }
                        else
                        {
                            Console.WriteLine("seu animal é uma rapina?");
                            res = Console.ReadLine();
                            if(res == "sim")
                            {
                                Console.WriteLine("seu animal é águia");
                            }
                            else
                            {
                                Console.WriteLine("seu animal aquatico?");
                                res = Console.ReadLine();
                                if( res == "sim")
                                {
                                    Console.WriteLine("seu animal é pato");
                                }
                            }
                        }
                    }
                }
                else{
                    Console.WriteLine("seu animal é um réptil?");
                    res = Console.ReadLine();
                    if(res == "sim")
                    {
                        Console.WriteLine("seu animal é lento?");
                        res = Console.ReadLine();
                        if(res == "sim")
                        {
                            Console.WriteLine("seu animal é tartaruga");
                        }
                        else
                        {
                            Console.WriteLine("seu animal tem patas?");
                            res = Console.ReadLine();
                            if(res == "sim")
                            {
                                Console.WriteLine("seu animal é crocodilo");
                            }
                            else{
                                Console.WriteLine("seu animal é cobra");
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
