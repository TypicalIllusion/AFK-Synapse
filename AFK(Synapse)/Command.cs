using Synapse.Api;
using Synapse.Command;

namespace AFK_Synapse_
{
    [CommandInformation(
    Name = "AFK",
    Aliases = new[] { "a" },
    Description = "AFK to prevent AFK kicking",
    Permission = "",
    Platforms = new[] { Platform.ClientConsole },
    Usage = ".afk"
        )]
    class Command : ISynapseCommand
    {
        public CommandResult Execute(CommandContext context)
        {
            var result = new CommandResult();
            Player p = context.Player;
            if (EventHandlers.afk_players.Contains(p) == false)
            {
                EventHandlers.afk_players.Add(p);
                result.Message = Plugin.Config.AddedToAFK;
                result.State = CommandResultState.Ok;
                return result;
            }
            else
            {
                EventHandlers.afk_players.Remove(p);
                result.Message = Plugin.Config.RemovedFromAFK;
                result.State = CommandResultState.Ok;
                return result;
            }
        }
    }
}
