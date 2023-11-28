using ProductShop.Components;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ProductShop
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ProductShopEntities db = new ProductShopEntities();
        public static bool isAdmin = false;
        [STAThread]
        static void Main()
        {
            App app = new App();
            app.InitializeComponent();
            app.Run();
        }
    }
    
}
