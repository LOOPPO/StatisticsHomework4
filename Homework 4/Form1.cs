using System.Diagnostics;

namespace Homework_4
{
    public partial class Form1 : Form
    {
        private readonly Random _Random;
        private readonly Graphics _ChartGraphics;
        private readonly Graphics _BarChartGraphics;
        private readonly Image _ChartImage;
        private readonly Image _BarChartImage;
        public Form1()
        {
            InitializeComponent();
            _Random = new Random();

            //Chart
            _ChartImage = new Bitmap(ChartPictureBox.Width, ChartPictureBox.Height);
            _ChartGraphics = Graphics.FromImage(_ChartImage);
            _ChartGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            ChartPictureBox.Image = _ChartImage;
            
            //BarChart
            _BarChartImage = new Bitmap(BarChartPictureBox.Width, BarChartPictureBox.Height);
            _BarChartGraphics = Graphics.FromImage(_BarChartImage);
            _BarChartGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BarChartPictureBox.Image = _BarChartImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            var numberOfSequences = Convert.ToInt32(SequencesNumericUpDown.Value);
            var trials = Convert.ToInt32(TrialsNumericUpDown.Value);
            var probability = Convert.ToDouble(ProbabilityNumericUpDown.Value);
            List<List<Attempt>> sequences = new List<List<Attempt>>();
            
            _ChartGraphics.Clear(ChartPictureBox.BackColor);
            _BarChartGraphics.Clear(BarChartPictureBox.BackColor);

            for (int i = 0; i < numberOfSequences; i++)
            {
                var sequence = GetSequence(probability, trials);
                sequences.Add(sequence);
            }

            PlotChart(sequences);
            ChartPictureBox.Invalidate();

            Dictionary<double, int> observationCounts = new Dictionary<double, int>();

            var lastValues = sequences.Select(s => s.Last().Observation);

            foreach (var lastValue in lastValues)
            {
                var value = lastValue;
                if (!observationCounts.ContainsKey(value))
                    observationCounts.Add(value, 1);
                else
                    observationCounts[value]++;
            }

            PlotBarChart(observationCounts, 1, trials);
            BarChartPictureBox.Invalidate();
        }

        private void PlotChart(List<List<Attempt>> sequences)
        {
            var maxY = AbsoluteRadioButton.Checked ? sequences.First().Count : RelativeRadioButton.Checked ? 1 : sequences.First().Count / Math.Sqrt(sequences.First().Count);
            foreach (var sequence in sequences)
            {
                var points = sequence.Select(a => new PointF((float)(a.Trial - 1).Normalize(ChartPictureBox.Width, sequence.Count), (float)a.Observation.Normalize(ChartPictureBox.Height, maxY)));
                _ChartGraphics.DrawLines(RandomPen(), points.ToArray());
            }
        }

        private void PlotBarChart(Dictionary<double, int> barChartValues, double height, int trials)
        {
            var maxY = AbsoluteRadioButton.Checked ? trials : RelativeRadioButton.Checked ? 1 : trials / Math.Sqrt(trials);

            foreach (var keyValue in barChartValues)
            {
                Debug.WriteLine($"Y: {keyValue.Key.Normalize(BarChartPictureBox.Height, maxY)}");
                Debug.WriteLine($"W: {keyValue.Value.Normalize(BarChartPictureBox.Width, barChartValues.Values.Max())}");

                _BarChartGraphics.FillRectangle(RandomBrush(),
                        0,
                        (float)keyValue.Key.Normalize(BarChartPictureBox.Height, maxY),
                        (float)keyValue.Value.Normalize(BarChartPictureBox.Width, barChartValues.Values.Max()),
                        (float)height);
            }
        }

        private double ElaborateValue(int value, int attempts)
        {
            if (AbsoluteRadioButton.Checked)
                return value;
            if (RelativeRadioButton.Checked)
                return (double)value / attempts;
            if (NormalizedRadioButton.Checked)
                return value / Math.Sqrt(attempts);
            return value;
        }

        private void SetDefaults()
        {
            SequencesNumericUpDown.Value = 10;
            TrialsNumericUpDown.Value = 50;
            ProbabilityNumericUpDown.Value = 0.50m;
            RelativeRadioButton.Checked = true;
        }

        private List<Attempt> GetSequence(double probability, int trials)
        {
            int successes = 0;
            List<Attempt> sequence = new List<Attempt>();
            
            for (int i = 1; i <= trials; i++)
            {
                successes = GenerateSuccess(probability) ? successes + 1 : successes;
                var attempt = new Attempt
                {
                    Trial = i,
                    Observation = ElaborateValue(successes, i)
                };
                sequence.Add(attempt);
            }
            return sequence;
        }

        private bool GenerateSuccess(double probability) => _Random.NextDouble() <= probability;
        private Pen RandomPen() => new Pen(Color.FromArgb(_Random.Next(256), _Random.Next(256), _Random.Next(256)), 2);
        private Brush RandomBrush() => new SolidBrush(Color.FromArgb(_Random.Next(256), _Random.Next(256), _Random.Next(256)));

    }
}