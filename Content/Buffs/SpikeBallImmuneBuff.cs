using AncTeBasic.Content.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace AncTeBasic.Content.Buffs;

public class SpikeBallImmuneBuff : ModBuff
{
    public override void Update(Player player, ref int buffIndex)
    {
        if (player.TryGetModPlayer(out BuffPlayer modPlayer))
        {
            modPlayer.ImmuneSpikeBall = true;
        }
    }
}

