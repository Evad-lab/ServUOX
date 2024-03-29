﻿using Server;
using System;

namespace Server.Items
{
    public class CullingBlade : BoneHarvester
    {
        public override int LabelNumber => 1116630;

        public override int InitMinHits => 255;
        public override int InitMaxHits => 255;

        [Constructible]
        public CullingBlade()
        {
            WeaponAttributes.HitManaDrain = 30;
            WeaponAttributes.HitFatigue = 30;
            WeaponAttributes.HitLowerDefend = 40;
            Attributes.RegenHits = 3;
            Attributes.WeaponSpeed = 20;
            Attributes.WeaponDamage = 50;
        }

        public override void GetDamageTypes(Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int chaos, out int direct)
        {
            phys = fire = cold = nrgy = pois = direct = 0;
            chaos = 100;
        }

        public CullingBlade(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}