using System.Collections.Generic;
using Synapse;
using Synapse.Api;

namespace AFK_Synapse_
{
    class EventHandlers
    {
        public EventHandlers()
        {
            Server.Get.Events.Round.TeamRespawnEvent += Round_TeamRespawnEvent;
        }
        public static List<Player> afk_players = new List<Player>();
        private void Round_TeamRespawnEvent(Synapse.Api.Events.SynapseEventArguments.TeamRespawnEventArgs ev)
        {
            foreach(Player ply in ev.Players)
            {
                if (afk_players.Contains(ply))
                {
                    ev.Players.Remove(ply);
                }
            }
        }
    }
}
