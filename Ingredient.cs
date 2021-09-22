using System.Collections.Generic;

namespace Module6Lab
{
    public class Ingredient
    {
        private string desc;
        private string measurement;
        private int qty;

        public Ingredient(int qty = default, string measurement = null, string desc = null)
        {
            this.qty = qty;
            this.measurement = measurement;
            this.desc = desc;
        }

        public int GetQty()
        {
            return this.qty;
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
    }
}