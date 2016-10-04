using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Today_at_the_zoo_project
{
   public class Scorpions: Arachnids
    {
        #region variables
        private bool hasStealth;
        private bool hasStinger;
        #endregion

        #region Properties

        public bool HasStealth
        {
            get
            {
                return hasStealth;
            }
            set
            {
                if (!hasStealth && value == false)
                {
                    hasStealth = true;
                }
                else if (hasStealth && value == false)
                {
                    hasStealth = false;
                }
            }
        }

        public bool HasStinger
        {
            get
            {
                return hasStinger;
            }
            set
            {
                if (!hasStinger && value == false)
                {
                    hasStinger = true;
                }
                else if (hasStinger && value == false)
                {
                    hasStinger = false;
                }
            }
        }
        #endregion
    }
}
