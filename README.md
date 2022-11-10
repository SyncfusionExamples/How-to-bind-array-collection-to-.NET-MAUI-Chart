# How-to-bind-array-collection-to-.NET-MAUI-Chart-SfCartesianChart-

[.NET MAUI chart](https://www.syncfusion.com/maui-controls/maui-charts) supports array values for the [XBindingPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_XBindingPath) and [YBindingPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.XYDataSeries.html#Syncfusion_Maui_Charts_XYDataSeries_YBindingPath) properties. The [XBindinPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_XBindingPath) and [YBindingPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.XYDataSeries.html#Syncfusion_Maui_Charts_XYDataSeries_YBindingPath) are bound with the property name in the corresponding index value. You can bind the same property with different index values.

This article explains how to bind array collection to the .NET MAUI Chart with the following steps.

### Initialize model
Create a data model class with array property.

**[C#]**

```
public class Model
{
	public string Country { get; set; }

	// Gold, Silver and, Bronze medals
	public double[] Medals { get; set; }
}
```
### Initialize view model
Create a ViewModel class with a Data Collection property using the above model and initialize a list of objects as shown in the following code sample.

**[C#]**

```
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
```
### How to binding array collection in .NET MAUI Charts
Bind XBindingPath and YBindingPath with the property name in the corresponding index value.

**[XAML]**

  ```
<chart:ColumnSeries ItemsSource="{Binding Data}"
                    XBindingPath="Country"
                    YBindingPath="Medals[0]"/>
  ```

**[C#]**

```
ViewModel viewModel = new ViewModel();
ColumnSeries series = new ColumnSeries()
{
	ItemsSource = viewModel.Data,
	XBindingPath = "Country",
	YBindingPath = "Medals[0]",
};
```
![Binding array collection in .NET MAUI Charts](https://user-images.githubusercontent.com/61832185/201016679-7e28170f-2333-41dc-beee-d7645531eafc.png)

KB article - [How to bind array collection in .NET MAUI Chart (SfCartesianChart)?]( )

