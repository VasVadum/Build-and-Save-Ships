using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;

namespace BetterShip
{
    public class RoomRoleWorker_ShipInterior : RoomRoleWorker
    {
        public override float GetScore(Room room)
        {
            if(room.OpenRoofCount > 0)
            {
                return 0f;
            }

            int num = 0;
            List<Thing> containedAndAdjacentThings = room.ContainedAndAdjacentThings;
            for (int i = 0; i < containedAndAdjacentThings.Count; i++)
            {
                Thing thing = containedAndAdjacentThings[i];
                if(HelperUtils.isShipHull(thing.def))
                {
                    num++;
                }
            }

            if(num >= room.BorderCells.Count())
            {
                return 1000000f;
            }
            return 0f;
        }
    }
}
