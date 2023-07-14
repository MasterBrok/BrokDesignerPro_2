using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace BrokDesignerPro_2.Controls
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:BrokDesignerPro_2.Controls"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:BrokDesignerPro_2.Controls;assembly=BrokDesignerPro_2.Controls"
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
    ///     <MyNamespace:ccRepeatButton/>
    ///
    /// </summary>
    public class ccRepeatButton : RepeatButton
    {
        static ccRepeatButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccRepeatButton), new FrameworkPropertyMetadata(typeof(ccRepeatButton)));
        }




        public Geometry Data
        {
            get { return (Geometry)GetValue(DataProperty); }
            set { SetValue(DataProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Data.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DataProperty =
            DependencyProperty.Register("Data", typeof(Geometry), typeof(ccRepeatButton), new PropertyMetadata(default));



    }
}
