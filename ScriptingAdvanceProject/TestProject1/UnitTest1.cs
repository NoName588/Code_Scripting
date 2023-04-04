using System;
using ScriptingAdvanceProject;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PlayerDiesWhenEncountersStrongerEnemy()
        {
            
            var player = new PlayerP();
            var strongerEnemy = new EnemyP();
            strongerEnemy.powerLvl = player.powerLvl + 1;

            
            var playerSurvives = player.CompareLvl(strongerEnemy);

            
            Assert.IsFalse(playerSurvives);
        }
    }
}