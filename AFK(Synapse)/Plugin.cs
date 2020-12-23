using Synapse.Api.Plugin;

namespace AFK_Synapse_
{
    [PluginInformation(
       Author = "TypicalIllusion",
       Description = "AFK",
       LoadPriority = 0,
       Name = "AFK",
       SynapseMajor = 2,
       SynapseMinor = 3,
<<<<<<< HEAD
       SynapsePatch = 1,
=======
       SynapsePatch = 0,
>>>>>>> e94e1c226622eceb8ac0d7466c6e3653af5c472d
       Version = "1.0.1"
   )]
    class Plugin : AbstractPlugin
    {
        [Synapse.Api.Plugin.Config(section = "AFK")]
        public static Config Config;
        public override void Load()
        {
            SynapseController.Server.Logger.Info("AFK Loaded");
            new EventHandlers();
        }
    }
}
