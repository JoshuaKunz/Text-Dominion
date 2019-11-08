﻿using Text_Dominion.Components.Card.Abstraction;
using Text_Dominion.Player.Interface;

namespace Text_Dominion.Database.BaseSet
{
    public class Copper : ICard
    {
        public const byte Cost = 0;
        public const byte PlayValue = 1;
        public const string Type = "Treasure";

        public void Buy(IPlayer activePlayer)
        {
            activePlayer.Treasure -= Cost;
        }

        public void Play(IPlayer player)
        {
            player.Treasure += PlayValue;
        }
    }
}
