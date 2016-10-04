using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Today_at_the_zoo_project
{
   public class Hippo: Mammals
    {
        #region variables
        private bool livesInWater;
        private bool attacksHumans;
        #endregion

        #region Properties

        public bool LivesInWater
        {
            get
            {
                return livesInWater;
            }
            set
            {
                if (!livesInWater && value == false)
                {
                    livesInWater = true;
                }
                else if (livesInWater && value == false)
                {
                    livesInWater = false;
                }
            }
        }

        public bool AttacksHumans
        {
            get
            {
                return attacksHumans;
            }
            set
            {
                if (!attacksHumans && value == false)
                {
                    attacksHumans = true;
                }
                else if (attacksHumans && value == false)
                {
                    attacksHumans = false;
                }
            }
        }
        #endregion
    }
}
