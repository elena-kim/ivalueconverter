using sys = System.Windows.Controls;
using System.Windows;
using System.Windows.Media;

namespace IValueConverterSample.Controls
{
    public class DevncoreIcon : sys.Control
    {
        public static readonly DependencyProperty DataProperty = DependencyProperty.Register(
            "Data", typeof(Geometry), typeof(DevncoreIcon), new PropertyMetadata(null));

        public static readonly DependencyProperty FillProperty = DependencyProperty.Register(
            "Fill", typeof(Brush), typeof(DevncoreIcon), new PropertyMetadata(null));

        public static readonly DependencyProperty StretchProperty = DependencyProperty.Register(
            "Stretch", typeof(Stretch), typeof(DevncoreIcon), new PropertyMetadata(null));

        public static readonly DependencyProperty GeometryWidthProperty = DependencyProperty.Register(
            "GeometryWidth", typeof(double), typeof(DevncoreIcon), new PropertyMetadata(0.0));

        public static readonly DependencyProperty GeometryHeightProperty = DependencyProperty.Register(
            "GeometryHeight", typeof(double), typeof(DevncoreIcon), new PropertyMetadata(0.0));

        public Geometry Data
        {
            get { return (Geometry)this.GetValue(DataProperty); }
            set { this.SetValue(DataProperty, value); }
        }

        public Brush Fill
        {
            get { return (Brush)this.GetValue(FillProperty); }
            set { this.SetValue(FillProperty, value); }
        }

        public Stretch Stretch
        {
            get { return (Stretch)this.GetValue(StretchProperty); }
            set { this.SetValue(StretchProperty, value); }
        }

        public double GeometryWidth
        {
            get { return (double)this.GetValue(GeometryWidthProperty); }
            set { this.SetValue(GeometryWidthProperty, value); }
        }

        public double GeometryHeight
        {
            get { return (double)this.GetValue(GeometryHeightProperty); }
            set { this.SetValue(GeometryHeightProperty, value); }
        }
    }
}
