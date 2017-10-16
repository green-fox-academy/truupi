using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrier
{
    class Aircraft : Carrier
    {
        protected int baseDamage, maxAmmo, currentAmmo;
        protected string type;

        public int Fight()
        {
            int fightAmmo = GetCurrentAmmo();
            currentAmmo = 0;
            return GetBaseDamage() * fightAmmo;
        }

        public int Refill(int inputAmmo)
        {
            currentAmmo = maxAmmo;
            return inputAmmo - maxAmmo;
        }

        public string GetAircraftType()
        {
            return type;
        }

        public string GetStatus()
        {
            return $"Type {GetAircraftType()}, Base Damage: {GetBaseDamage()}, All damage: {GetBaseDamage() * GetCurrentAmmo()}";
        }

        private int GetBaseDamage()
        {
            return baseDamage;
        }

        private int GetCurrentAmmo()
        {
            return currentAmmo;
        }
    }
}
