using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIChartBindingDemo
{
	public class Model
	{
		public string Country { get; set; }

		// Gold, Silver and, Bronze medals
		public double[] Medals { get; set; }
	}

	public class ViewModel
	{
		public ObservableCollection<Model> Data { get; set; }
		public ViewModel()
		{
			Data = new ObservableCollection<Model>()
			{
				new Model { Country = "USA", Medals = new double[] { 39, 41, 33} },
				new Model { Country = "Germany", Medals = new double[] { 10, 11, 16 } },
				new Model { Country = "Britain", Medals = new double[] { 22, 20, 22} },
				new Model { Country = "France", Medals = new double[] { 10, 12, 11 } },
				new Model { Country = "Italy", Medals = new double[] { 10, 10, 20 } },
				new Model { Country = "Japan", Medals = new double[] { 27, 14, 17 } },
				new Model { Country = "Australia", Medals = new double[] { 17, 7, 22 } },
				new Model { Country = "China", Medals = new double[] { 38, 32, 19} },
			};
		}
	}
}
