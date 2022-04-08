using Server.Engines.Craft;

namespace Server.Items
{
    [Flipable(0x1030, 0x1031)]
    public class JointingPlane : BaseTool
    {
        [Constructible]
        public JointingPlane()
            : base(0x1030)
        {
            Weight = 2.0;
        }

        [Constructible]
        public JointingPlane(int uses)
            : base(uses, 0x1030)
        {
            Weight = 2.0;
        }

        public JointingPlane(Serial serial)
            : base(serial)
        {
        }

        public override CraftSystem CraftSystem => DefCarpentry.CraftSystem;
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