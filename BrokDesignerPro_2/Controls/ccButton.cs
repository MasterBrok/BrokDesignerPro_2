using System.Windows;
using System.Windows.Controls;
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
    ///     <MyNamespace:ccButton/>
    ///
    /// </summary>
    public class ccButton : Button
    {
        static ccButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccButton), new FrameworkPropertyMetadata(typeof(ccButton)));
        }
        public Visibility IsShow
        {
            get { return (Visibility)GetValue(IsShowProperty); }
            set { SetValue(IsShowProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsShow.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsShowProperty =
            DependencyProperty.Register("IsShow", typeof(Visibility), typeof(ccButton), new PropertyMetadata(default));


        public Geometry Geometry
        {
            get { return (Geometry)GetValue(GeometryProperty); }
            set { SetValue(GeometryProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Geometry.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GeometryProperty =
            DependencyProperty.Register("Geometry", typeof(Geometry), typeof(ccButton), new PropertyMetadata(default));


    }
}
