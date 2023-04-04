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
            var strongerEnemy = new EnemyP(player.powerLvl + 1); 

            var playerSurvives = player.CompareLvl(strongerEnemy);

            Assert.IsFalse(playerSurvives);
        }


        [Test]
        public void AddObject_IncreasesPowerLevel()
        {
            
            var player = new PlayerP();
            var objectP = new ObjectP();
            objectP.PowerLevel = 10;

            
            player.objectP = objectP;
            player.AddObject();

            
            Assert.AreEqual(10, objectP.PowerLevel);
        }

        [Test]
        public void PlayerDiesWhenAccessLevelIsHigher()
        {
            
            PlayerP player = new PlayerP();
            ObjectP objectP = new ObjectP();
            objectP.powerLvl = 10;
            TrapShip trapShip = new TrapShip(player, objectP);
            trapShip.lvlAcces = 15;

            
            bool result = trapShip.CompareLvlAcces();

            
            Assert.IsFalse(result); 
        }

        [Test]
        public void NewEnemy()
        {
            
            SpaceShip spaceship = new SpaceShip(5);
            PlayerP enemy = new PlayerP();
            enemy.powerLvl = 10;
            int[] posicion = { 2, 2 };

            
            spaceship.PutEnemy(enemy, posicion);

            
            int[,] expected = new int[5, 5];
            expected[2, 2] = 10;
            CollectionAssert.AreEqual(expected, spaceship.locationE);
        }

        [Test]
        public void SomeEnemy()
        {
            
            SpaceShip spaceship = new SpaceShip(5);
            PlayerP player = new PlayerP();
            player.position = new int[] { 2, 2 };
            PlayerP enemy = new PlayerP();
            enemy.powerLvl = 10;
            int[] position = { 2, 2 };
            spaceship.PutCharacter(player, player.position);
            spaceship.PutEnemy(enemy, position);

           
            bool actual = spaceship.VerifyEnemy(player);

            
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void NewCharacter()
        {
            // Arrange
            SpaceShip spaceship = new SpaceShip(5);
            PlayerP player = new PlayerP();
            int[] position = { 2, 2 };

            // Act
            spaceship.PutCharacter(player, position);

            // Assert
            int[,] expected = new int[5, 5];
            expected[2, 2] = 1;
            CollectionAssert.AreEqual(expected, spaceship.locationP);
        }
    }
}