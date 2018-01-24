using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SampleApplication
{
    public class StudentDependencyProperty : DependencyObject
    {
        public static readonly DependencyProperty StudentProperty = DependencyProperty
            .Register("NameProperty", typeof(string), typeof(MainWindow));

        public string StudentName
        {
            get
            {
                return (string)GetValue(StudentProperty);
            }
            set
            {
                SetValue(StudentProperty, value);
            }

        }
    }
}
