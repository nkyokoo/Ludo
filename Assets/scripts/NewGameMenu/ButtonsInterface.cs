using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.scripts.mainMenu.NewGameMenu
{
    interface ButtonsInterface
    {
        void StartGame();
        void SaveConfig();
        void BackButton();
        void exitGame();
    }
}
