// ReSharper disable ArrangeAccessorOwnerBody
// ReSharper disable ConvertToAutoProperty
using Game.Potions;

namespace Game
{
    public class Player
    {
        private int _healthPoints;

        public int HealthPoints
        {
            get => _healthPoints;
            set
            {
                _healthPoints = value;
            }
        }

        public void Use(HealthPotion potion)
        {
            HealthPoints += potion.HealthValue;
        }
    }
}