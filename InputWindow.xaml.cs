using System;
using System.Collections.Generic;
using System.Windows;

namespace SimpleInputWindow
{
    public partial class InputWindow : Window
    {
        private List<InputItem> Inputs;

        public InputWindow()
        {
            InitializeComponent();
            Inputs = new List<InputItem>();
        }

        public InputWindow(params InputItem[] inputs)
        {
            InitializeComponent();
            int marginTop = 0;
            Inputs = new List<InputItem>();
            Inputs.AddRange(inputs);
            foreach (var i in Inputs)
            {
                gridInputs.Children.Add(i);
                i.Margin = new Thickness(0, marginTop, 0, 0);
                marginTop += 60;
                Height += 60;
            }
            btnConfirm.Margin = new Thickness(10, marginTop + 10, 0, 0);
        }

        /// <summary>
        /// Get the inputs from textboxes
        /// </summary>
        /// <returns>If strings isn't whitespaced, returns the actual inputs, else null</returns>
        public string[] GetInputs()
        {
            List<string> inputs = new List<string>();
            foreach (var i in Inputs)
            {
                var text = i.Input.Text;
                if (!string.IsNullOrWhiteSpace(text))
                {
                    inputs.Add(text);
                }
                else
                {
                    throw new ArgumentException("Input was empty");
                }
            }
            return inputs.ToArray();
        }

        private void BtnConfirm_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
