namespace Server.Items
{
    public class BarrelSponge : BaseFish
    {
        [Constructible]
        public BarrelSponge()
            : base(0xA38A)
        {
        }

        public BarrelSponge(Serial serial)
            : base(serial)
        {
        }

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