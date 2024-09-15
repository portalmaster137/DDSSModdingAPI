using DDSSModdingAPI.Attributes;
using MelonLoader;

[assembly: MelonInfo(typeof(DDSSModdingAPI.ModdingAPI), "DDSSModdingAPI", "1.0.0", "Porta")]
[assembly: MelonGame("StripedPandaStudios", "DDSS")]
[assembly: MelonPriority(-100)]

namespace DDSSModdingAPI;


public class ModdingAPI : MelonMod
{
    
}