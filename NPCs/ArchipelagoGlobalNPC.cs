using SpikersArchipelago.Systems;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpikersArchipelago.NPCs
{
    [ExtendsFromMod("CalamityMod")]
    public class ArchipelagoGlobalNPC : GlobalNPC
    {
        public override void OnKill(NPC npc)
        {
            if (ModLoader.HasMod("CalamityMod"))
                CalamityOnKill(npc.type);
        }

        void CalamityOnKill(int npc)
        {
            var spikersArchipelago = ModContent.GetInstance<ArchipelagoSystem>();

            if (npc == NPCID.BloodNautilus)
                spikersArchipelago.QueueLocation("Dreadnautilus");
            else if (npc == ModContent.NPCType<CalamityMod.NPCs.PrimordialWyrm.PrimordialWyrmHead>())
                spikersArchipelago.QueueLocation("Primordial Wyrm");
        }
    }
}
