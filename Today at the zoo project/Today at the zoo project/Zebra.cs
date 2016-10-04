using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Today_at_the_zoo_project
{
   public class Zebra: Mammals
    {
        #region variables
        private bool hasBoots;
        private bool hasTwoHearts;
        #endregion

        #region Properties

        public bool HasBoots
        {
            get
            {
                return hasBoots;
            }
            set
            {
                if (!hasBoots && value == false)
                {
                    hasBoots = true;
                }
                else if (hasBoots && value == false)
                {
                    hasBoots = false;
                }
            }
        }

        public bool HasTwoHearts
        {
            get
            {
                return hasTwoHearts;
            }
            set
            {
                if (!hasTwoHearts && value == false)
                {
                    hasTwoHearts = true;
                }
                else if (hasTwoHearts && value == false)
                {
                    hasTwoHearts = false;
                }
            }
        }
        #endregion
    }
}
