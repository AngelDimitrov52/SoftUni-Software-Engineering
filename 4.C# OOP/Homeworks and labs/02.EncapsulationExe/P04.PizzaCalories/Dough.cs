using System;
using System.Collections.Generic;
using System.Text;

namespace P04.PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        public string FlourType
        {
            get => flourType;
            private set
            {
                string type = value.ToLower();
                if (type == "white" || type == "wholegrain")
                {
                    flourType = type;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }
        public string BakingTechnique
        {
            get => bakingTechnique;
            private set
            {
                string type = value.ToLower();
                if (type == "crispy" || type == "chewy" || type == "homemade")
                {
                    bakingTechnique = type;
                }
                else
                {

                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }

        public double Weight
        {
            get => weight;
            private set
            {
                if (value >= 1 && value <= 200)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
            }
        }

        public double Calories => GetCalories();
        private double GetCalories()

        {
            double valueflourType = GetFlourTyoe(flourType);
            double valueBakng = GetBaking(bakingTechnique);

            return (2 * weight) * valueflourType * valueBakng;
        }


        private double GetBaking(string bakingTechnique)
        {
            if (bakingTechnique == "crispy")
            {
                return 0.9;
            }
            else if (bakingTechnique == "chewy")
            {
                return 1.1;
            }
            return 1.0;
        }

        private double GetFlourTyoe(string flourType)
        {
            if (flourType == "white")
            {
                return 1.5;
            }
            return 1.0;
        }
    }
}
