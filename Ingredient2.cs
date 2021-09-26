using System.Collections.Generic;

namespace Module6Lab
{
    public class Ingredient2
    {
        private string desc;
        private string measurement;
        private double qty;

        public Ingredient2(double qty = default, string measurement = null, string desc = null)
        {
            this.qty = qty;
            this.measurement = measurement;
            this.desc = desc;
        }

        
        public double GetQty()
        {
            return this.qty;
        }

        public void SetQty(double qty)
        {
            this.qty = qty;
        }

        public void SetQty(int qty)
        {
            this.qty = qty;
        }
        
        public string GetMeasurement()
        {
            return this.measurement;
        }

        public void SetMeasurement(string measurment)
        {
            this.measurement = measurment;
        }

        public string GetDesc()
        {
            return this.desc;
        }

        public void SetDesc(string desc)
        {
            this.desc = desc;
        }

        public string Print()
        {
            return $"{qty} {measurement} of {desc}";
        }
    }
}