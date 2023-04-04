using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingAdvanceProject
{
    public class Character
    {
        public int live = 1;
        public int powerLvl = 0;
        public int[] Posicion { get; set; }

        public void Move(int[] newPosition)
        {

        }

        bool IsAlive()
        {
            if (live == 1)
                return true;
            else
                return false;
        }
    }
}
