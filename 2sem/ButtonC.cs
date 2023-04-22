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

namespace CourseWork
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CourseWork"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CourseWork;assembly=CourseWork"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:ButtonC/>
    ///
    /// </summary>
    public class ButtonC : Button
    {
        public static readonly RoutedEvent DirectEvent;

        public static readonly RoutedEvent TunnelingEvent;

        public static readonly RoutedEvent BubblingEvent;
        static ButtonC()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ButtonC), new FrameworkPropertyMetadata(typeof(ButtonC)));

            DirectEvent = EventManager.RegisterRoutedEvent(
           "DirectEvent", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(ButtonC));
            TunnelingEvent = EventManager.RegisterRoutedEvent(
            "TunnelingEvent", RoutingStrategy.Tunnel, typeof(RoutedEventHandler), typeof(ButtonC));
            BubblingEvent = EventManager.RegisterRoutedEvent(
            "BubblingEvent", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(ButtonC));
        }
        public static readonly RoutedUICommand MyCommand = new RoutedUICommand(
        "Hello",
        "MyCommand",
        typeof(ButtonC)
    );
        private void OnDirectEvent(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Direct Event was raised.");
        }

        private void OnTunnelingEvent(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tunneling Event was raised.");
        }

        private void OnBubblingEvent(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bubbling Event was raised.");
        }
        private void RaiseEvents(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(DirectEvent));
            RaiseEvent(new RoutedEventArgs(TunnelingEvent));
            RaiseEvent(new RoutedEventArgs(BubblingEvent));
        }

        public ButtonC() : base()
        {
            this.Click += RaiseEvents;
        }
    }
}
