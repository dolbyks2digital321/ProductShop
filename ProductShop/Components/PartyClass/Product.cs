using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using ProductShop.Pages;

namespace ProductShop.Components
{
    public partial class Product
    {
        public double CostWithDisco
        {
            get
            {
                if (Discount == 0) return Convert.ToDouble(Cost);
                else return Convert.ToDouble(Cost - Cost * (decimal)Discount / 100);
            }
        }
        public string NewCost
        {
            get
            { 
                return $"{CostWithDisco.ToString("0.00")}";
            }
        }        
        public Visibility costVisibility
        {
            get
            {
                if (Discount == 0) return Visibility.Collapsed;
                else return Visibility.Visible;
            }
        }
        public SolidColorBrush ColorBorder
        {
            get
            {
                if (Discount != 0) return new SolidColorBrush(Color.FromRgb(227, 28, 61));
                else return new SolidColorBrush(Color.FromRgb(194, 194, 194));
            }
        }
    }
}

