namespace Server.Items
{
    public class GeoffreyCampAddon : BaseAddon
    {
        private static readonly int[,] m_AddOnSimpleComponents = new int[,] {
              {7864, 8, 9, 12}, {7135, 12, 3, 0}, {2960, 8, 9, 0}// 1	2	3	
			, {7135, 11, 2, 0}, {7135, 10, 3, 0}, {4148, 9, 9, 9}// 4	5	6	
			, {7135, 11, 4, 0}, {17100, 8, 3, 5}, {3728, -8, 14, 0}// 7	8	9	
			, {16933, -5, 17, 0}, {3730, -6, 17, 0}, {3731, -6, 16, 0}// 10	11	12	
			, {4132, -4, 0, 0}, {16933, -8, 12, 0}// 15	16	19	
			, {2591, -1, 8, 0}, {543, -1, 2, 0}, {4106, -6, -1, 0}// 20	21	22	
			, {543, 1, 2, 0}, {2592, 7, 3, 0}, {542, 0, 1, 0}// 23	24	25	
			, {2591, 3, 8, 0}, {542, 0, 3, 0}, {3734, 6, -8, 0}// 26	27	31	
			, {4106, -6, -3, 0}, {3732, 4, -8, 0}, {16933, 5, -7, 0}// 32	33	34	
			, {3733, 5, -8, 0}, {3727, -9, 14, 0}// 35	36	37	
			, {3726, -10, 14, 0}, {3723, -11, -13, 0}, {16933, -11, -16, 0}// 38	39	40	
			, {3725, -11, -15, 0}, {3724, -11, -14, 0}// 41	42	
		};



        public override BaseAddonDeed Deed => null;

        [Constructible]
        public GeoffreyCampAddon()
        {
            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
            {
                AddComponent(new AddonComponent(m_AddOnSimpleComponents[i, 0]), m_AddOnSimpleComponents[i, 1], m_AddOnSimpleComponents[i, 2], m_AddOnSimpleComponents[i, 3]);
            }

            AddComplexComponent(this, 17099, -1, 9, 6, 0, -1, "banner", 1);// 17
            AddComplexComponent(this, 6571, 0, 2, 10, 0, 0, "", 1);// 18
            AddComplexComponent(this, 9407, 0, 2, 0, 0, 0, "", 1);// 28

        }

        public GeoffreyCampAddon(Serial serial)
            : base(serial)
        {
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
            {
                ac.Name = name;
            }

            if (hue != 0)
            {
                ac.Hue = hue;
            }

            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
            {
                ac.Light = (LightType)lightsource;
            }

            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0); // Version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}