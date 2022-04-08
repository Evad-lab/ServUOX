using System;

namespace Server.Items
{
    public class SAStoneWall2South : DamageableItem
    {
        [Constructible]
        public SAStoneWall2South()
            : base(88, 631)
        {
            Name = "Stone Wall";

            Level = ItemLevel.VeryEasy;
            Movable = false;
        }

        public SAStoneWall2South(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); //version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }

    public class SAStoneWall2East : DamageableItem
    {
        [Constructible]
        public SAStoneWall2East()
            : base(87, 636)
        {
            Name = "Stone Wall";

            Level = ItemLevel.VeryEasy;
            Movable = false;
        }

        public SAStoneWall2East(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); //version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}