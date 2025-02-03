using MelonLoader;
using System;
using UnityEngine;

namespace TestMod
{
    public static class BuildInfo
    {
        public const string Name = "Snakes Silly Card Game Mod Menu";
        public const string Description = "a cool mod menu";
        public const string Author = "Snake";
        public const string Company = null;
        public const string Version = "1.0.0";
        public const string DownloadLink = null;
    }

    public class TestMod : MelonMod
    {
        private Rect windowRect = new Rect(100, 100, 450, 450);

        public static bool Test;
        private static string YesNo(bool input) => input ? "Enabled" : "Disabled";
        private static void DrawguiButton(string label, Action onClick) { if (GUILayout.Button(label, GUILayout.Height(30))) { onClick?.Invoke(); } }
        private static bool DrawguiToggle(bool toggleValue, string label) { return GUILayout.Toggle(toggleValue, label, GUILayout.Height(30)); }

        public override void OnGUI()
        {
            windowRect = GUI.Window(0, windowRect, DrawWindow, "Snakes Silly Card Game Mod Menu");
        }

        private void DrawWindow(int id)
        {
            GUILayout.Space(10);


            DrawguiButton("Quit", () => modmenu.mods.themods.Quit());
            DrawguiButton("Max Coins", () => modmenu.mods.themods.maxcoins());
            DrawguiButton("Max Level", () => modmenu.mods.themods.maxlevelshop());
            DrawguiButton("give legendary item", () => modmenu.mods.themods.givelegendaryitem());

            GUI.DragWindow(new Rect(0, 0, 10000, 20));
        }

        private Texture2D MakeBackgroundTexture(Color color, float alpha)
        {
            Texture2D texture = new Texture2D(1, 1);
            texture.SetPixel(0, 0, new Color(color.r, color.g, color.b, alpha));
            texture.Apply();
            return texture;
        }
    }
}
