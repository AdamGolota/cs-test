using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Divide
{
    public class RangedInt
    {
        public RangedInt(int value, int min, int max)
        {
            if(min > max)
            {
                throw new InvalidRangeException();
            }
            this.min = min;
            this.max = max;

            checkOutOfRange(value);
            this.Value = value;


        }
        public int getValue()
        {
            return this.Value;
        }
        public void setValue(int value)
        {
            checkOutOfRange(value);
            this.Value = value;
        }

        private void checkOutOfRange(int value)
        {
            if (value < this.min || value > this.max)
            {
                throw new ValueOutOfRangeException();
            }
        }

        private int value;
        private int min;
        private int max;

        public int Value { get => value; set => this.value = value; }
    }
}
