using FluentAssertions;
using TechTalk.SpecFlow;

namespace Game.Specs.E_Context
{
    [Binding]
    [Scope(Feature = "Context")]
    public class ContextCommonSteps
    {
        private readonly GameContext _context;

        public ContextCommonSteps(GameContext context)
        {
            _context = context;
        }

        [Given(@"I have player with (.*) HP")]
        public void GivenIHavePlayerWithHP(int hp)
        {
            _context.Player = new Player { HealthPoints = hp };
        }

        [Then(@"player HP should be (.*) HP")]
        public void ThenPlayerHPShouldBe(int expectedHp)
        {
            _context.Player.HealthPoints.Should().Be(expectedHp);
        }
    }
}
