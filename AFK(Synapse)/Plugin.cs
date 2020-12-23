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
       SynapsePatch = 1,
       Version = "1.0.2"
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
