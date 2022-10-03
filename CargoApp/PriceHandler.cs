using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoApp
{
    internal class PriceHandler
    {
        public float width, length, height, weight;
        public int count;
        public string type, country;

        public float Width
        {
            get { return width; }
            set { width = value; }
        }
        public float Height
        {
            get { return height; }
            set { height = value; }
        }
        public float Length
        {
            get { return length; }
            set { length = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public float GetPrice()
        {
            switch (country)
            {
                case "USA":
                    if (weight > 0 && weight <= 0.101)
                        return (float)1.00;
                    else if (weight >= 0.101 && weight <= 0.25)
                        return (float)2.00;
                    else if (weight >= 0.251 && weight <= 0.5)
                        return (float)3.00;
                    else if (weight >= 0.501 && weight <= 0.7)
                        return (float)4.00;
                    else if (weight >= 0.701 && weight <= 1)
                        return (float)4.50;
                    else if (weight > 1)
                        return (float)4.50;

                    break;
                case "TURKEY":
                    if (weight > 0 && weight <= 0.101)
                        return (float)0.90;
                    else if (weight >= 0.101 && weight <= 0.25)
                        return (float)1.75;
                    else if (weight >= 0.251 && weight <= 0.5)
                        return (float)2.90;
                    else if (weight >= 0.501 && weight <= 0.7)
                        return (float)4.00;
                    else if (weight >= 0.701 && weight <= 1)
                        return (float)4.50;
                    else if (weight > 1)
                        return (float)4.50;

                    break;
                case "CHINA":
                    if (weight > 0 && weight <= 0.101)
                        return (float)1.00;
                    else if (weight >= 0.101 && weight <= 0.25)
                        return (float)1.90;
                    else if (weight >= 0.251 && weight <= 0.5)
                        return (float)3.10; //sj
                    else if (weight >= 0.501 && weight <= 0.7)
                        return (float)4.00;
                    else if (weight >= 0.701 && weight <= 1)
                        return (float)4.50;
                    else if (weight > 1)
                        return (float)5.00;

                    break;
            }

            return 0;
        }

        public float Calculate()
        {
            if (width >= 100 || length >= 100 || height >= 100) return (width * length * height) / 10000 * count;

            float price = GetPrice();
            switch (type)
            {
                case "Standart":
                    if (weight > 1) return (float)(weight * count * price);
                    return price;
                case "Maye":
                    if (weight > 1) return (float)(weight * count * price * 1.5);
                    return (float)(price * 1.5);
            }

            return 0;

        }


    }
}
