using FluentAssertions;
using Game.Monsters;
using TechTalk.SpecFlow;

namespace Game.Specs.C_Scenario_Outline
{
    [Binding]
    [Scope(Feature = "Scenario Outline")]
    public class ScenarioOutlineSteps
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

        [Then(@"player HP should be (.*) HP")]
        public void ThenPlayerHPShouldBeHP(int expectedHp)
        {
            _player.HealthPoints.Should().Be(expectedHp);
        }
    }
}