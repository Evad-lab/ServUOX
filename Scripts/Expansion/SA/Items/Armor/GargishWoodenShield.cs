using System;

namespace Server.Items
{
    // Based off a WoodenShield
    [Flipable(0x4200, 0x4207)]
    public class GargishWoodenShield : BaseShield
    {
        public override bool IsArtifact => true;
        [Constructible]
        public GargishWoodenShield()
            : base(0x4200)
        {
            //Weight = 5.0;
        }

        public GargishWoodenShield(Serial serial)
            : base(serial)
        {
        }

        public override int BasePhysicalResistance => 0;
        public override int BaseFireResistance => 0;
        public override int BaseColdResistance => 0;
        public override int BasePoisonResistance => 0;
        public override int BaseEnergyResistance => 1;
        public override int InitMinHits => 20;
        public override int InitMaxHits => 25;
        public override int AosStrReq => 20;
        public override int ArmorBase => 8;
        public override bool CanBeWornByGargoyles => true;
        public override Race RequiredRace => Race.Gargoyle;
        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);//version
        }
    }
}