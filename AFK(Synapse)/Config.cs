using Synapse.Config;
using System.ComponentModel;

namespace AFK_Synapse_
{
    public class Config : AbstractConfigSection
    {
        [Description("How many players until the plugin doesnt work?")]
        public int PlayerLimit { get; set; } = 10;
        [Description("What is the message given to a player when they are added to afk players?")]
        public string AddedToAFK { get; set; } = "You have been added to afk players.\nYou will not respawn.";

        [Description("What is the message given to a player when they are removed from afk players?")]
        public string RemovedFromAFK { get; set; } = "You have been removed from afk players.\nYou may now respawn.";
    }
}
