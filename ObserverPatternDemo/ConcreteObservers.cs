using System;
using System.Windows.Forms;

namespace ObserverPatternDemo
{
    public class TemperatureLabelObserver : IObserver
    {
        private readonly Label _label;

        public TemperatureLabelObserver(Label label)
        {
            _label = label;
        }

        public void Update(double temperature)
        {
            _label.Text = $"Текущая температура: {temperature:F1} °C";
        }
    }

    public class TemperatureLogObserver : IObserver
    {
        private readonly ListBox _listBox;

        public TemperatureLogObserver(ListBox listBox)
        {
            _listBox = listBox;
        }

        public void Update(double temperature)
        {
            _listBox.Items.Add($"[{DateTime.Now:HH:mm:ss}] Зафиксировано: {temperature:F1} °C");
        }
    }
}