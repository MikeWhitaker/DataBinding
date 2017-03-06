using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Databinding {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();

			Coffee MikesCoffee = new Coffee();
			MikesCoffee.Name = "Whitaker Home Brew";

			Binding coffeeBinding = new Binding();
			coffeeBinding.Source = MikesCoffee;
			coffeeBinding.Path = new PropertyPath("Name");

			
		}
	}

	class Coffee {
		public string Name { get; set; }
		public string Bean { get; set; }
		public string CountryOfOrigin { get; set; }
		public string Strength { get; set; }

	}
}
