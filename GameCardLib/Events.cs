using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLib;

namespace GameCardLib
{
    public class Events
    {
        public event EventHandler<PlayerEventArgs> PlayerEvent;

        public void OnHit(Player player, Card card)
        {
            PlayerEvent?.Invoke(this, new PlayerEventArgs { Info = player.Name1 + " has hit with card: " + card.cardToString() });
        }

        public void OnStand(Player player)
        {
            PlayerEvent?.Invoke(this, new PlayerEventArgs { Info = player.Name1 + " has standed" });
        }
    }
}
