using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingAdvanceProject
{
    class SpaceShip
    {
        int[,] size;
        int room = 0;
        private int[,] ubicacionPersonaje;
        private int[,] ubicacionEnemigos;

        public SpaceShip(int tamano)
        {
            ubicacionPersonaje = new int[tamano, tamano];
            ubicacionEnemigos = new int[tamano, tamano];
        }

        void CreatingSize(int height, int width)
        {
            size = new int[height, width];
        }
        public void ColocarPersonaje(PlayerP personaje, int[] posicion)
        {

            personaje.Posicion = posicion;
            ubicacionPersonaje[posicion[0], posicion[1]] = 1;
        }

        public void ColocarEnemigo(PlayerP enemigo, int[] posicion)
        {

            ubicacionEnemigos[posicion[0], posicion[1]] = enemigo.powerLvl;
        }

        public bool VerificarEnemigo(PlayerP personaje)
        {
            int vidaEnemigo = ubicacionEnemigos[personaje.Posicion[0], personaje.Posicion[1]];
            if (vidaEnemigo > 0)
            {
                EnemyP enemigo = new EnemyP(vidaEnemigo);
                return personaje.CompareLvl(enemigo);
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
