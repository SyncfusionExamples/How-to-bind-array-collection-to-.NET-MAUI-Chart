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
## Output:
![Binding array collection in .NET MAUI Charts](https://user-images.githubusercontent.com/61832185/202373080-754fb273-36a6-4499-9e62-a3a48a329634.png)

## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

To run the sample demo, refer to [System Requirements for .NET MAUI.](https://help.syncfusion.com/maui/system-requirements)

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.




