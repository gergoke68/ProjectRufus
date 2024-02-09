using System.Drawing;
using System.Media;

Menu();
string playerName = "";
bool isMiloWithUs = false;
int playerHealth = 100;
int playerStrenght = 1;

string[] enemyNames = { "Gorlock", "Maru", "Bober", "Pingwin", "Bob", "József", "Fereng", "Vojtech", "Togepi", "Kirby"};

void Menu()
{

Print("\r\n ('-. .-.   ('-.                      .-') _  .-') _                                        .-') _    ('-. .-.   ('-.         _ .-') _     ('-.     _  .-')  .-. .-')           ('-.                   ('-.    .-')    \r\n( OO )  /  ( OO ).-.                 ( OO ) )(  OO) )                                      (  OO) )  ( OO )  / _(  OO)       ( (  OO) )   ( OO ).-.( \\( -O ) \\  ( OO )         ( OO ).-.             _(  OO)  ( OO ).  \r\n,--. ,--.  / . --. / ,--. ,--.   ,--./ ,--,' /     '._        .-'),-----.    ,------.      /     '._ ,--. ,--.(,------.       \\     .'_   / . --. / ,------. ,--. ,--.         / . --. /  ,----.    (,------.(_)---\\_) \r\n|  | |  |  | \\-.  \\  |  | |  |   |   \\ |  |\\ |'--...__)      ( OO'  .-.  '('-| _.---'      |'--...__)|  | |  | |  .---'       ,`'--..._)  | \\-.  \\  |   /`. '|  .'   /         | \\-.  \\  '  .-./-')  |  .---'/    _ |  \r\n|   .|  |.-'-'  |  | |  | | .-') |    \\|  | )'--.  .--'      /   |  | |  |(OO|(_\\          '--.  .--'|   .|  | |  |           |  |  \\  '.-'-'  |  | |  /  | ||      /,       .-'-'  |  | |  |_( O- ) |  |    \\  :` `.  \r\n|       | \\| |_.'  | |  |_|( OO )|  .     |/    |  |         \\_) |  |\\|  |/  |  '--.          |  |   |       |(|  '--.        |  |   ' | \\| |_.'  | |  |_.' ||     ' _)       \\| |_.'  | |  | .--, \\(|  '--.  '..`''.) \r\n|  .-.  |  |  .-.  | |  | | `-' /|  |\\    |     |  |           \\ |  | |  |\\_)|  .--'          |  |   |  .-.  | |  .--'        |  |   / :  |  .-.  | |  .  '.'|  .   \\          |  .-.  |(|  | '. (_/ |  .--' .-._)   \\ \r\n|  | |  |  |  | |  |('  '-'(_.-' |  | \\   |     |  |            `'  '-'  '  \\|  |_)           |  |   |  | |  | |  `---.       |  '--'  /  |  | |  | |  |\\  \\ |  |\\   \\         |  | |  | |  '--'  |  |  `---.\\       / \r\n`--' `--'  `--' `--'  `-----'    `--'  `--'     `--'              `-----'    `--'             `--'   `--' `--' `------'       `-------'   `--' `--' `--' '--'`--' '--'         `--' `--'  `------'   `------' `-----'  \r\n", 0);

Print("\r\n  __              _____            _   _                                   \r\n /_ |            / ____|          | | (_)                                  \r\n  | |  ______   | |     ___  _ __ | |_ _ _ __  _   _  ___                  \r\n  | | |______|  | |    / _ \\| '_ \\| __| | '_ \\| | | |/ _ \\                 \r\n  | |           | |___| (_) | | | | |_| | | | | |_| |  __/                 \r\n  |_|            \\_____\\___/|_| |_|\\__|_|_| |_|\\__,_|\\___|                 \r\n |__ \\            | \\ | |                                                  \r\n    ) |  ______   |  \\| | _____      __   __ _  __ _ _ __ ___   ___        \r\n   / /  |______|  | . ` |/ _ \\ \\ /\\ / /  / _` |/ _` | '_ ` _ \\ / _ \\       \r\n  / /_            | |\\  |  __/\\ V  V /  | (_| | (_| | | | | | |  __/       \r\n |____|           |_| \\_|\\___| \\_/\\_/    \\__, |\\__,_|_| |_| |_|\\___|       \r\n |___ \\            | \\ | |                __/ |                        _   \r\n   __) |  ______   |  \\| | _____      __ |___/_  __ _ _ __ ___   ___ _| |_ \r\n  |__ <  |______|  | . ` |/ _ \\ \\ /\\ / /  / _` |/ _` | '_ ` _ \\ / _ \\_   _|\r\n  ___) |           | |\\  |  __/\\ V  V /  | (_| | (_| | | | | | |  __/ |_|  \r\n |____/            |_| \\_|\\___| \\_/\\_/    \\__, |\\__,_|_| |_| |_|\\___|      \r\n  _  _                _____      _   _   _ __/ |                           \r\n | || |              / ____|    | | | | (_)___/                            \r\n | || |_   ______   | (___   ___| |_| |_ _ _ __   __ _ ___                 \r\n |__   _| |______|   \\___ \\ / _ \\ __| __| | '_ \\ / _` / __|                \r\n    | |              ____) |  __/ |_| |_| | | | | (_| \\__ \\                \r\n  __|_|             |_____/ \\___|\\__|\\__|_|_| |_|\\__, |___/                \r\n | ____|            / ____|            | (_) |    __/ |                    \r\n | |__    ______   | |     _ __ ___  __| |_| |_ _|___/                     \r\n |___ \\  |______|  | |    | '__/ _ \\/ _` | | __/ __|                       \r\n  ___) |           | |____| | |  __/ (_| | | |_\\__ \\                       \r\n |____/             \\_____|_|  \\___|\\__,_|_|\\__|___/                       \r\n   / /             |  ____|    (_) |                                       \r\n  / /_    ______   | |__  __  ___| |_                                      \r\n | '_ \\  |______|  |  __| \\ \\/ / | __|                                     \r\n | (_) |           | |____ >  <| | |_                                      \r\n  \\___/            |______/_/\\_\\_|\\__|                                     \r\n                                                                           \r\n                                                                           \r\n", 0);

int menu_opt = Convert.ToInt32(Console.ReadLine());

switch (menu_opt)
{
    case 2:
        NewGameStart();
        break;
    case 6:
        Environment.Exit(0);
        break;
}

}

void NewGameStart()
{
    Console.Clear();
    Print("What's your name?");
    Console.WriteLine();
    playerName = Console.ReadLine();
    Console.WriteLine();



    Print("You woke up in your mother's house.");
    Print("It was a strangely quiet morning in Berlin.");
    Print("A few days ago the doctor took your mom to the hospital, you should pay her a visit soon.");
    Console.WriteLine();
    Print("Doc told us not to go but who is he to tell us what to do.");
    Tutorial();
}

void Tutorial()
{
    Print("Get bro to come w u");
    Print("Y/N");
    string choice = Console.ReadLine();
    if (choice.ToUpper() == "Y")
    {
        Print("Bro not home anyway");

        Print("Milo (your friend) comes over and offers you he'll come with you of you help him get some mushrooms");
        Print("Will you help him? (Y/N)");
        choice = Console.ReadLine();

        if (choice.ToUpper() == "Y")
        {
            MushroomMiniGame();
        }
        else
        {

        }
    }
    else
    {
        Print("Milo (your friend) comes over and offers you he'll come with you of you help him get some mushrooms");
        Print("Will you help him? (Y/N)");
        choice = Console.ReadLine();

        if (choice.ToUpper() == "Y")
        {
            MushroomMiniGame();
        }
        else
        {

        }
    }
}
void MushroomMiniGame()
    {

    }
void Print(string text, int speed=60)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(speed);
    }
    
}
void Battle(string type)
{
    Print("Our homeland is in danger. Everything is awful.");
    Print("Player Turn");
    Console.WriteLine("[1] - Attack \n [2] - Items \n [3] - Talk \n [4] - Flee \n");

    string battleChoice = Console.ReadLine();
    Random rng = new Random();

    int enemyHealth = rng.Next(1, 200);
    int enemyDamage = rng.Next(5, 20);
    string enemyName = enemyNames[rng.Next(10)];

    switch (battleChoice)
    {
        case "1":
            
        case "2":
            break;
        case "3":
            break;
        case "4":
            Console.WriteLine("Goodbye!");
            Print("And you ran away like a coward");
            break;
    }   
}




















/*


    int[] cColors = { 0x000000, 0x000080, 0x008000, 0x008080, 0x800000, 0x800080, 0x808000, 0xC0C0C0, 0x808080, 0x0000FF, 0x00FF00, 0x00FFFF, 0xFF0000, 0xFF00FF, 0xFFFF00, 0xFFFFFF };

    void ConsoleWritePixel(Color cValue)
    {
        Color[] cTable = cColors.Select(x => Color.FromArgb(x)).ToArray();
        char[] rList = new char[] { (char)9617, (char)9618, (char)9619, (char)9608 }; // 1/4, 2/4, 3/4, 4/4
        int[] bestHit = new int[] { 0, 0, 4, int.MaxValue }; //ForeColor, BackColor, Symbol, Score

        for (int rChar = rList.Length; rChar > 0; rChar--)
        {
            for (int cFore = 0; cFore < cTable.Length; cFore++)
            {
                for (int cBack = 0; cBack < cTable.Length; cBack++)
                {
                    int R = (cTable[cFore].R * rChar + cTable[cBack].R * (rList.Length - rChar)) / rList.Length;
                    int G = (cTable[cFore].G * rChar + cTable[cBack].G * (rList.Length - rChar)) / rList.Length;
                    int B = (cTable[cFore].B * rChar + cTable[cBack].B * (rList.Length - rChar)) / rList.Length;
                    int iScore = (cValue.R - R) * (cValue.R - R) + (cValue.G - G) * (cValue.G - G) + (cValue.B - B) * (cValue.B - B);
                    if (!(rChar > 1 && rChar < 4 && iScore > 50000)) // rule out too weird combinations
                    {
                        if (iScore < bestHit[3])
                        {
                            bestHit[3] = iScore; //Score
                            bestHit[0] = cFore;  //ForeColor
                            bestHit[1] = cBack;  //BackColor
                            bestHit[2] = rChar;  //Symbol
                        }
                    }
                }
            }
        }
        Console.ForegroundColor = (ConsoleColor)bestHit[0];
        Console.BackgroundColor = (ConsoleColor)bestHit[1];
        Console.Write(rList[bestHit[2] - 1]);
    }
void ConsoleWriteImage(Bitmap source)
{
    int sMax = 80;
    decimal percent = Math.Min(decimal.Divide(sMax, source.Width), decimal.Divide(sMax, source.Height));
    Size dSize = new Size((int)(source.Width * percent), (int)(source.Height * percent));
    Bitmap bmpMax = new Bitmap(source, dSize.Width * 2, dSize.Height);
    for (int i = 0; i < dSize.Height; i++)
    {
        for (int j = 0; j < dSize.Width; j++)
        {
            ConsoleWritePixel(bmpMax.GetPixel(j * 2, i));
            ConsoleWritePixel(bmpMax.GetPixel(j * 2 + 1, i));
        }
        Console.WriteLine();
    }
    Console.ResetColor();
}

Bitmap bmpSrc = new(@"./forest.png", true);
ConsoleWriteImage(bmpSrc);
*/