using System.Collections.Generic;

namespace Module6Lab
{
    public class Ingredient
    {
        private string desc;
        private string measurement;
        private double qty;

        public Ingredient(double qty = default, string measurement = null, string desc = null)
        {
            this.qty = qty;
            this.measurement = measurement;
            this.desc = desc;
        }

        public string Desc
        {
            get => desc;
            set => desc = value;
        }

        public string Measurement
        {
            get => measurement;
            set => measurement = value;
        }

        public double Qty
        {
            get => qty;
            set => qty = value;
        }


        public string Print()
        {
            return $"{qty} {measurement} of {desc}";
        }
    }
}