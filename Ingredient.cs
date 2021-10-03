namespace Module6Lab
{
    public class Ingredient
    {
        public Ingredient(double qty = default, string measurement = null, string desc = null)
        {
            this.Qty = qty;
            this.Measurement = measurement;
            this.Desc = desc;
        }

        public string Desc { get; set; }

        public string Measurement { get; set; }

        public double Qty { get; set; }


        public override string ToString()
        {
            return $"{Qty} {Measurement} of {Desc}";
        }

        public string Print()
        {
            return $"{Qty} {Measurement} of {Desc}";
        }
    }
}