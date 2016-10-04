using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Today_at_the_zoo_project
{
  public  class Turtle: Reptiles
    {
        #region variables
        private bool isTricky;
        private bool isRare;
        #endregion

        #region Properties

        public bool IsTricky
        {
            get
            {
                return isTricky;
            }
            set
            {
                if (!isTricky && value == false)
                {
                    isTricky = true;
                }
                else if (isTricky && value == false)
                {
                    isTricky = false;
                }
            }
        }

        public bool IsRare
        {
            get
            {
                return isRare;
            }
            set
            {
                if (!isRare && value == false)
                {
                    isRare = true;
                }
                else if (isRare && value == false)
                {
                    isRare = false;
                }
            }
        }
        #endregion
    }
}
