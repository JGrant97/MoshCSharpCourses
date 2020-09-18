using System;

namespace Amazon
{
    public class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);

        }
    }
}
