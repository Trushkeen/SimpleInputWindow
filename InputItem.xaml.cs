using System.Windows.Controls;

namespace SimpleInputWindow
{
    public partial class InputItem : UserControl
    {
        public InputItem()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor with Hint and empty TextBox
        /// </summary>
        /// <param name="hint">Hint that will be displayed above TextBox</param>
        public InputItem(string hint)
        {
            InitializeComponent();
            Hint.Content = hint;
        }

        /// <summary>
        /// Constructor with Hint and TextBox
        /// </summary>
        /// <param name="hint">Hint that will be displayed above TextBox</param>
        /// <param name="textBoxText">Text that will be placed in TextBox</param>
        public InputItem(string hint, string textBoxText)
        {
            InitializeComponent();
            Hint.Content = hint;
            Input.Text = textBoxText;
        }
    }
}
