using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingAdvanceProject
{
    public class TrapShip
    {

        PlayerP player = new PlayerP();
        
        ObjectP objectP = new ObjectP();
        int room = 0;
       public int lvlAcces = 0;

        public TrapShip(PlayerP playerP, ObjectP obj)
        {
            this.player = playerP;
            
            this.objectP = obj;
        }

       public bool CompareLvlAcces()
        {
            if (lvlAcces <= player.powerLvl)
                return true;
            else
                return false;
        }
    }
}
