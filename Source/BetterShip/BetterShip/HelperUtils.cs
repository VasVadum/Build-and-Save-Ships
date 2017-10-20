using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using RimWorld;

namespace BetterShip
{
    class HelperUtils
    {
        public static bool isShipHull(ThingDef thing)
        {
            if(thing == ShipPartsDefOf.ShipBeam)
            {
                return true;
            }
            else if(thing == ShipPartsDefOf.ShipAutoDoor)
            {
                return true;
            }
            else if(thing == ShipPartsDefOf.ModularShipBeam)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
