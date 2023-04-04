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

        [Test]
        public void AddObject_IncreasesPowerLevel()
        {
            // Arrange
            var player = new PlayerP();
            var objectP = new ObjectP();
            objectP.PowerLevel = 10;

            // Act
            player.objectP = objectP;
            player.AddObject();

            // Assert
            Assert.AreEqual(10, objectP.PowerLevel);
        }

        [Test]
        public void PlayerDiesWhenAccessLevelIsHigher()
        {
            // Arrange
            PlayerP player = new PlayerP();
            ObjectP objectP = new ObjectP();
            objectP.powerLvl = 10;
            TrapShip trapShip = new TrapShip(player, objectP);
            trapShip.lvlAcces = 15;

            // Act
            bool result = trapShip.CompareLvlAcces();

            // Assert
            Assert.IsFalse(result); // Player should die, so the result should be false
        }
    }
}