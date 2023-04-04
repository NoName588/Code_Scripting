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
        
        public int[] position { get; set; }

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
