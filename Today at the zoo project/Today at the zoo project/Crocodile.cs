using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Today_at_the_zoo_project
{
   public class Crocodile: Reptiles
    {
        #region variables
        private bool isRugged;
        private bool isStrong;
        #endregion

        #region Properties

        public bool IsRugged
        {
            get
            {
                return isRugged;
            }
            set
            {
                if (!isRugged && value == false)
                {
                    isRugged = true;
                }
                else if (isRugged && value == false)
                {
                    isRugged = false;
                }
            }
        }

        public bool IsStrong
        {
            get
            {
                return isStrong;
            }
            set
            {
                if (!isStrong && value == false)
                {
                    isStrong = true;
                }
                else if (isStrong && value == false)
                {
                    isStrong = false;
                }
            }
        }
        #endregion
    }
}
