using RimWorld;
using Verse;

namespace BetterShip
{
    [DefOf]
    public static class ShipPartsDefOf
    {
        public static ThingDef ShipBeam = ThingDef.Named("Ship_Beam");
        public static ThingDef ShipAutoDoor = ThingDef.Named("ShipAutodoor");
        public static ThingDef ModularShipBeam = ThingDef.Named("ModularShipBeam");

        public static TerrainDef ShipFloor = TerrainDef.Named("ShipHullTile");
    }
}
