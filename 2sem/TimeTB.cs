using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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
    ///     <MyNamespace:TimeTB/>
    ///
    /// </summary>
    public class TimeTB : TextBox
    {

        public static readonly DependencyProperty BorderColorChangeProperty;
        public static readonly DependencyProperty TextColorProperty;
        static TimeTB()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TimeTB), new FrameworkPropertyMetadata(typeof(TimeTB)));

            BorderColorChangeProperty = DependencyProperty.Register("BorderColorChange", typeof(Brush), typeof(TimeTB),
            new PropertyMetadata(null, new PropertyChangedCallback(OnBorderColorChange)), IsValidBorderColorChange);

            TextColorProperty = DependencyProperty.Register("TextColor", typeof(Brush), typeof(TimeTB),
            new PropertyMetadata(null, new PropertyChangedCallback(OnTextColorChange), CoerceTextColorChangeCallback));

    }

        public Brush BorderColorChange
        {
            get { return (Brush)GetValue(BorderColorChangeProperty); }
            set { SetValue(BorderColorChangeProperty, value); }
        }

        private static bool IsValidBorderColorChange(object value)
        {
            return true;
        }

        private static void OnBorderColorChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TimeTB timetb = (TimeTB)d;
                timetb.BorderBrush = (Brush)e.NewValue;
        }

        public Brush TextColor
        {
            get { return (Brush)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        private static object CoerceTextColorChangeCallback(DependencyObject d, object value)
        {
            return ((Brush)value != null) ? value : null;
        }

        private static void OnTextColorChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TimeTB timetb = (TimeTB)d;
                timetb.Foreground = (Brush)e.NewValue;
        }

        public TimeTB() : base()
        {
            this.TextChanged += TimeTB_Changed;
            UndoLimit = 11;
        }

        private void TimeTB_Changed(object sender, TextChangedEventArgs e)
        {
            var tbEntry = sender as TextBox;
            tbEntry.CaretIndex = tbEntry.Text.Length;

            if (tbEntry != null && tbEntry.Text.Length > 0)
            {
                tbEntry.Text = ValidateTIme(tbEntry.Text);
            }
        }
        public static string ValidateTIme(string MaskedNum)
        {
            int x;
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            if (MaskedNum != null)
            {
                for (int i = 0; i < MaskedNum.Length; i++)
                {
                    if (int.TryParse(MaskedNum.Substring(i, 1), out x))
                    {
                        sb.Append(x.ToString());
                    }
                }
                //Validate && masked time 
                if (sb.Length > 0 && (sb[0] == '0' || sb[0] == '1' || sb[0] == '2')) sb2.Append(sb.ToString().Substring(0, 1));
                if (sb.Length > 1 && Convert.ToInt32(sb.ToString().Substring(0, 2)) < 24) sb2.Append(sb.ToString().Substring(1, 1));

                if (sb.Length > 2) sb2.Append(".");

                if (sb.Length > 2 && Regex.IsMatch(sb[2].ToString(), "[0-5]")) sb2.Append(sb.ToString().Substring(2, 1));
                if (sb.Length > 3 && Convert.ToInt32(sb.ToString().Substring(2, 2)) < 60) sb2.Append(sb.ToString().Substring(3, 1));

                if (sb.Length > 4) sb2.Append("-");

                if (sb.Length > 4 && (sb[4] == '0' || sb[4] == '1' || sb[4] == '2')) sb2.Append(sb.ToString().Substring(4, 1));
                if (sb.Length > 5 && Convert.ToInt32(sb.ToString().Substring(4, 2)) < 24) sb2.Append(sb.ToString().Substring(5, 1));

                if (sb.Length > 6) sb2.Append(".");

                if (sb.Length > 6 && Regex.IsMatch(sb[6].ToString(), "[0-5]")) sb2.Append(sb.ToString().Substring(6, 1));
                if (sb.Length > 7 && Convert.ToInt32(sb.ToString().Substring(6, 2)) < 60) sb2.Append(sb.ToString().Substring(7, 1));
            }
            return sb2.ToString();
        }
    }
}
