using Server.Engines.Craft;

namespace Server.Items
{
    [Alterable(typeof(DefBlacksmithy), typeof(Shortblade))]
    [Flipable(0x2D2F, 0x2D23)]
    public class WarCleaver : BaseKnife
    {
        [Constructable]
        public WarCleaver()
            : base(0x2D2F)
        {
            Weight = 10.0;
            Layer = Layer.TwoHanded;
        }

        public WarCleaver(Serial serial)
            : base(serial)
        {
        }

        public override WeaponAbility PrimaryAbility => WeaponAbility.Disarm;
        public override WeaponAbility SecondaryAbility => WeaponAbility.Bladeweave;
        public override int AosStrengthReq => 15;
        public override int AosMinDamage => 10;
        public override int AosMaxDamage => 13;
        public override int AosSpeed => 48;
        public override float MlSpeed => 2.25f;
        public override int OldStrengthReq => 15;
        public override int OldMinDamage => 9;
        public override int OldMaxDamage => 11;
        public override int OldSpeed => 48;
        public override int DefHitSound => 0x23B;
        public override int DefMissSound => 0x239;
        public override int InitMinHits => 30;// TODO
        public override int InitMaxHits => 60;// TODO
        public override SkillName DefSkill => SkillName.Fencing;
        public override WeaponType DefType => WeaponType.Piercing;
        public override WeaponAnimation DefAnimation => WeaponAnimation.Pierce1H;
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.WriteEncodedInt(1);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            _ = reader.ReadEncodedInt();
        }
    }
}
