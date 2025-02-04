using AncTeBasic.Content.Players;
using Terraria;
using Terraria.ModLoader;

namespace AncTeBasic.Content.Buffs;

public class BlazingWheelImmuneBuff : ModBuff
{
    public override void Update(Player player, ref int buffIndex)
    {
        if (player.TryGetModPlayer(out BuffPlayer modPlayer))
        {
            modPlayer.ImmuneBlazingWheel = true;
        }
    }
}

