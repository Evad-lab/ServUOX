using System;

namespace Server.Items
{
    public class TrueAssassinSpike : AssassinSpike
    {
        public override bool IsArtifact => true;
        [Constructible]
        public TrueAssassinSpike()
        {
            Attributes.AttackChance = 4;
            Attributes.WeaponDamage = 4;
        }

        public TrueAssassinSpike(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber => 1073517;// true assassin spike
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }
}