using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Кирки:
            //Железная - IIISS
            //Каменная - RRRSS
            //Деревянная - TTTSS
            //Лопата:
            //Железная - ISS
            //Каменная - RSS
            //Деревянная - TSS
            // и другие
            Crafts stick = new Crafts();
            Crafts tree = new Crafts();
            Crafts iron = new Crafts();
            Crafts gold = new Crafts();
            Crafts rock = new Crafts();
            Crafts treeShovel = new Crafts();
            Crafts goldShovel = new Crafts();
            Crafts ironShovel = new Crafts();
            Crafts rockShovel = new Crafts();

            Crafts treeSword = new Crafts();
            Crafts goldSword = new Crafts();
            Crafts rockSword = new Crafts();
            Crafts ironSword = new Crafts();

            Crafts treePickaxe = new Crafts();
            Crafts goldPickaxe = new Crafts();
            Crafts rockPickaxe = new Crafts();
            Crafts ironPickaxe = new Crafts();

            Crafts treeAx = new Crafts();
            Crafts goldAx = new Crafts();
            Crafts rockAx = new Crafts();
            Crafts ironAx = new Crafts();
            
            
            Crafts thing = new Crafts();
            treeShovel.Craftes = "TSS";
            goldShovel.Craftes = "GSS";
            ironShovel.Craftes = "ISS";
            rockShovel.Craftes = "RSS";

            treeSword.Craftes = "STT";
            goldSword.Craftes = "SGG";
            rockSword.Craftes = "SRR";
            ironSword.Craftes = "SII";

            treePickaxe.Craftes = "TTTSS";
            goldPickaxe.Craftes = "GGGSS";
            rockPickaxe.Craftes = "RRRSS";
            ironPickaxe.Craftes = "IIISS";

            treeAx.Craftes = "SSTTT";
            goldAx.Craftes = "SSGGG";
            rockAx.Craftes = "SSRRR";
            ironAx.Craftes = "SSIII";

            treeShovel.SortString();
            goldShovel.SortString();
            ironShovel.SortString();
            rockShovel.SortString();

            treeSword.SortString();
            goldSword.SortString();
            ironSword.SortString();
            rockSword.SortString();

            treePickaxe.SortString();
            goldPickaxe.SortString();
            ironPickaxe.SortString();
            rockPickaxe.SortString();

            treeAx.SortString();
            goldAx.SortString();
            ironAx.SortString();
            rockAx.SortString();
            thing.Craftes = "";
            stick.Craftes = "S";
            tree.Craftes = "T";
            gold.Craftes = "G";
            rock.Craftes = "R";
            iron.Craftes = "I";

            ConsoleKeyInfo Symbol;
            string[] numbers = new string[9];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (i + 1).ToString();
            }
            //   Console.SetCursorPosition(20, 21);
            string resource = "";
            do
            {


                Console.WriteLine("Для создания предмета из Minecraft выбирите");
                Console.WriteLine("русурсы нажимая определенные клавиши, и");
                Console.WriteLine("выбирайте для них ячейку на верстаке.");
                Console.WriteLine(" --------------           T) Дерево");
                Console.WriteLine("|{0}   |{1}   |{2}   |          R) Камень", numbers[6], numbers[7], numbers[8]);
                Console.WriteLine("|---------------          S) Палка");
                Console.WriteLine("|{0}   |{1}   |{2}   |          G) Золото", numbers[3], numbers[4], numbers[5]);
                Console.WriteLine("|---------------          I) Железо");
                Console.WriteLine("|{0}   |{1}   |{2}   |" + "      D - очищение верстака", numbers[0], numbers[1], numbers[2]);
                Console.WriteLine(" -------------- ");
                Console.WriteLine("ENTER - создать");
                Console.WriteLine("M  -  посмотреть крафты");
                Symbol = Console.ReadKey();

                Console.Clear();

                if (Symbol.KeyChar == 'T' || Symbol.KeyChar == 't' || Symbol.KeyChar == 'Е' || Symbol.KeyChar == 'е')
                {
                    Console.WriteLine("Выбрано дерево!");
                    resource = "T";
                }
                else if (Symbol.KeyChar == 'R' || Symbol.KeyChar == 'r' || Symbol.KeyChar == 'к' || Symbol.KeyChar == 'К')
                {
                    Console.WriteLine("Выбран камень!");
                    resource = "R";

                }
                else if (Symbol.KeyChar == 'S' || Symbol.KeyChar == 's' || Symbol.KeyChar == 'ы' || Symbol.KeyChar == 'Ы')
                {
                    Console.WriteLine("Выбрана палка!");
                    resource = "S";

                }
                else if (Symbol.KeyChar == 'G' || Symbol.KeyChar == 'g' || Symbol.KeyChar == 'п' || Symbol.KeyChar == 'П')
                {
                    Console.WriteLine("Выбрано золото!");
                    resource = "G";

                }
                else if (Symbol.KeyChar == 'I' || Symbol.KeyChar == 'i' || Symbol.KeyChar == 'ш' || Symbol.KeyChar == 'Ш')
                {
                    Console.WriteLine("Выбрано железо!");
                    resource = "I";
                }

                for (int i = 48; i < 57; i++)
                {

                    if (Symbol.KeyChar == i + 1 && resource != "")
                    {
                        numbers[i - 48] = resource;
                        if (tree == resource)
                        {
                            thing = thing + tree;
                        }
                        else if (stick == resource)
                        {
                            thing = thing + stick;
                        }
                        else if (gold == resource)
                        {
                            thing = thing + gold;
                        }
                        else if(rock == resource)
                        {
                            thing = thing + rock;
                        }
                        else if (iron == resource)
                        {
                            thing = thing + iron;
                        }
                    }


                }

                if (Symbol.KeyChar == 'd' || Symbol.KeyChar == 'D' || Symbol.KeyChar == 'В' || Symbol.KeyChar == 'в')
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = (i + 1).ToString();
                    }
                }
                if (Symbol.KeyChar == 'a')
                {
                    Console.WriteLine(thing.Craftes);
                }
                thing.SortString();
                if (Symbol.KeyChar == 13)
                {
                    Console.WriteLine("Создано: " );
                    if (thing == treeShovel)
                    {
                        if (numbers[7] == "T" && numbers[4] == "S" && numbers[1] == "S")
                        {
                            Console.WriteLine("Деревянная Лопата");

                        }
                        
                    }
                    else if (thing == goldShovel)
                    {
                        if (numbers[7] == "G" && numbers[4] == "S" && numbers[1] == "S")
                        {
                            Console.WriteLine("Золотая Лопата");

                        }
                    
                    }
                    else if(thing == rockShovel)
                    {
                        if (numbers[7] == "R" && numbers[4] == "S" && numbers[1] == "S")
                        {
                            Console.WriteLine("Каменная Лопата");
                        }
                    }
                    else if(thing == ironShovel)
                    {
                        if (numbers[7] == "I" && numbers[4] == "S" && numbers[1] == "S")
                        {
                            Console.WriteLine("Железная Лопата");
                        }
                        else if (numbers[6] == "I" && numbers[3] == "S" && numbers[0] == "S")
                        {
                            Console.WriteLine("Железная Лопата");
                        }
                        else if (numbers[8] == "I" && numbers[5] == "S" && numbers[2] == "S")
                        {
                            Console.WriteLine("Железная Лопата");
                        }
                        
                    }

                    if (thing == treePickaxe)
                    {
                        if(numbers[6]=="T" && numbers[7] == "T" && numbers[8] == "T" && numbers[4] == "S" && numbers[1] =="S")
                        {
                            Console.WriteLine("Деревянная кирка");
                        }
                    }
                    else if (thing == goldPickaxe)
                    {
                        if (numbers[6] == "G" && numbers[7] == "G" && numbers[8] == "G" && numbers[4] == "S" && numbers[1] == "S")
                        {
                            Console.WriteLine("Золотая кирка");
                        }
                    }
                    else if (thing == rockPickaxe)
                    {
                        if (numbers[6] == "R" && numbers[7] == "R" && numbers[8] == "R" && numbers[4] == "S" && numbers[1] == "S")
                        {
                            Console.WriteLine("Каменная кирка");
                        }
                    }
                    else if(thing == ironPickaxe)
                    {
                        if (numbers[6] == "I" && numbers[7] == "I" && numbers[8] == "I" && numbers[4] == "S" && numbers[1] == "S")
                        {
                            Console.WriteLine("Железная кирка");
                        }
                    }
                    if(thing == treeSword)
                    {
                        if (numbers[1] == "S" && numbers[4] == "T" && numbers[7] == "T")
                        {
                            Console.WriteLine("Деревянный меч");
                        }
                    }
                    else if(thing == goldSword)
                    {
                        if (numbers[1] == "S" && numbers[4] == "G" && numbers[7] == "G")
                        {
                            Console.WriteLine("Золотой меч");
                        }
                    }
                    else if(thing == rockSword)
                    {
                        if (numbers[1] == "S" && numbers[4] == "R" && numbers[7] == "R")
                        {
                            Console.WriteLine("Каменный меч");
                        }
                    }
                    else if(thing == ironSword)
                    {
                        if (numbers[1] == "S" && numbers[4] == "I" && numbers[7] == "I")
                        {
                            Console.WriteLine("Железный меч");
                        }
                    }

                    if (thing == treeAx)
                    {
                        if (numbers[1] == "S" && numbers[4] == "S" && numbers[7] == "T" && numbers[8] == "T" && numbers[5] == "T")
                        {
                            Console.WriteLine("Деревянный топор");
                        }
                    }
                    else if (thing == goldAx)
                    {
                        if (numbers[1] == "S" && numbers[4] == "S" && numbers[7] == "G" && numbers[8] == "G" && numbers[5] == "G")
                        {
                            Console.WriteLine("Золотой топор");
                        }
                    }
                    else if (thing == rockAx)
                    {
                        if (numbers[1] == "S" && numbers[4] == "S" && numbers[7] == "R" && numbers[8] == "R" && numbers[5] == "R")
                        {
                            Console.WriteLine("Каменный топор");
                        }
                    }
                    else if (thing == ironAx)
                    {
                        if (numbers[1] == "S" && numbers[4] == "S" && numbers[7] == "I" && numbers[8] == "I" && numbers[5] == "I")
                        {
                            Console.WriteLine("Железный топор");
                        }
                    }
                    else { Console.WriteLine("Ничиго"); }
                    thing.Craftes = "";

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = (i + 1).ToString();
                    }
                }
                if(Symbol.KeyChar == 'm' || Symbol.KeyChar == 'M' || Symbol.KeyChar == 'ь' || Symbol.KeyChar == 'Ь' )
                {
                    Console.SetCursorPosition(2,15);
                    Console.WriteLine("Крафты: ");
                    Console.WriteLine("Деревянная лопата:(аналогично другие лопаты) ");
                    Console.WriteLine(" --------------           T) Дерево");
                    Console.WriteLine("|   |T   |    |           R) Камень");
                    Console.WriteLine("|---------------          S) Палка");
                    Console.WriteLine("|   |S   |    |           G) Золото" );
                    Console.WriteLine("|---------------          I) Железо");
                    Console.WriteLine("|   |S   |    |");
                    Console.WriteLine(" -------------- ");

                    Console.WriteLine("Деревянная кирка(аналогично другие кирки): ");
                    Console.WriteLine(" --------------           T) Дерево");
                    Console.WriteLine("|T  |T   |T   |           R) Камень");
                    Console.WriteLine("|---------------          S) Палка");
                    Console.WriteLine("|   |S   |    |           G) Золото");
                    Console.WriteLine("|---------------          I) Железо");
                    Console.WriteLine("|   |S   |    |");
                    Console.WriteLine(" -------------- ");

                    Console.WriteLine("Деревянный меч(аналогично другие мечи): ");
                    Console.WriteLine(" --------------           T) Дерево");
                    Console.WriteLine("|   |T   |    |           R) Камень");
                    Console.WriteLine("|---------------          S) Палка");
                    Console.WriteLine("|   |T   |    |           G) Золото");
                    Console.WriteLine("|---------------          I) Железо");
                    Console.WriteLine("|   |S   |    |");
                    Console.WriteLine(" -------------- ");

                    Console.WriteLine("Деревянный топор(аналогично другие топоры): ");
                    Console.WriteLine(" --------------           T) Дерево");
                    Console.WriteLine("|   |T   |T   |           R) Камень");
                    Console.WriteLine("|---------------          S) Палка");
                    Console.WriteLine("|   |S   |T   |           G) Золото");
                    Console.WriteLine("|---------------          I) Железо");
                    Console.WriteLine("|   |S   |    |");
                    Console.WriteLine(" -------------- ");
                    Console.SetCursorPosition(0, 0);
                }
                if (Symbol.KeyChar == 27)
                {
                    break;
                }
            } while (true);


            Console.ReadLine();
        }
    }
}
