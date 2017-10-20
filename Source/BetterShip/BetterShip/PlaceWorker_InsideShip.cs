using RimWorld;
using Verse;

namespace BetterShip
{
    public class PlaceWorker_InsideShip : PlaceWorker
    {
        public override AcceptanceReport AllowsPlacing(BuildableDef checkingDef, IntVec3 loc, Rot4 rot, Thing thingToIgnore = null)
        {
            if(loc.GetTerrain(Map) == ShipPartsDefOf.ShipFloor)
            {
                return true;
            }
            else
            {
                return new AcceptanceReport("MustPlaceOnShipHull".Translate());
            }
        }
    }
}
