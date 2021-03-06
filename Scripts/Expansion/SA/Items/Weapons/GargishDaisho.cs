using System;

namespace Server.Items
{
    //Bassed Off Daisho
    [Flipable(0x48D0, 0x48D1)]
    public class GargishDaisho : BaseSword
    {
        [Constructable]
        public GargishDaisho()
            : base(0x48D0)
        {
            Weight = 8.0;
            Layer = Layer.TwoHanded;
        }

        public GargishDaisho(Serial serial)
            : base(serial)
        {
        }

        public override WeaponAbility PrimaryAbility => WeaponAbility.Feint;
        public override WeaponAbility SecondaryAbility => WeaponAbility.DoubleStrike;
        public override int AosStrengthReq => 40;
        public override int AosMinDamage => 13;
        public override int AosMaxDamage => 16;
        public override int AosSpeed => 40;
        public override float MlSpeed => 2.75f;
        public override int OldStrengthReq => 40;
        public override int OldMinDamage => 13;
        public override int OldMaxDamage => 15;
        public override int OldSpeed => 40;
        public override int DefHitSound => 0x23B;
        public override int DefMissSound => 0x23A;
        public override int InitMinHits => 45;
        public override int InitMaxHits => 65;
        public override Race RequiredRace => Race.Gargoyle;
        public override bool CanBeWornByGargoyles => true;
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}