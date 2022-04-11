using System;
using ConsoleApp.Models;
using ConsoleApp.Exceptions;
using ConsoleApp.Helpers;
using Indexer1;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            #region Inventory
            Bullet arBullet = new Bullet(7.62, "Carbine");
            Bullet smgBullet = new Bullet(9.19, "Parabellum");
            Bullet pistolBullet = new Bullet(.45, "ACP");
            Bullet snipeBullet = new Bullet(.338, "Lapua Magnum");
            Indexer<dynamic> chosenGun = new Indexer<dynamic>();
            Indexer<Gun> guns = new Indexer<Gun>();
            Pistol glock = new Pistol("Glock", pistolBullet);
            Pistol revolver = new Pistol("Revolver", pistolBullet);
            AssaultRifle m4 = new AssaultRifle("M4", arBullet);
            AssaultRifle ak47 = new AssaultRifle("Ak-47", arBullet);
            Smg uzi = new Smg("Uzi", smgBullet);
            Smg mp5 = new Smg("Heckle & Koch MP5", smgBullet);
            Sniper barret = new Sniper("Barret M90", snipeBullet);
            Sniper dragunov = new Sniper("Dragunov SVD", snipeBullet);
            guns.Add(glock);
            guns.Add(revolver);
            guns.Add(m4);
            guns.Add(ak47);
            guns.Add(uzi);
            guns.Add(mp5);
            guns.Add(barret);
            guns.Add(dragunov);
            #endregion
        Menu:
            Console.WriteLine(@"               
               .__                                              
__  _  __ ____ |  |   ____  ____   _____   ____                 
\ \/ \/ // __ \|  | _/ ___\/  _ \ /     \_/ __ \                
 \     /\  ___/|  |_\  \__(  <_> )  Y Y  \  ___/                
  \/\_/  \___  >____/\___  >____/|__|_|  /\___  >               
             \/          \/            \/     \/              
                                        __                                
                                      _/  |_  ____     ____  __ _________ 
                                      \   __\/  _ \   /  _ \|  |  \_  __ \
                                       |  | (  <_> ) (  <_> )  |  /|  | \/
                                       |__|  \____/   \____/|____/ |__|   
                                    
                                                        .__                   __  .__
                                                   _____|  |__   ____   _____/  |_|__| ____    ____   ____________    ____    ____   ____  
                                                  /  ___/  |  \ /  _ \ /  _ \   __\  |/    \  / ___\  \_  __ \__  \  /    \  / ___\_/ __ \ 
                                                  \___ \|   Y  (  <_> |  <_> )  | |  |   |  \/ /_/  >  |  | \// __ \|   |  \/ /_/  >  ___/ 
                                                 /____  >___|  /\____/ \____/|__| |__|___|  /\___  /   |__|  (____  /___|  /\___  / \___  >
                                                      \/     \/                           \//_____/               \/     \//_____/      \/ 
");
            
            Console.WriteLine(@"                     
                                                     ___
                                             ___..--'  .`.
                                    ___...--'     -  .` `.`.
                           ___...--' _      -  _   .` -   `.`.
                  ___...--'  -       _   -       .`  `. - _ `.`.
           __..--'_______________ -         _  .`  _   `.   - `.`.
        .`    _ /\    -        .`      _     .`__________`. _  -`.`.
      .` -   _ /  \_     -   .`  _         .` |Shooting   |`.   - `.`.
    .`-    _  /   /\   -   .`        _   .`   |Range      |  `. _   `.`.
  .`________ /__ /_ \____.`____________.`     |___________|  - `._____`|
    |   -  __  -|    | - |  ____  |   | | _  |   |  _  |   |  _ |
    | _   |  |  | -  |   | |.--.| |___| |    |___|     |___|    |
    |     |--|  |    | _ | |'--'| |---| |   _|---|     |---|_   |
    |   - |__| _|  - |   | |.--.| |   | |    |   |_  _ |   |    |
 ---``--._      |    |   |=|'--'|=|___|=|====|___|=====|___|====|
 -- . ''  ``--._| _  |  -|_|.--.|_______|_______________________|
`--._           '--- |_  |:|'--'|:::::::|:::::::::::::::::::::::|
_____`--._ ''      . '---'``--._|:::::::|:::::::::::::::::::::::|
----------`--._          ''      ``--.._|:::::::::::::::::::::::|
`--._ _________`--._'        --     .   ''-----..............000'
     `--._----------`--._.  _           -- . :''           -    ''
          `--._ _________`--._ :'              -- . :''      -- . ''
 -- . ''       `--._ ---------`--._   -- . :''
          :'        `--._ _________`--._:'  -- . ''      -- . ''
  -- . ''     -- . ''    `--._----------`--._      -- . ''     -- . ''
                              `--._ _________`--._
 -- . ''           :'              `--._ ---------`--._-- . ''    -- . ''
          -- . ''       -- . ''         `--._ _________`--._   -- . ''
:'                 -- . ''          -- . ''  `--._----------`--._");
            Console.WriteLine("Press 1 to choose a weapon from our inventory or create one for yourself\n" +
                              "Press 0 to leave");
            
            string input = GetInput<string>("answer");

            switch (input)
            {
                case "1":
                    Console.Clear();
                    guns.PrintElements();
                    Console.WriteLine("9.Create your weapon");
                    break;
                case "0":
                    Console.Clear();
                    return;
                default:
                    Console.WriteLine(Constants.InvalidInputMessage);
                    goto Menu;
            }
            TryAgain:
            string input2 = GetInput<string>("answer");
            switch (input2)
            {
                case "1":
                    Console.Clear();
                    guns.PrintElements(0);
                    chosenGun.Add(guns[0]);
                    break;
                case "2":
                    Console.Clear();
                    guns.PrintElements(1);
                    chosenGun.Add(guns[1]);
                    break;
                case "3":
                    Console.Clear();
                    guns.PrintElements(2);
                    chosenGun.Add(guns[2]);
                    break;
                case "4":
                    Console.Clear();
                    guns.PrintElements(3);
                    chosenGun.Add(guns[3]);
                    break;
                case "5":
                    Console.Clear();
                    guns.PrintElements(4);
                    chosenGun.Add(guns[4]);
                    break;
                case "6":
                    Console.Clear();
                    guns.PrintElements(5);
                    chosenGun.Add(guns[5]);
                    break;
                case "7":
                    Console.Clear();
                    guns.PrintElements(6);
                    chosenGun.Add(guns[6]);
                    break;
                case "8":
                    Console.Clear();
                    guns.PrintElements(7);
                    chosenGun.Add(guns[7]);
                    break;
                case "9":
                    Console.Clear();
                    guns.Add(CreateGun());
                    guns.PrintElements(8);
                    chosenGun.Add(guns[8]);
                    break;
                case "0":
                    Console.Clear();
                    return;
                default:
                    Console.WriteLine(Constants.InvalidInputMessage); ;
                    Console.Clear();
                    goto TryAgain;
            }
            Console.WriteLine("Let's go outside and try it");
            Shoot1:
            if (chosenGun[0] is Pistol)
            {
                Console.WriteLine(@" 
    ----.
    '   _}
    '@   >
    |\   7
    / `-- _         ,-------,****
 ~    >o<  \---------o{___
/    }-
/  |  \  /  ________/8
|  |       /         
|  /      |");
            Shoot:
                Console.WriteLine($"{chosenGun[0].CurrentBulletCount}/{chosenGun[0].Capacity} ammo left");
                Console.WriteLine("Press f to shoot\n" +
                                  "Press 0 to leave");
                string input3 = GetInput<string>("answer").ToLower();
                switch (input3)
                {
                    case "f":
                        if (chosenGun[0].CurrentBulletCount != 0)
                        {
                            Console.Clear();
                            chosenGun[0].Shoot();
                            Console.WriteLine($"{chosenGun[0].CurrentBulletCount}/{chosenGun[0].Capacity} ammo left");
                            goto Shoot;
                        }
                        Console.Clear();
                        Console.WriteLine(Constants.OutOfBulletMessage);
                        goto Reload;
                    case "0":
                        return;
                    default:
                        Console.WriteLine(Constants.InvalidInputMessage);
                        Console.Clear();
                        goto Shoot;
                }
            }
            else if (chosenGun[0] is Smg)
            {
                Console.WriteLine(@" 
    ----.
    '   _}
    '@   >
    |\   7
    / `-- _         ,-------,****
 ~    >o<  \---------o{___
/    }-
/  |  \  /  ________/8
|  |       /         
|  /      |");
            Shoot:
                Console.WriteLine($"{chosenGun[0].CurrentBulletCount}/{chosenGun[0].Capacity} ammo left");
                Console.WriteLine("Press f to shoot once\n" +
                                  "Press b to burst shoot\n" +
                                  "Press g to auto fire\n" +
                                  "Press 0 to leave");
                string input3 = GetInput<string>("answer").ToLower();
                switch (input3)
                {
                    case "f":
                        if (chosenGun[0].CurrentBulletCount != 0)
                        {
                            Console.Clear();
                            chosenGun[0].Shoot();
                            Console.WriteLine($"{chosenGun[0].CurrentBulletCount}/{chosenGun[0].Capacity} ammo left");
                            goto Shoot;
                        }
                        Console.Clear();
                        Console.WriteLine(Constants.OutOfBulletMessage);
                        goto Reload;
                    case "b":
                        if (chosenGun[0].CurrentBulletCount < 3)
                        {
                            Console.Clear();
                            Console.WriteLine(Constants.OutOfBulletMessage);
                            goto Reload;
                        }
                        chosenGun[0].BurstShoot();
                        Console.WriteLine($"{chosenGun[0].CurrentBulletCount}/{chosenGun[0].Capacity} ammo left");
                        goto Shoot;
                    case "g":
                        if (chosenGun[0].CurrentBulletCount != 0)
                        {
                            chosenGun[0].Shoot();
                            Console.WriteLine($"{chosenGun[0].CurrentBulletCount}/{chosenGun[0].Capacity} ammo left");
                            goto case "g";
                        }
                        Console.Clear();
                        Console.WriteLine(Constants.OutOfBulletMessage);
                        goto Reload;
                    case "0":
                        return;
                    default:
                        Console.WriteLine(Constants.InvalidInputMessage);
                        Console.Clear();
                        goto Shoot;
                }
            }
            else if (chosenGun[0] is AssaultRifle)
            {
                Console.WriteLine(@" 
    ----.
    '   _}
    '@   >
    |\   7
    / `-- _         ,-------,****
 ~    >o<  \---------o{___
/    }-
/  |  \  /  ________/8
|  |       /         
|  /      |");
            Shoot:
                Console.WriteLine($"{chosenGun[0].CurrentBulletCount}/{chosenGun[0].Capacity} ammo left");
                Console.WriteLine("Press f to shoot once\n" +
                                  "Press g to auto fire\n" +
                                  "Press 0 to leave");
                string input3 = GetInput<string>("answer").ToLower();
                switch (input3)
                {
                    case "f":
                        if (chosenGun[0].CurrentBulletCount != 0)
                        {
                            Console.Clear();
                            chosenGun[0].Shoot();
                            Console.WriteLine($"{chosenGun[0].CurrentBulletCount}/{chosenGun[0].Capacity} ammo left");
                            goto Shoot;
                        }
                        Console.Clear();
                        Console.WriteLine(Constants.OutOfBulletMessage);
                        goto Reload;
                    case "g":
                        if (chosenGun[0].CurrentBulletCount != 0)
                        {
                            chosenGun[0].Shoot();
                            Console.WriteLine($"{chosenGun[0].CurrentBulletCount}/{chosenGun[0].Capacity} ammo left");
                            goto case "g";
                        }
                        Console.Clear();
                        Console.WriteLine(Constants.OutOfBulletMessage);
                        goto Reload;
                    case "0":
                        return;
                    default:
                        Console.WriteLine(Constants.InvalidInputMessage);
                        Console.Clear();
                        break;
                }

            }
            else
            {
                Console.WriteLine(@" 
    ----.
    '   _}
    '@   >
    |\   7
    / `-- _         ,-------,****
 ~    >o<  \---------o{___
/    }-
/  |  \  /  ________/8
|  |       /         
|  /      |");
                Shoot:
                Console.WriteLine($"{chosenGun[0].CurrentBulletCount}/{chosenGun[0].Capacity} ammo left");
                Console.WriteLine("Press f to shoot\n" +
                                  "Press 0 to get back inside");
                string input3 = GetInput<string>("answer").ToLower();
                switch (input3)
                {
                    case "f":
                        Console.Clear();
                        if (chosenGun[0].CurrentBulletCount != 0)
                        {
                            chosenGun[0].Shoot();
                            Console.WriteLine($"{chosenGun[0].CurrentBulletCount}/{chosenGun[0].Capacity} ammo left");
                            goto Shoot;
                        }
                        Console.Clear();
                        Console.WriteLine(Constants.OutOfBulletMessage);
                        goto Reload;
                    case "0":
                        goto Inside;
                    default:
                        Console.WriteLine(Constants.InvalidInputMessage);
                        Console.Clear();
                        goto Shoot;
                }
            }
            Reload:
            if (chosenGun[0].CurrentBulletCount == 0)
            {
                Console.WriteLine("Press r to Reload\n" +
                                  "Press 0 to get back inside");
                string input4 = GetInput<string>("answer").ToLower();
                switch (input4)
                {
                    case "r":
                        chosenGun[0].Reload();
                        goto Shoot1;
                    case "0":
                        return;
                    default:
                        Console.WriteLine(Constants.InvalidInputMessage);
                        Console.Clear();
                        break;
                }
                chosenGun[0].Reload();
            }
            Inside:
            Console.WriteLine();

        }
        /// <summary>
        /// Gets generic type input from console
        /// </summary>
        /// <typeparam name="T">Generic type data</typeparam>
        /// <param name="output">Output of the input</param>
        /// <returns>string</returns>
        public static T GetInput<T> (string output)
        {
            TryAgain:
            Console.WriteLine("Please enter {0}", output);
            string input = Console.ReadLine().Trim();
            T convertedInput;
            try
            {
                convertedInput = (T)Convert.ChangeType(input, typeof(T));
            }
            catch (Exception)
            {
                Console.WriteLine(Constants.InvalidInputMessage);
                goto TryAgain;
            }
            return convertedInput;
        }
        /// <summary>
        /// Creates a type of gun
        /// </summary>
        /// <returns>Gun</returns>
        public static Gun CreateGun()
        {
            TryAgain:
            Console.WriteLine("1.Pistol\n" +
                              "2.Assault Rifle\n" +
                              "3.Sniper\n" +
                              "4.Smg\n");
            string input = GetInput<string>("a type for your weapon");
            switch (input)
            {
                case "1":
                    Console.Clear();
                    string name = GetInput<string>("a name");
                    Bullet bulletType = CreateBullet();
                    return new Pistol(name, bulletType);
                case "2":
                    Console.Clear();
                    string name2 = GetInput<string>("a name");
                    Bullet bulletType2 = CreateBullet();
                    return new AssaultRifle(name2, bulletType2);
                case "3":
                    Console.Clear();
                    string name3 = GetInput<string>("a name");
                    Bullet bulletType3 = CreateBullet();
                    return new Sniper(name3, bulletType3);
                case "4":
                    Console.Clear();
                    string name4 = GetInput<string>("a name");
                    Bullet bulletType4 = CreateBullet();
                    return new Smg(name4, bulletType4);
                default:
                    Console.Clear();
                    Console.WriteLine(Constants.InvalidInputMessage);
                    goto TryAgain;
            }
        }
        /// <summary>
        /// Creates a type of bullet
        /// </summary>
        /// <returns>Bullet</returns>
        public static Bullet CreateBullet()
        {
            double caliber = GetInput<double>("bullet caliber");
            string type = GetInput<string>("type of the bullet");
            return new Bullet(caliber, type);
        }

        
    }
}
