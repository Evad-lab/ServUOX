namespace Server.Items
{
    public class FarmableCabbage : FarmableCrop
    {
        [Constructible]
        public FarmableCabbage()
            : base(GetCropID())
        {
        }

        public FarmableCabbage(Serial serial)
            : base(serial)
        {
        }

        public static int GetCropID()
        {
            return 3254;
        }

        public override Item GetCropObject()
        {
            Cabbage cabbage = new Cabbage
            {
                ItemID = Utility.Random(3195, 2)
            };

            return cabbage;
        }

        public override int GetPickedID()
        {
            return 3254;
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.WriteEncodedInt(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            _ = reader.ReadEncodedInt();
        }
    }
}