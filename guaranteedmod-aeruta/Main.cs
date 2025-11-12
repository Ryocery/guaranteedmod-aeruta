using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using BepInEx.Logging;
using HarmonyLib;

namespace abundance_aeruta;

public static class Plugin {
    public const string Guid = "com.ryocery.guaranteedmod_aeruta";
    public const string Name = "Guaranteed Modification";
    public const string Version = "1.0.0";
}

[BepInPlugin(Plugin.Guid, Plugin.Name, Plugin.Version)]
public class GuaranteedModification : BasePlugin {
    internal new static ManualLogSource Log { get; private set; } = null!;
    private static Harmony _harmony = null!;
    
    internal static ConfigEntry<float> ModificationChance { get; private set; } = null!;

    public override void Load() {
        Log = base.Log;
        ModificationChance = Config.Bind("Main", "Modification Chance", 100.0f, "Set the chance (in percent) for modification to succeed.");
        
        _harmony = new Harmony(Plugin.Guid);
        _harmony.PatchAll();

        Log.LogInfo($"Modification chance set to {ModificationChance.Value}%");
        Log.LogInfo($"Plugin {Plugin.Guid} is loaded!");
    }
}

