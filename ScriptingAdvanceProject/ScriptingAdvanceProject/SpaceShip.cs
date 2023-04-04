using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingAdvanceProject
{
    public class SpaceShip
    {
        int[,] size;
        int room = 0;
        public int[,] locationP;
        public int[,] locationE;

        public SpaceShip(int size)
        {
            locationP = new int[size, size];
            locationE = new int[size, size];
        }

        void CreatingSize(int height, int width)
        {
            size = new int[height, width];
        }
        public void PutCharacter(PlayerP character, int[] position)
        {

            character.position = position;
            locationP[position[0], position[1]] = 1;
        }

        public void PutEnemy(PlayerP enemy, int[] position)
        {

            locationE[position[0], position[1]] = enemy.powerLvl;
        }

        public bool VerifyEnemy(PlayerP character)
        {
            int P_enemy = locationE[character.position[0], character.position[1]];
            if (P_enemy > 0)
            {
                EnemyP enemy = new EnemyP(P_enemy);
                return character.CompareLvl(enemy);
            }
            return true;
        }
        bool RoomClear()
        {
            if (room == 0)
                return true;
            else
                return false;
        }
    }
}
