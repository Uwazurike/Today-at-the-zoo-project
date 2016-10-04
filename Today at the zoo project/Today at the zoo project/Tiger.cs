using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Today_at_the_zoo_project
{
   public class Tiger: Mammals
    {
        #region variables
        private bool isAgressive;
        private string diet;
        #endregion

        #region Properties

        public bool IsAgressive
        {
            get
            {
                return isAgressive;
            }
            set
            {
                if (!isAgressive && value == false)
                {
                    isAgressive = true;
                }
                else if (isAgressive && value == false)
                {
                    isAgressive = false;
                }
            }
        }

        public string Diet
        {
            get
            {
                return diet;
            }
            set
            {
                diet = value;
            }
        }
        #endregion
    }
}
