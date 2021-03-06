using Server.Engines.Craft;

namespace Server.Items
{
    [Alterable(typeof(DefTailoring), typeof(LeatherTalons), true)]
    [Flipable(0x170b, 0x170c)]
    public class Boots : BaseShoes
    {
        public override CraftResource DefaultResource => CraftResource.RegularLeather;

        [Constructable]
        public Boots()
            : this(0)
        {
        }

        [Constructable]
        public Boots(int hue)
            : base(0x170B, hue)
        {
            Weight = 3.0;
        }

        public Boots(Serial serial)
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
            _ = reader.ReadInt();
        }
    }
}
