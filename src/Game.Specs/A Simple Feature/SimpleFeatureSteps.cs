using FluentAssertions;
using Game.Monsters;
using TechTalk.SpecFlow;

namespace Game.Specs.A_Simple_Feature
{
    [Binding]
    [Scope(Feature = "Simple Feature")]
    public class SimpleFeatureSteps
    {
        private Player _player;

        [Given(@"I have player with (.*) HP")]
        public void GivenIHavePlayerWithHP(int hp)
        {
            _player = new Player { HealthPoints = hp };
        }

        [When(@"a monster with strength of (.*) attack him")]
        public void WhenAMonsterWithStrengthOfattackHim(int strength)
        {
            var monster = new Monster { Strength = strength };
            monster.Attack(_player);
        }

        [Then(@"player HP should be (.*) HP")]
        public void ThenPlayerHPShouldBe(int expectedHp)
        {
            _player.HealthPoints.Should().Be(expectedHp);
        }
    }
}