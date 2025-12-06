using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using static SpikersArchipelago.Systems.ArchipelagoSystem;

namespace SpikersArchipelago.HardmodeItem
{
    public class HardmodeStarter : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.DemonHeart);
        }

        public override bool CanUseItem(Player player) => !Main.hardMode;

        public override bool? UseItem(Player player)
        {
            ActivateHardmode();
            return true;
        }
    }
}
