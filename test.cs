
// Импортируем необходимые пространства имен
using UnityEngine;
using Il2CppScripts.GameSystem;
using Il2CppScripts.CharacterSystem;
using Il2CppScripts.Interfaces;

// --- НАСТРОЙКА ---
// Впишите точное имя NPC, которого хотите взять в цель
string npcNameToFind = "Trader"; 
// -----------------


// 1. Получаем объект локального игрока
var localPlayer = Game.Instance.User;
if (localPlayer == null)
{
    Debug.LogError("[UnityExplorer] Ошибка: Не удалось найти локального игрока (Game.Instance.User). Убедитесь, что вы в игре.");
    return; // Прерываем выполнение, если игрок не найден
}
Debug.Log($"[UnityExplorer] Локальный игрок найден: {localPlayer.Name}");


// 2. Ищем целевого NPC
IGameEntity targetNpc = null;
var npcRoot = WorldInstance.Instance.NpcRoot;
if (npcRoot == null)
{
    Debug.LogError("[UnityExplorer] Ошибка: Не удалось найти корень NPC (WorldInstance.Instance.NpcRoot).");
    return; // Прерываем, если "папка" с NPC не найдена
}

var allNpcs = npcRoot.GetComponentsInChildren<Character>();
Debug.Log($"[UnityExplorer] Поиск среди {allNpcs.Length} NPC...");

foreach (var npc in allNpcs)
{
    // Сравниваем имя NPC с искомым
    if (npc.Name == npcNameToFind)
    {
        // ИСПРАВЛЕНИЕ: Получаем интерфейс через GetComponent, это более надежный способ
        targetNpc = npc.GetComponent<IGameEntity>(); 
        
        if (targetNpc != null)
        {
            Debug.Log($"[UnityExplorer] Найден NPC: {npc.Name} (ID: {npc.ObjectID})");
            break; // Выходим из цикла, так как нашли нужного NPC
        }
    }
}


// 3. Устанавливаем цель
if (targetNpc != null)
{
    localPlayer.SetTarget(targetNpc);
    // Проверяем, установилась ли цель
    if (localPlayer.Target == targetNpc)
    {
        Debug.Log($"[UnityExplorer] УСПЕХ: Цель успешно установлена на '{targetNpc.Name}'");
    }
    else
    {
        Debug.LogError("[UnityExplorer] ОШИБКА: Не удалось установить цель, хотя NPC был найден. Возможно, мешает игровая логика.");
    }
}
else
{
    Debug.LogError($"[UnityExplorer] ОШИБКА: NPC с именем '{npcNameToFind}' не найден в мире.");
}
