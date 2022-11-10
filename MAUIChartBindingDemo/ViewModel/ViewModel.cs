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
				new Model { Country = "USA", Medals = new double[] { 39, 31, 29} },
				new Model { Country = "Germany", Medals = new double[] { 24, 28, 32 } },
				new Model { Country = "Britain", Medals = new double[] { 20, 25, 25} },
				new Model { Country = "France", Medals = new double[] { 19, 21, 23 } },
				new Model { Country = "Italy", Medals = new double[] { 19, 15, 17 } },
			};
		}
	}
}
