
using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace NoAutoAttack
{
    class NoAttackGlobalItem : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            item.autoReuse = false;
            if(GetInstance<FastAttackConfig>().fastAttack)
            {
                item.useTime = 0;
                item.useAnimation = 0;
            }
        }
    }
}
