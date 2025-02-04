using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncTeBasic.Content.Items.Potions;

public class SpikeImmunePotion : ModItem
{
    public override void SetStaticDefaults()
    {
        Item.ResearchUnlockCount = 20;

        // Dust that will appear in these colors when the item with ItemUseStyleID.DrinkLiquid is used
        ItemID.Sets.DrinkParticleColors[Type] = [
            new Color(240, 240, 240),
            new Color(200, 200, 200),
            new Color(140, 140, 140)
        ];
    }

    public override void SetDefaults()
    {
        Item.width = 20;
        Item.height = 26;
        Item.useStyle = ItemUseStyleID.DrinkLiquid;
        Item.useAnimation = 15;
        Item.useTime = 15;
        Item.useTurn = true;
        Item.UseSound = SoundID.Item3;
        Item.maxStack = Item.CommonMaxStack;
        Item.consumable = true;
        Item.rare = ItemRarityID.Orange;
        Item.SetShopValues(ItemRarityColor.Blue1, Item.buyPrice(gold: 1));
        Item.buffType = ModContent.BuffType<Buffs.SpikeImmuneBuff>(); // Specify an existing buff to be applied when used.
        Item.buffTime = 10800; // The amount of time the buff declared in Item.buffType will last in ticks. 5400 / 60 is 90, so this buff will last 90 seconds.
    }

    public override void AddRecipes()
    {
        base.AddRecipes();
    }
}

