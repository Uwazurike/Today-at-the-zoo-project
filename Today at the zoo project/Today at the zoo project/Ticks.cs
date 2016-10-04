using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Today_at_the_zoo_project
{
   public class Ticks: Arachnids
    {
        #region variables
        private bool sucksBlood;
        private bool liveInDogs;
        #endregion

        #region Properties

        public bool SucksBlood
        {
            get
            {
                return sucksBlood;
            }
            set
            {
                if (!sucksBlood && value == false)
                {
                    sucksBlood = true;
                }
                else if (sucksBlood && value == false)
                {
                    sucksBlood = false;
                }
            }
        }

        public bool LiveInDogs
        {
            get
            {
                return liveInDogs;
            }
            set
            {
                if (!liveInDogs && value == false)
                {
                    liveInDogs = true;
                }
                else if (liveInDogs && value == false)
                {
                    liveInDogs = false;
                }
            }
        }
        #endregion
    }
}
