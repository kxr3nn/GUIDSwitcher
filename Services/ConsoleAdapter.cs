using System;

namespace GUIDSwitcher.Services
{
    public class ConsoleAdapter
    {
        private GUIDSwitcher _main;

        public ConsoleAdapter(GUIDSwitcher main)
        {
            _main = main;
        }

        public void Clear()
        {
            _main.OutputRectangle.Text = String.Empty;
            _main.OutputRectangle.Invalidate();
        }

        public void Write(string value)
        {
            _main.OutputRectangle.Text += $"{value}";
            _main.OutputRectangle.Invalidate();
        }

        public void WriteLine(string value)
        {
            _main.OutputRectangle.Text += $"{value}\n";
            _main.OutputRectangle.Invalidate();
        }
    }
}
