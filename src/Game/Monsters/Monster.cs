namespace Game.Monsters
{
    public class Monster
    {
        public int Strength { get; set; }
        public string Name { get; set; }

        public void Attack(Player player)
        {
            player.HealthPoints -= Strength;
        }
    }
}