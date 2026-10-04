namespace ObserverPatternDemo
{
    public partial class Form1 : Form
    {
        private readonly WeatherStation _station = new WeatherStation();
        private TemperatureLabelObserver _labelObserver;
        private TemperatureLogObserver _logObserver;

        public Form1()
        {
            InitializeComponent();

            _labelObserver = new TemperatureLabelObserver(lblTemperature);
            _logObserver = new TemperatureLogObserver(lstLog);

            _station.Attach(_labelObserver);
            _station.Attach(_logObserver);

            _station.SetTemperature(trackTemperature.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackTemperature_Scroll(object sender, EventArgs e)
        {
            _station.SetTemperature(trackTemperature.Value);
        }

        private void chkSubscribeLog_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSubscribeLog.Checked)
                _station.Attach(_logObserver);
            else
                _station.Detach(_logObserver);
        }
    }
}
