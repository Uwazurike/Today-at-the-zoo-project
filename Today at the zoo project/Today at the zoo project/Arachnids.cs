using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Today_at_the_zoo_project
{
    public class Arachnids: Animal
    {
        #region variables
        private string colorPattern;
        private bool isHealthy;
        #endregion

        #region Properties

        public string ColorPattern
        {
            get
            {
                return colorPattern;
            }

            set
            {
                colorPattern = value;
            }
        }

        public bool IsHealthy
        {
            get
            {
                return isHealthy;
            }
            set
            {
                if (!isHealthy && value == false)
                {
                    isHealthy = true;
                }
                else if (isHealthy && value == false)
                {
                    isHealthy = false;
                }
            }
        }
        #endregion
    }
}

