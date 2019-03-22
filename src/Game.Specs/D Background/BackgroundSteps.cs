using FluentAssertions;
using Game.Monsters;
using Game.Potions;
using TechTalk.SpecFlow;

namespace Game.Specs.D_Background
{
    [Binding]
    [Scope(Feature = "Background")]
    public class BackgroundSteps
    {
        private Player _player;

        [Given(@"I have player with (.*) HP")]
        public void GivenIHavePlayerWithHP(int hp)
        {
            _player = new Player { HealthPoints = hp };
        }

        [When(@"a monster with strength of (.*) attack him")]
        public void WhenAMonsterWithStrengthOfAttackHim(int strength)
        {
            var monster = new Monster { Strength = strength };
            monster.Attack(_player);
        }

        [When(@"player use a Health Potion")]
        public void WhenPlayerUseAHealthPotion()
        {
            var potion = new HealthPotion();
            _player.Use(potion);
        }

        [Then(@"player HP should be (.*) HP")]
        public void ThenPlayerHPShouldBeHP(int expectedHp)
        {
            _player.HealthPoints.Should().Be(expectedHp);
        }
    }
}
