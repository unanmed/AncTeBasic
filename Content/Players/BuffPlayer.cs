using Terraria.DataStructures;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace AncTeBasic.Content.Players;

public class BuffPlayer : ModPlayer
{
    public bool ImmuneSpikeDamage = false;
    public bool ImmuneSpikeBall = false;
    public bool ImmuneBlazingWheel = false;

    public override void ResetEffects()
    {
        ImmuneSpikeDamage = false;
        ImmuneSpikeBall = false;
        base.ResetEffects();
    }

    public override bool CanBeHitByNPC(NPC npc, ref int cooldownSlot)
    {
        if (Player == Main.LocalPlayer)
        {
            if (npc.type == NPCID.SpikeBall && ImmuneSpikeBall)
            {
                return false;
            }
            if (npc.type == NPCID.BlazingWheel && ImmuneBlazingWheel)
            {
                return false;
            }
        }
        return base.CanBeHitByNPC(npc, ref cooldownSlot);
    }

    public override bool ImmuneTo(PlayerDeathReason damageSource, int cooldownCounter, bool dodgeable)
    {
        if (Player == Main.LocalPlayer)
        {
            if (damageSource.SourceOtherIndex == 3 && ImmuneSpikeDamage)
            {
                return true;
            }
        }
        return base.ImmuneTo(damageSource, cooldownCounter, dodgeable);
    }
}

