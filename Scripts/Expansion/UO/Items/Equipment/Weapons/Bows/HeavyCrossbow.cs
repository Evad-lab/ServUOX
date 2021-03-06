using System;

namespace Server.Items
{
    [Flipable(0x13FD, 0x13FC)]
    public class HeavyCrossbow : BaseRanged
    {
        [Constructable]
        public HeavyCrossbow()
            : base(0x13FD)
        {
            Weight = 9.0;
            Layer = Layer.TwoHanded;
        }

        public HeavyCrossbow(Serial serial)
            : base(serial)
        {
        }

        public override int EffectID => 0x1BFE;
        public override Type AmmoType => typeof(Bolt);
        public override Item Ammo => new Bolt();
        public override WeaponAbility PrimaryAbility => WeaponAbility.MovingShot;
        public override WeaponAbility SecondaryAbility => WeaponAbility.Dismount;
        public override int AosStrengthReq => 80;
        public override int AosMinDamage => Core.ML ? 20 : 20;
        public override int AosMaxDamage => Core.ML ? 24 : 24;
        public override int AosSpeed => 22;
        public override float MlSpeed => 5.00f;
        public override int OldStrengthReq => 40;
        public override int OldMinDamage => 11;
        public override int OldMaxDamage => 56;
        public override int OldSpeed => 10;
        public override int DefMaxRange => 8;
        public override int InitMinHits => 31;
        public override int InitMaxHits => 100;
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            _ = reader.ReadInt();
        }
    }
}
