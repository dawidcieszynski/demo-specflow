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
                if (_healthPoints < 0)
                    _healthPoints = 0;
                if (_healthPoints > 100)
                    _healthPoints = 100;
            }
        }

        public void Use(HealthPotion potion)
        {
            HealthPoints += potion.HealthValue;
        }
    }
}