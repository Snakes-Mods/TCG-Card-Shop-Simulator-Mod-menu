using GUPS.EasyPerformanceMonitor.Demos.B;
using MelonLoader;
using System;
using UnityEngine;

namespace modmenu
{
    internal class mods
    {
        public class themods
        {
            public static void Quit()
            {
                Application.Quit();
            }

            public static void maxlevelshop()
            {
                CEventPlayer_AddShopExp shopExpEvent = new CEventPlayer_AddShopExp(int.MaxValue, false);
            }

            public static void maxcoins()
            {
                CEventPlayer_AddCoin coinEvent = new CEventPlayer_AddCoin(int.MaxValue, false);
                CEventPlayer_SetCoin setCoin = new CEventPlayer_SetCoin(10000000);
            }

            public static void givelegendaryitem()
            {
                ItemSpawnManager.Instance.name = "LegendaryCardPack";
            }
        }
    }
}
