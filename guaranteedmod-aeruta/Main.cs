using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace guaranteedmod_aeruta;

public static class Plugin {
    public const string Guid = "com.ryocery.guaranteedmod_aeruta";
    public const string Name = "Guaranteed Modification";
    public const string Version = "1.0.0";
}

[BepInPlugin(Plugin.Guid, Plugin.Name, Plugin.Version)]
public class GuaranteedModification : BasePlugin {
    private new static ManualLogSource Log { get; set; } = null!;
    private static Harmony _harmony = null!;

    public override void Load() {
        Log = base.Log;
        _harmony = new Harmony(Plugin.Guid);
        _harmony.PatchAll();
        Log.LogInfo($"Plugin {Plugin.Guid} is loaded!");
    }
}

