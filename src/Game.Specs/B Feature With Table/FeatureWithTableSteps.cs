using FluentAssertions;
using Game.Monsters;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Game.Specs.B_Feature_With_Table
{
    [Binding]
    [Scope(Feature = "Feature With Table")]
    public class FeatureWithTableSteps
    {
        private Player _player;

        [Given(@"I have player with (.*) HP")]
        public void GivenIHavePlayerWithHP(int hp)
        {
            _player = new Player { HealthPoints = hp };
        }

        [When(@"folowing monsters attack him")]
        public void WhenFolowingMonstersattackHim(Table table)
        {
            foreach (var row in table.Rows)
            {
                var monster = new Monster { Strength = int.Parse(row[1]) };
                monster.Attack(_player);
            }
        }

        [Then(@"player HP should be (.*) HP")]
        public void ThenPlayerHPShouldBeHP(int expectedHp)
        {
            _player.HealthPoints.Should().Be(expectedHp);
        }
    }
}