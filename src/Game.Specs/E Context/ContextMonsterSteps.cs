using FluentAssertions;
using Game.Monsters;
using TechTalk.SpecFlow;

namespace Game.Specs.E_Context
{
    [Binding]
    [Scope(Feature = "Context")]
    public class ContextMonsterSteps
    {
        private readonly GameContext _context;

        public ContextMonsterSteps(GameContext context)
        {
            _context = context;
        }

        [When(@"a monster with strength of (.*) attack him")]
        public void WhenAMonsterWithStrengthOfAttackHim(int strength)
        {
            var monster = new Monster { Strength = strength };
            monster.Attack(_context.Player);
        }
    }
}
