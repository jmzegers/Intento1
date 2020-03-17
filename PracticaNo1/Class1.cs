using System;

namespace PracticaNo1
{
    public class Combatant
    {
        protected string name;
        protected int level;
        protected int abilityLevel;
        protected string faction;

        protected void Attack()
        {
            Console.WriteLine("Ataca!");
        }
        protected void SpecialAttack()
        {
            Console.WriteLine("Toma esto! Ataque especial!");
        }
        protected void Defend()
        {
            Console.WriteLine("Me defiendo!");
        }

        protected class Armor
        {
            private int ArmorPoints;
            protected class Armor1
            {

            }
            protected class Armor2
            {

            }
            protected class Armor3
            {

            }
        }

        protected class Weapon
        {
            private int damage;
            protected class WeaponClass1
            {
                private void Ability1()
                {

                }
            }
            protected class WeaponClass2
            {
                private void Ability2()
                {

                }
            }
            protected class WeaponClass3
            {
                private void Ability3()
                {

                }
            }
            protected class WeaponClass4
            {
                private void Ability4()
                {

                }
            }
        }

        public class Magical
        {
            public class Mage
            {

            }
            public class Necromancer
            {

            }
            public class Druid
            {

            }
        }
        public class nonMagical
        {
            public class Warrior
            {

            }
            public class Knight
            {

            }
            public class Assassin
            {

            }
        }
    }
}