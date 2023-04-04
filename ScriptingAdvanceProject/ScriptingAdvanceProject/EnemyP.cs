using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingAdvanceProject
{
    public class EnemyP : Character
    {
        
            public int powerLvl { get; set; }

            public EnemyP(int powerLvl)
            {
                this.powerLvl = powerLvl;
            }
        
    }
}
