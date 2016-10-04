using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Today_at_the_zoo_project
{
   public class Spiders: Arachnids
    {
        #region variables
        private bool hasBigHead;
        private bool isCrazy;
        #endregion

        #region Properties

        public bool HasBigHead
        {
            get
            {
                return hasBigHead;
            }
            set
            {
                if (!hasBigHead && value == false)
                {
                    hasBigHead = true;
                }
                else if (hasBigHead && value == false)
                {
                    hasBigHead = false;
                }
            }
        }

        public bool IsCrazy
        {
            get
            {
                return isCrazy;
            }
            set
            {
                if (!isCrazy && value == false)
                {
                    isCrazy = true;
                }
                else if (isCrazy && value == false)
                {
                    isCrazy = false;
                }
            }
        }
        #endregion
    }
}
