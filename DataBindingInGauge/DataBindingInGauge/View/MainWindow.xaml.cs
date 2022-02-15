using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Media;
using Syncfusion.UI.Xaml.Gauges;

namespace DataBindingInGauge
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            // Creating view model.
            ValueViewModel viewModel = new();

            // Creating the Binding and set its path and source.
            Binding binding = new Binding
            {
                Path = new PropertyPath("Value"),
                Source = viewModel
            };

            // Creating the radial gauge.
            SfRadialGauge sfRadialGauge = new SfRadialGauge
            {
                DataContext = viewModel
            };

            RadialAxis radialAxis = new();
            sfRadialGauge.Axes.Add(radialAxis);

            NeedlePointer needlePointer = new NeedlePointer
            {
                NeedleFill = new SolidColorBrush(Colors.Red)
            };

            // Setting the binding value to the needle pointer.
            needlePointer.SetBinding(NeedlePointer.ValueProperty, binding);
            radialAxis.Pointers.Add(needlePointer);
            this.Content = sfRadialGauge;
        }
    }
}
