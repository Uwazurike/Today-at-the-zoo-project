using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Today_at_the_zoo_project
{
    public class Animal
    {
        #region variables
        private string animalName;
        private string animalType;
        private string animalColor;
        private int legCount;
        private bool hasTails;
        #endregion

        #region Properties

        public string AnimalName
        {
            get
            {
                return animalName;
            }

            set
            {
                animalName = value;
            }
        }

        public string AnimalType
        {
            get
            {
                return animalType;
            }

            set
            {
                animalType = value;
            }
        }

        public string AnimalColor
        {
            get
            {
                return animalColor;
            }

            set
            {
                animalColor = value;
            }
        }

        public int LegCount
        {
            get
            {
                return legCount;
            }

            set
            {
                legCount = value;
            }
        }

        public bool HasTails
        {
            get
            {
                return hasTails;
            }
            set
            {
                if (!hasTails && value == false)
                {
                    hasTails = true;
                }
                else if (hasTails && value == false)
                {
                    hasTails = false;
                }
            }
        }


        #endregion
    }
}
