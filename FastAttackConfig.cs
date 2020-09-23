using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Terraria.UI;

namespace NoAutoAttack
{
    public class FastAttackConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        [DefaultValue(false)]
        [Label("Enable no use delay")]
        [Tooltip("Gives all items a use time of 0, meaning you can attack as fast as you can click.\nWARNING: Can make some items very overpowered.")]
        [ReloadRequired]
        public bool fastAttack;
    }
}
