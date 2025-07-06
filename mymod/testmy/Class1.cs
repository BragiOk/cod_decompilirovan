using MelonLoader;
using UnityEngine;
using Il2CppScripts.GameSystem;
using Il2CppScripts.CharacterSystem;
using Il2CppScripts.Interfaces;
using Il2CppScripts.Services;
using System.Collections;

[assembly: MelonInfo(typeof(MyMod.TargetNpcMod), "Target NPC Mod", "1.1", "YourName")]
[assembly: MelonGame(null, null)]

namespace MyMod
{
    public class TargetNpcMod : MelonMod
    {
        private string npcNameToFind = "Teleporter";
        private string statusMessage = "Готово к поиску...";

        public override void OnGUI()
        {
            GUI.Box(new Rect(10, 10, 320, 130), "Цель NPC");

            if (GUI.Button(new Rect(30, 40, 260, 30), $"Найти NPC: {npcNameToFind}"))
            {
                TrySetTargetNpc(npcNameToFind);
            }

            GUI.Label(new Rect(30, 80, 260, 25), statusMessage);
        }

        private void TrySetTargetNpc(string targetName)
        {
            var localPlayer = Game.Instance?.User;
            if (localPlayer == null)
            {
                statusMessage = "Локальный игрок не найден!";
                MelonLogger.Error(statusMessage);
                return;
            }

            var npcRoot = WorldInstance.Instance?.NpcRoot;
            if (npcRoot == null)
            {
                statusMessage = "NpcRoot не найден!";
                MelonLogger.Error(statusMessage);
                return;
            }

            var allNpcs = npcRoot.GetComponentsInChildren<Character>();
            MelonLogger.Msg($"[Target NPC Mod] Всего найдено NPC: {allNpcs.Length}");

            foreach (var npc in allNpcs)
            {
                if (npc == null || npc.Name != targetName)
                    continue;

                var target = npc.TryCast<IGameEntity>();
                if (target != null)
                {
                    Game.Instance.Services.InputManager.RequestTarget(target);
                    MelonLogger.Msg($"[Target NPC Mod] Отправлен запрос на цель: {npc.Name}");

                    // Проверка через корутину
                    MelonCoroutines.Start(VerifyTargetLater(localPlayer, target));
                    return;
                }
            }

            statusMessage = $"NPC с именем '{targetName}' не найден.";
            MelonLogger.Error(statusMessage);
        }

        private IEnumerator VerifyTargetLater(Character localPlayer, IGameEntity expectedTarget)
        {
            yield return new WaitForSeconds(0.5f); // Подождать 0.5 секунды для обновления цели

            if (localPlayer.Target != null && localPlayer.Target.ObjectID == expectedTarget.ObjectID)
            {
                statusMessage = $"✅ Цель установлена: {expectedTarget.Name}";
                MelonLogger.Msg(statusMessage);
            }
            else
            {
                var currentTarget = localPlayer.Target;
                var currentName = currentTarget?.Name ?? "null";
                statusMessage = $"❌ Цель не установлена. Сейчас: {currentName}";
                MelonLogger.Warning(statusMessage);
            }
        }
    }
}
