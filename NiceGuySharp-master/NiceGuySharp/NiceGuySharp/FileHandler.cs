using System;
using System.Text.RegularExpressions;
using System.IO;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;
using Color = SharpDX.Color;
using ExtensionMethods;

namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static string[] GetLines(this string s)
        {
            return s.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
        }
    }
}

namespace NiceGuySharp
{
    internal class FileHandler
    {
        public static string Folder = Config.AppDataDirectory + @"\NiceGuySharp\";


        public static string OnGameStartTxt;
        public static string OnDeathTxt;
        public static string OnGameEndTxt;

        public static string OnKillTxt;
        public static string OnDoubleTxt;
        public static string OnTripleTxt;
        public static string OnQuadraTxt;
        public static string OnPentaTxt;

        public static string OnAllyDeathTxt;
        public static string OnAllyDoubleTxt;
        public static string OnAllyTripleTxt;
        public static string OnAllyQuadraTxt;
        public static string OnAllyPentaTxt;

        public static string OnEnemyKillTxt;
        public static string OnEnemyDoubleTxt;
        public static string OnEnemyTripleTxt;
        public static string OnEnemyQuadraTxt;
        public static string OnEnemyPentaTxt;

        public static Menu Menu;

        public static string[] ParseFile(Type file)
        {
            if (file != null)
            {

            }
            return new string[1];
        }

        public static void DoChecks()
        {
            OnGameStartTxt = Folder + "OnGameStart.txt";
            OnGameEndTxt = Folder + "OnGameEnd.txt";

            OnKillTxt = Folder + "OnKill.txt";
            OnDeathTxt = Folder + "OnDeath.txt";
            OnDoubleTxt = Folder + "OnDouble.txt";
            OnTripleTxt = Folder + "OnTriple.txt";
            OnQuadraTxt = Folder + "OnQuadra.txt";
            OnPentaTxt = Folder + "OnPenta.txt";

            OnAllyDeathTxt = Folder + "OnAllyDeath.txt";
            OnAllyDoubleTxt = Folder + "OnAllyDouble.txt";
            OnAllyTripleTxt = Folder + "OnAllyTriple.txt";
            OnAllyQuadraTxt = Folder + "OnAllyQuadra.txt";
            OnAllyPentaTxt = Folder + "OnAllyPenta.txt";

            OnEnemyKillTxt = Folder + "OnEnemyKill.txt";
            OnEnemyDoubleTxt = Folder + "OnEnemyDouble.txt";
            OnEnemyTripleTxt = Folder + "OnEnemyTriple.txt";
            OnEnemyQuadraTxt = Folder + "OnEnemyQuadra.txt";
            OnEnemyPentaTxt = Folder + "OnEnemyPenta.txt";

            if (!Directory.Exists(Folder))
            {
                Game.PrintChat("It seems like you're using Nice Guy Sharp");
                Game.PrintChat("for the first time. If you're interested");
                Game.PrintChat("in changing the words, please go to this folder:");
                Game.PrintChat(Folder);
                Game.PrintChat("Once you've changed the settings, just");
                Game.PrintChat("reload the assembly and you're done.");

                Menu = new Menu("Nice Guy Sharp - FIRST RUN README", "niceguysharpfirstrunreadme", true).SetFontStyle(System.Drawing.FontStyle.Regular, Color.Green);
                Menu.AddItem(new MenuItem("readmestring1", "It seems like you're using Nice Guy Sharp"));
                Menu.AddItem(new MenuItem("readmestring2", "for the first time. If you're interested"));
                Menu.AddItem(new MenuItem("readmestring3", "in changing the words, please go to this folder:"));
                Menu.AddItem(new MenuItem("readmestring4", Folder));
                Menu.AddItem(new MenuItem("readmestring5", "Once you've changed the settings, just"));
                Menu.AddItem(new MenuItem("readmestring6", "reload the assembly and you're done."));
                Menu.AddToMainMenu();

                Directory.CreateDirectory(Folder);
            }


            if (!File.Exists(OnGameStartTxt))
            {
                var newfile = File.Create(OnGameStartTxt);
                newfile.Close();
                const string content = "/all Glhf\r\n/all Gl hf\r\n/all Hi! Good luck and have fun";
                var separator = new[] { "\r\n" };
                string[] lines = Regex.Split(content, "\r\n");
                File.WriteAllLines(OnGameStartTxt, lines);
            }
            if (!File.Exists(OnDeathTxt))
            {
                var newfile = File.Create(OnDeathTxt);
                newfile.Close();
                const string content = "Oops\r\nWhat\r\nDoh!\r\nOmg\r\nThat dmg\r\nFudge\r\nFML\r\nGod darn I suck\r\nSowwy\r\nBlame it on lag\r\nI think that was lagg\r\nLaggg\r\nOMG pls\r\nHalp meh!\r\nPls help\r\n/all My team is invisible\r\nMeh\r\n/all Totally calculated!";
                var separator = new[] { "\r\n" };
                string[] lines = Regex.Split(content, "\r\n");
                File.WriteAllLines(OnGameStartTxt, lines);
            }
            if (!File.Exists(OnGameEndTxt))
            {
                var newfile = File.Create(OnGameEndTxt);
                newfile.Close();
                const string content = "/all Gg\r\n/all Ggwp\r\n/all Wp everyone!\r\n/all I had a blast! ggwp";
                var separator = new[] { "\r\n" };
                string[] lines = Regex.Split(content, "\r\n");
                File.WriteAllLines(OnGameStartTxt, lines);
            }
            if (!File.Exists(OnKillTxt))
            {
                var newfile = File.Create(OnKillTxt);
                newfile.Close();
                const string content = "/all Outplayed\r\n/all Owned\r\n/all Pwned\r\n/all LOL :D\r\n/all Lolol\r\n/all ? :=D\r\n/all Close\r\n/all Daemn son!\r\n/all xd\r\n/all Wow\r\n/all Lel\r\n/all Gotcha\r\n/all Wtf\r\n/all Lololol\r\n/all Aww:D\r\n/all xdd";
                var separator = new[] { "\r\n" };
                string[] lines = Regex.Split(content, "\r\n");
                File.WriteAllLines(OnGameStartTxt, lines);
            }
            if (!File.Exists(OnDoubleTxt))
            {
                var newfile = File.Create(OnDoubleTxt);
                newfile.Close();
            }
            if (!File.Exists(OnTripleTxt))
            {
                var newfile = File.Create(OnTripleTxt);
                newfile.Close();
                const string content = "oooh baby a triple!\r\nfk yeah\r\n/all =)";
                var separator = new[] { "\r\n" };
                string[] lines = Regex.Split(content, "\r\n");
                File.WriteAllLines(OnGameStartTxt, lines);
            }
            if (!File.Exists(OnQuadraTxt))
            {
                var newfile = File.Create(OnQuadraTxt);
                newfile.Close();
                const string content = "godlike\r\nhaha\r\nowned\r\nxD\r\n/all whoops:DD";
                var separator = new[] { "\r\n" };
                string[] lines = Regex.Split(content, "\r\n");
                File.WriteAllLines(OnGameStartTxt, lines);
            }
            if (!File.Exists(OnPentaTxt))
            {
                var newfile = File.Create(OnPentaTxt);
                newfile.Close();
                const string content = ":D Uwned\r\n/all :D\r\n/all :DD\r\nPenta <3\r\n/all HAH got 'em!\r\n/all :=D\r\n/all Wish that would happen more often";
                var separator = new[] { "\r\n" };
                string[] lines = Regex.Split(content, "\r\n");
                File.WriteAllLines(OnGameStartTxt, lines);
            }
            if (!File.Exists(OnAllyDeathTxt))
            {
                var newfile = File.Create(OnAllyDeathTxt);
                newfile.Close();
                const string content = "Lel scrub kappa\r\nFelt good?\r\nKek\r\nNomnom\r\nlol\r\nLel\r\nHaha\r\nOuch\r\nOops\r\nxD\r\nsht\r\nlol\r\nxddd\r\npls xD\r\n...\r\n:D\r\n..\r\nlel\r\n:D:D";
                var separator = new[] { "\r\n" };
                string[] lines = Regex.Split(content, "\r\n");
                File.WriteAllLines(OnGameStartTxt, lines);
            }
            if (!File.Exists(OnAllyDoubleTxt))
            {
                var newfile = File.Create(OnAllyDoubleTxt);
                newfile.Close();
                const string content = "Oo nice!\r\nSweet\r\nNice job\r\nWP\r\nNice\r\nGj";
                var separator = new[] { "\r\n" };
                string[] lines = Regex.Split(content, "\r\n");
                File.WriteAllLines(OnGameStartTxt, lines);
            }
            if (!File.Exists(OnAllyTripleTxt))
            {
                var newfile = File.Create(OnAllyTripleTxt);
                newfile.Close();
                const string content = "Nice!\r\nOp\r\nGg\r\nWp\r\nGj";
                var separator = new[] { "\r\n" };
                string[] lines = Regex.Split(content, "\r\n");
                File.WriteAllLines(OnGameStartTxt, lines);
            }
            if (!File.Exists(OnAllyQuadraTxt))
            {
                var newfile = File.Create(OnAllyQuadraTxt);
                newfile.Close();
                const string content = "Nice!\r\nOp\r\nGg\r\nWp\r\nGj";
                var separator = new[] { "\r\n" };
                string[] lines = Regex.Split(content, "\r\n");
                File.WriteAllLines(OnGameStartTxt, lines);
            }
            if (!File.Exists(OnAllyPentaTxt))
            {
                var newfile = File.Create(OnAllyPentaTxt);
                newfile.Close();
                const string content = "Nice!\r\nOp\r\nGg\r\nWp\r\nGj";
                var separator = new[] { "\r\n" };
                string[] lines = Regex.Split(content, "\r\n");
                File.WriteAllLines(OnGameStartTxt, lines);
            }
            if (!File.Exists(OnEnemyKillTxt))
            {
                var newfile = File.Create(OnEnemyKillTxt);
                newfile.Close();
            }
            if (!File.Exists(OnEnemyDoubleTxt))
            {
                var newfile = File.Create(OnEnemyDoubleTxt);
                newfile.Close();
            }
            if (!File.Exists(OnEnemyTripleTxt))
            {
                var newfile = File.Create(OnEnemyTripleTxt);
                newfile.Close();
            }
            if (!File.Exists(OnEnemyQuadraTxt))
            {
                var newfile = File.Create(OnEnemyQuadraTxt);
                newfile.Close();
            }
            if (!File.Exists(OnEnemyPentaTxt))
            {
                var newfile = File.Create(OnEnemyPentaTxt);
                newfile.Close();
            }
        }
    }
}
