using System;
using Server.Engines.VeteranRewards;

namespace Server.Items
{
    public class ZooMemberSkirt : PlainDress
    {
        public override int LabelNumber => 1073221; // Britannia Royal Zoo Member

        [Constructable]
        public ZooMemberSkirt()
            : this(0)
        {
        }

        [Constructable]
        public ZooMemberSkirt(int hue)
            : base(hue)
        {
        }

        public ZooMemberSkirt(Serial serial)
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

    public class ZooMemberBodySash : BodySash
    {
        public override int LabelNumber => 1073221; // Britannia Royal Zoo Member

        [Constructable]
        public ZooMemberBodySash()
            : this(0)
        {
        }

        [Constructable]
        public ZooMemberBodySash(int hue)
            : base(hue)
        {
        }

        public ZooMemberBodySash(Serial serial)
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

    public class ZooMemberRobe : Robe
    {
        public override int LabelNumber => 1073221; // Britannia Royal Zoo Member

        [Constructable]
        public ZooMemberRobe()
            : this(0)
        {
        }

        [Constructable]
        public ZooMemberRobe(int hue)
            : base(hue)
        {
        }

        public ZooMemberRobe(Serial serial)
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

    public class ZooMemberCloak : Cloak
    {
        public override int LabelNumber => 1073221; // Britannia Royal Zoo Member

        [Constructable]
        public ZooMemberCloak()
            : this(0)
        {
        }

        [Constructable]
        public ZooMemberCloak(int hue)
            : base(hue)
        {
        }

        public ZooMemberCloak(Serial serial)
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

    public class LibraryFriendBodySash : BodySash
    {
        public override int LabelNumber => 1073346; // Friends of the Library Sash

        [Constructable]
        public LibraryFriendBodySash()
            : this(0)
        {
        }

        [Constructable]
        public LibraryFriendBodySash(int hue)
            : base(hue)
        {
        }

        public LibraryFriendBodySash(Serial serial)
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

    public class LibraryFriendDoublet : Doublet
    {
        public override int LabelNumber => 1073351; // Friends of the Library Doublet

        [Constructable]
        public LibraryFriendDoublet()
            : this(0)
        {
        }

        [Constructable]
        public LibraryFriendDoublet(int hue)
            : base(hue)
        {
        }

        public LibraryFriendDoublet(Serial serial)
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

    public class LibraryFriendSurcoat : Surcoat
    {
        public override int LabelNumber => 1073348; // Friends of the Library Surcoat

        [Constructable]
        public LibraryFriendSurcoat()
            : this(0)
        {
        }

        [Constructable]
        public LibraryFriendSurcoat(int hue)
            : base(hue)
        {
        }

        public LibraryFriendSurcoat(Serial serial)
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

    public class LibraryFriendCloak : Cloak
    {
        public override int LabelNumber => 1073350; // Friends of the Library Cloak

        [Constructable]
        public LibraryFriendCloak()
            : this(0)
        {
        }

        [Constructable]
        public LibraryFriendCloak(int hue)
            : base(hue)
        {
        }

        public LibraryFriendCloak(Serial serial)
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

    public class Adranath : BodySash
    {
        public override int LabelNumber => 1073253;// Adranath - Museum of Vesper Replica

        [Constructable]
        public Adranath()
            : this(0)
        {
        }

        [Constructable]
        public Adranath(int hue)
            : base(hue)
        {
        }

        public Adranath(Serial serial)
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

    public class OdricsRobe : Robe
    {
        public override int LabelNumber => 1073250;// Odric's Robe - Museum of Vesper Replica

        [Constructable]
        public OdricsRobe()
            : this(0)
        {
        }

        [Constructable]
        public OdricsRobe(int hue)
            : base(hue)
        {
        }

        public OdricsRobe(Serial serial)
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

    public class BaronLenshiresCloak : Cloak
    {
        public override int LabelNumber => 1073252;// Baron Lenshire's Cloak - Museum of Vesper Replica

        [Constructable]
        public BaronLenshiresCloak()
            : this(0)
        {
        }

        [Constructable]
        public BaronLenshiresCloak(int hue)
            : base(hue)
        {
        }

        public BaronLenshiresCloak(Serial serial)
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

    [Flipable]
    public class RewardRobe : BaseOuterTorso, IRewardItem
    {
        private int m_LabelNumber;
        private bool m_IsRewardItem;

        [CommandProperty(AccessLevel.GameMaster)]
        public bool IsRewardItem
        {
            get
            {
                return m_IsRewardItem;
            }
            set
            {
                m_IsRewardItem = value;
            }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public int Number
        {
            get
            {
                return m_LabelNumber;
            }
            set
            {
                m_LabelNumber = value;
                InvalidateProperties();
            }
        }

        public override int LabelNumber
        {
            get
            {
                if (m_LabelNumber > 0)
                    return m_LabelNumber;

                return base.LabelNumber;
            }
        }

        public override int BasePhysicalResistance => 3;

        public override void OnAdded(object parent)
        {
            base.OnAdded(parent);

            if (parent is Mobile)
                ((Mobile)parent).VirtualArmorMod += 2;
        }

        public override void OnRemoved(object parent)
        {
            base.OnRemoved(parent);

            if (parent is Mobile)
                ((Mobile)parent).VirtualArmorMod -= 2;
        }

        public override bool Dye(Mobile from, DyeTub sender)
        {
            from.SendLocalizedMessage(sender.FailMessage);
            return false;
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);

            if (Core.ML && m_IsRewardItem)
                list.Add(RewardSystem.GetRewardYearLabel(this, new object[] { Hue, m_LabelNumber })); // X Year Veteran Reward
        }

        public override bool CanEquip(Mobile m)
        {
            if (!base.CanEquip(m))
                return false;

            return !m_IsRewardItem || RewardSystem.CheckIsUsableBy(m, this, new object[] { Hue, m_LabelNumber });
        }

        [Constructable]
        public RewardRobe()
            : this(0)
        {
        }

        [Constructable]
        public RewardRobe(int hue)
            : this(hue, 0)
        {
        }

        [Constructable]
        public RewardRobe(int hue, int labelNumber)
            : base(0x1F03, hue)
        {
            Weight = 3.0;
            LootType = LootType.Blessed;

            m_LabelNumber = labelNumber;
        }

        public RewardRobe(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version

            writer.Write(m_LabelNumber);
            writer.Write(m_IsRewardItem);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch (version)
            {
                case 0:
                    {
                        m_LabelNumber = reader.ReadInt();
                        m_IsRewardItem = reader.ReadBool();
                        break;
                    }
            }

            if (Parent is Mobile)
                ((Mobile)Parent).VirtualArmorMod += 2;
        }
    }

    [Flipable]
    public class RewardDress : BaseOuterTorso, IRewardItem
    {
        private int m_LabelNumber;
        private bool m_IsRewardItem;

        [CommandProperty(AccessLevel.GameMaster)]
        public bool IsRewardItem
        {
            get
            {
                return m_IsRewardItem;
            }
            set
            {
                m_IsRewardItem = value;
            }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public int Number
        {
            get
            {
                return m_LabelNumber;
            }
            set
            {
                m_LabelNumber = value;
                InvalidateProperties();
            }
        }

        public override int LabelNumber
        {
            get
            {
                if (m_LabelNumber > 0)
                    return m_LabelNumber;

                return base.LabelNumber;
            }
        }

        public override int BasePhysicalResistance => 3;

        public override void OnAdded(object parent)
        {
            base.OnAdded(parent);

            if (parent is Mobile)
                ((Mobile)parent).VirtualArmorMod += 2;
        }

        public override void OnRemoved(object parent)
        {
            base.OnRemoved(parent);

            if (parent is Mobile)
                ((Mobile)parent).VirtualArmorMod -= 2;
        }

        public override bool Dye(Mobile from, DyeTub sender)
        {
            from.SendLocalizedMessage(sender.FailMessage);
            return false;
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);

            if (m_IsRewardItem)
                list.Add(RewardSystem.GetRewardYearLabel(this, new object[] { Hue, m_LabelNumber })); // X Year Veteran Reward
        }

        public override bool CanEquip(Mobile m)
        {
            if (!base.CanEquip(m))
                return false;

            return !m_IsRewardItem || RewardSystem.CheckIsUsableBy(m, this, new object[] { Hue, m_LabelNumber });
        }

        [Constructable]
        public RewardDress()
            : this(0)
        {
        }

        [Constructable]
        public RewardDress(int hue)
            : this(hue, 0)
        {
        }

        [Constructable]
        public RewardDress(int hue, int labelNumber)
            : base(0x1F01, hue)
        {
            Weight = 2.0;
            LootType = LootType.Blessed;

            m_LabelNumber = labelNumber;
        }

        public RewardDress(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version

            writer.Write(m_LabelNumber);
            writer.Write(m_IsRewardItem);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch (version)
            {
                case 0:
                    {
                        m_LabelNumber = reader.ReadInt();
                        m_IsRewardItem = reader.ReadBool();
                        break;
                    }
            }

            if (Parent is Mobile)
                ((Mobile)Parent).VirtualArmorMod += 2;
        }
    }

    public class RewardGargishRobe : BaseOuterTorso, IRewardItem
    {
        public override Race RequiredRace => Race.Gargoyle;
        public override bool CanBeWornByGargoyles => true;

        private int m_LabelNumber;
        private bool m_IsRewardItem;

        [CommandProperty(AccessLevel.GameMaster)]
        public bool IsRewardItem { get { return m_IsRewardItem; } set { m_IsRewardItem = value; } }

        [CommandProperty(AccessLevel.GameMaster)]
        public int Number
        {
            get { return m_LabelNumber; }
            set
            {
                m_LabelNumber = value;
                InvalidateProperties();
            }
        }

        public override int LabelNumber
        {
            get
            {
                if (m_LabelNumber > 0)
                    return m_LabelNumber;

                return base.LabelNumber;
            }
        }

        public override int BasePhysicalResistance => 3;

        public override bool Dye(Mobile from, DyeTub sender)
        {
            from.SendLocalizedMessage(sender.FailMessage);
            return false;
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);

            if (m_IsRewardItem)
                list.Add(RewardSystem.GetRewardYearLabel(this, new object[] { Hue, m_LabelNumber })); // X Year Veteran Reward
        }

        public override bool CanEquip(Mobile m)
        {
            if (!base.CanEquip(m))
                return false;

            return !m_IsRewardItem || RewardSystem.CheckIsUsableBy(m, this, new object[] { Hue, m_LabelNumber });
        }

        [Constructable]
        public RewardGargishRobe()
            : this(0)
        {
        }

        [Constructable]
        public RewardGargishRobe(int hue)
            : this(hue, 0)
        {
        }

        [Constructable]
        public RewardGargishRobe(int hue, int labelNumber)
            : base(0x4000, hue)
        {
            Weight = 3.0;
            LootType = LootType.Blessed;

            m_LabelNumber = labelNumber;
        }

        public RewardGargishRobe(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version

            writer.Write(m_LabelNumber);
            writer.Write(m_IsRewardItem);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch (version)
            {
                case 0:
                    {
                        m_LabelNumber = reader.ReadInt();
                        m_IsRewardItem = reader.ReadBool();
                        break;
                    }
            }
        }
    }

    public class RewardGargishFancyRobe : BaseOuterTorso, IRewardItem
    {
        public override Race RequiredRace => Race.Gargoyle;
        public override bool CanBeWornByGargoyles => true;

        private int m_LabelNumber;
        private bool m_IsRewardItem;

        [CommandProperty(AccessLevel.GameMaster)]
        public bool IsRewardItem { get { return m_IsRewardItem; } set { m_IsRewardItem = value; } }

        [CommandProperty(AccessLevel.GameMaster)]
        public int Number
        {
            get { return m_LabelNumber; }
            set
            {
                m_LabelNumber = value;
                InvalidateProperties();
            }
        }

        public override int LabelNumber
        {
            get
            {
                if (m_LabelNumber > 0)
                    return m_LabelNumber;

                return base.LabelNumber;
            }
        }

        public override int BasePhysicalResistance => 3;

        public override bool Dye(Mobile from, DyeTub sender)
        {
            from.SendLocalizedMessage(sender.FailMessage);
            return false;
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);

            if (m_IsRewardItem)
                list.Add(RewardSystem.GetRewardYearLabel(this, new object[] { Hue, m_LabelNumber })); // X Year Veteran Reward
        }

        public override bool CanEquip(Mobile m)
        {
            if (!base.CanEquip(m))
                return false;

            return !m_IsRewardItem || RewardSystem.CheckIsUsableBy(m, this, new object[] { Hue, m_LabelNumber });
        }

        [Constructable]
        public RewardGargishFancyRobe()
            : this(0)
        {
        }

        [Constructable]
        public RewardGargishFancyRobe(int hue)
            : this(hue, 0)
        {
        }

        [Constructable]
        public RewardGargishFancyRobe(int hue, int labelNumber)
            : base(0x4002, hue)
        {
            Weight = 3.0;
            LootType = LootType.Blessed;

            m_LabelNumber = labelNumber;
        }

        public RewardGargishFancyRobe(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version

            writer.Write(m_LabelNumber);
            writer.Write(m_IsRewardItem);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch (version)
            {
                case 0:
                    {
                        m_LabelNumber = reader.ReadInt();
                        m_IsRewardItem = reader.ReadBool();
                        break;
                    }
            }
        }
    }

    public class MonkRobe : BaseOuterTorso
    {
        [Constructable]
        public MonkRobe()
            : this(0x21E)
        {
        }

        [Constructable]
        public MonkRobe(int hue)
            : base(0x2687, hue)
        {
            Weight = 1.0;
            StrRequirement = 0;
        }

        public override int LabelNumber => 1076584;// A monk's robe
        public override bool CanBeBlessed => false;
        public override bool Dye(Mobile from, DyeTub sender)
        {
            from.SendLocalizedMessage(sender.FailMessage);
            return false;
        }

        public MonkRobe(Serial serial)
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

    [Flipable(0x2799, 0x27E4)]
    public class Kamishimo : BaseOuterTorso
    {
        [Constructable]
        public Kamishimo()
            : this(0)
        {
        }

        [Constructable]
        public Kamishimo(int hue)
            : base(0x2799, hue)
        {
            Weight = 3.0;
        }

        public Kamishimo(Serial serial)
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

    [Flipable(0x279C, 0x27E7)]
    public class HakamaShita : BaseOuterTorso
    {
        [Constructable]
        public HakamaShita()
            : this(0)
        {
        }

        [Constructable]
        public HakamaShita(int hue)
            : base(0x279C, hue)
        {
            Weight = 3.0;
        }

        public HakamaShita(Serial serial)
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

    [Flipable(0x2782, 0x27CD)]
    public class MaleKimono : BaseOuterTorso
    {
        [Constructable]
        public MaleKimono()
            : this(0)
        {
        }

        [Constructable]
        public MaleKimono(int hue)
            : base(0x2782, hue)
        {
            Weight = 3.0;
        }

        public override bool AllowFemaleWearer => false;

        public MaleKimono(Serial serial)
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

    [Flipable(0x2783, 0x27CE)]
    public class FemaleKimono : BaseOuterTorso
    {
        [Constructable]
        public FemaleKimono()
            : this(0)
        {
        }

        [Constructable]
        public FemaleKimono(int hue)
            : base(0x2783, hue)
        {
            Weight = 3.0;
        }

        public override bool AllowMaleWearer => false;

        public FemaleKimono(Serial serial)
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

    [Flipable(0x2FB9, 0x3173)]
    public class MaleElvenRobe : BaseOuterTorso
    {
        public override Race RequiredRace => Race.Elf;

        [Constructable]
        public MaleElvenRobe()
            : this(0)
        {
        }

        [Constructable]
        public MaleElvenRobe(int hue)
            : base(0x2FB9, hue)
        {
            Weight = 2.0;
        }

        public MaleElvenRobe(Serial serial)
            : base(serial)
        {
        }

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

    [Flipable(0x2FBA, 0x3174)]
    public class FemaleElvenRobe : BaseOuterTorso
    {
        public override Race RequiredRace => Race.Elf;
        [Constructable]
        public FemaleElvenRobe()
            : this(0)
        {
        }

        [Constructable]
        public FemaleElvenRobe(int hue)
            : base(0x2FBA, hue)
        {
            Weight = 2.0;
        }

        public override bool AllowMaleWearer => false;

        public FemaleElvenRobe(Serial serial)
            : base(serial)
        {
        }

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

    public class FloweredDress : BaseOuterTorso
    {
        public override int LabelNumber => 1109622;  // Flowered Dress

        [Constructable]
        public FloweredDress()
            : this(0)
        {
        }

        [Constructable]
        public FloweredDress(int hue)
            : base(0x781E, hue)
        {
        }

        public FloweredDress(Serial serial)
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

    public class EveningGown : BaseOuterTorso
    {
        public override int LabelNumber => 1109625;  // Evening Gown

        [Constructable]
        public EveningGown()
            : this(0)
        {
        }

        [Constructable]
        public EveningGown(int hue)
            : base(0x7821, hue)
        {
        }

        public EveningGown(Serial serial)
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

    public class Epaulette : BaseClothing
    {
        public override int LabelNumber => 1123325;  // Epaulette

        [Constructable]
        public Epaulette()
            : this(0)
        {
        }

        [Constructable]
        public Epaulette(int hue)
            : base(0x9985, Layer.OuterTorso, hue)
        {
            Weight = 1.0;
        }

        public Epaulette(Serial serial)
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

    public class GargishEpaulette : BaseClothing
    {
        public override int LabelNumber => 1123326;  // Gargish Epaulette

        public override Race RequiredRace => Race.Gargoyle;
        public override bool CanBeWornByGargoyles => true;

        [Constructable]
        public GargishEpaulette()
            : this(0)
        {
        }

        [Constructable]
        public GargishEpaulette(int hue)
            : base(0x9986, Layer.OuterTorso, hue)
        {
            Weight = 1.0;
        }

        public GargishEpaulette(Serial serial)
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

            if (Layer != Layer.OuterTorso)
                Layer = Layer.OuterTorso;
        }
    }
}
