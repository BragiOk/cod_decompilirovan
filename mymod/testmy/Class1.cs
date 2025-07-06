using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(MyMod.TabbedGuiMod), "Tabbed In-Game GUI", "1.0.2", "YourName")]
[assembly: MelonGame(null, null)]

namespace MyMod
{
    public class TabbedGuiMod : MelonMod
    {
        private int activeTab = 0;

        public override void OnGUI()
        {
            GUI.Box(new Rect(10, 10, 240, 160), "Tabbed GUI");

            if (activeTab == 0)
            {
                if (GUI.Button(new Rect(30, 50, 180, 30), "Привет мир"))
                {
                    MelonLogger.Msg("Вкладка 1: Привет, мир!");
                }

                if (GUI.Button(new Rect(30, 90, 180, 30), "Перейти на вкладку 2"))
                {
                    activeTab = 1;
                }
            }
            else if (activeTab == 1)
            {
                if (GUI.Button(new Rect(30, 50, 180, 30), "Привет мир со 2"))
                {
                    MelonLogger.Msg("Вкладка 2: Привет, мир!");
                }

                if (GUI.Button(new Rect(30, 90, 180, 30), "Вернуться на вкладку 1"))
                {
                    activeTab = 0;
                }
            }
        }
    }
}
