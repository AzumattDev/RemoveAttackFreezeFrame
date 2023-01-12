using HarmonyLib;

namespace RemoveAttackFreezeFrame;

[HarmonyPatch(typeof(Character),nameof(Character.FreezeFrame))]
static class CharacterFreezeFramePatch
{
    static void Prefix(Character __instance, ref float duration)
    {
        if (__instance is not Player player) return;
        if (player == Player.m_localPlayer)
        {
            duration = 0.0f;
        }
    }
    static void Postfix(Character __instance, ref float duration)
    {
        if (__instance is not Player player) return;
        if (player == Player.m_localPlayer)
        {
            duration = 0.0f; // This is just here to make sure the duration is 0.0f. It's not needed...technically.
        }
    }
}