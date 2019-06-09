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

namespace TableDesk.UI
{
    /// <summary>
    /// Логика взаимодействия для InputItem.xaml
    /// </summary>
    public partial class InputItem : UserControl
    {
        public InputItem()
        {
            InitializeComponent();
        }

        public InputItem(string hint)
        {
            InitializeComponent();
            Hint.Content = hint;
        }
        public InputItem(string hint, string textBoxText)
        {
            InitializeComponent();
            Hint.Content = hint;
            Input.Text = textBoxText;
        }
    }
}
