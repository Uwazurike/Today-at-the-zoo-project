using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Today_at_the_zoo_project
{
   public class Snake: Reptiles
    {
        #region variables
        private bool isFast;
        private bool isPoisenous;
        #endregion

        #region Properties

        public bool IsFast
        {
            get
            {
                return isFast;
            }
            set
            {
                if (!isFast && value == false)
                {
                    isFast = true;
                }
                else if (isFast && value == false)
                {
                    isFast = false;
                }
            }
        }

        public bool IsPoisenous
        {
            get
            {
                return isPoisenous;
            }
            set
            {
                if (!isPoisenous && value == false)
                {
                    isPoisenous = true;
                }
                else if (isPoisenous && value == false)
                {
                    isPoisenous = false;
                }
            }
        }
        #endregion
    }
}
