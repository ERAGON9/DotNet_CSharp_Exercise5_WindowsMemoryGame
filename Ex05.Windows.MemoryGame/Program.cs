using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05.Windows.MemoryGame
{
    public class Program
    {
        public static void Main()
        {
            FormSettings formSettings = new FormSettings();

            formSettings.ShowDialog();
            FormGame formGame = new FormGame();
            formGame.ShowDialog();
        }
    }
}
