using System;

namespace Server.Items
{
    public abstract class BaseSpear : BaseMeleeWeapon
    {
        public BaseSpear(int itemID)
            : base(itemID)
        {
        }

        public BaseSpear(Serial serial)
            : base(serial)
        {
        }

        public override int DefHitSound => 0x23C;
        public override int DefMissSound => 0x238;
        public override SkillName DefSkill => SkillName.Fencing;
        public override WeaponType DefType => WeaponType.Piercing;
        public override WeaponAnimation DefAnimation => WeaponAnimation.Pierce2H;
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

        public override void OnHit(Mobile attacker, IDamageable defender, double damageBonus)
        {
            base.OnHit(attacker, defender, damageBonus);

            if (!Core.AOS && defender is Mobile && Layer == Layer.TwoHanded && (attacker.Skills[SkillName.Anatomy].Value / 400.0) >= Utility.RandomDouble())
            {
                ((Mobile)defender).SendMessage("You receive a paralyzing blow!"); // Is this not localized?
                ((Mobile)defender).Freeze(TimeSpan.FromSeconds(2.0));

                attacker.SendMessage("You deliver a paralyzing blow!"); // Is this not localized?
                attacker.PlaySound(0x11C);
            }

            if (!Core.AOS && defender is Mobile && Poison != null && PoisonCharges > 0)
            {
                --PoisonCharges;

                if (Utility.RandomDouble() >= 0.5) // 50% chance to poison
                {
                    ((Mobile)defender).ApplyPoison(attacker, Poison);
                }
            }
        }
    }
}