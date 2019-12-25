using AForge.Fuzzy;
using System;
using System.Windows.Forms;

namespace AF_System
{
    public partial class GUI : Form
    {
        private static readonly double BrakeLevel;
        private static readonly double distance;
        private static readonly double speed;
        private static readonly double angle;

        public GUI()
        {
            InitializeComponent();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //private void bunifuImageButton1_Click(object sender, EventArgs e)
        //{
        //    indicator.Top = ((ns1.BunifuImageButton)sender).Top - 10;
        //}

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TB_Speed_ValueChanged(object sender, EventArgs e)
        {
            double speed = TB_Speed.Value;
            Gauge_Speed.Value = Convert.ToInt32(speed * 0.833333);
            lblvalueSpeed.Text = Convert.ToString(speed) + " Km/h";


        }

        private void bunifuGauge1_Load(object sender, EventArgs e)
        {

        }

        private void TB_AngleMin_ValueChanged(object sender, EventArgs e)
        {
            if (TB_AnglePlus.Value != 0)
            {
                TB_AngleMin.Value = 0;
            }
            else
            {
                double distance = TB_AngleMin.Value * 1.1111111;
                Gauge_Angle.Value = Convert.ToInt32(distance);
                double value_min = TB_AngleMin.Value * -1;
                lblvalueAngle.Text = Convert.ToString(Math.Ceiling(value_min) + "°");
            }
        }

        private void TB_Distance_ValueChanged(object sender, EventArgs e)
        {
            double angle = TB_Distance.Value;
            Gauge_Distance.Value = Convert.ToInt32(angle) * 10;
            lblvalueDistance.Text = Convert.ToString(Math.Ceiling(angle) + " m");
        }

        private void TB_AnglePlus_ValueChanged(object sender, EventArgs e)
        {
            if (TB_AngleMin.Value != 0)
            {
                TB_AnglePlus.Value = 0;
            }
            else
            {
                double angle = TB_AnglePlus.Value * 1.1111111;
                Gauge_Angle.Value = Convert.ToInt32(angle);

                lblvalueAngle.Text = TB_AnglePlus.Value + "°";
            }
        }

        private void Gauge_Break_Load(object sender, EventArgs e)
        {

        }

        private void Value_AngleMin_Click(object sender, EventArgs e)
        {

        }

        private void Value_Distance_Click(object sender, EventArgs e)
        {

        }

        private void Value_Speed_Click(object sender, EventArgs e)
        {

        }

        private void indicator_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {

        }

        private void TB_Speed_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            // Speed (0-120)
            FuzzySet fsSlow = new FuzzySet("Slow", new TrapezoidalFunction(30, 50, TrapezoidalFunction.EdgeType.Right));
            FuzzySet fsMedium = new FuzzySet("Medium", new TrapezoidalFunction(40, 60, 80));
            FuzzySet fsFast = new FuzzySet("Fast", new TrapezoidalFunction(70, 80, TrapezoidalFunction.EdgeType.Left));
            // Linguistik Speed
            LinguisticVariable lvSpeed = new LinguisticVariable("Speed", 0, 120);
            lvSpeed.AddLabel(fsSlow);
            lvSpeed.AddLabel(fsMedium);
            lvSpeed.AddLabel(fsFast);

            // Distance (0-10)
            FuzzySet fsClose = new FuzzySet("Close", new TrapezoidalFunction(1, 2, TrapezoidalFunction.EdgeType.Right));
            FuzzySet fsFar = new FuzzySet("Far", new TrapezoidalFunction(1, 4, 5));
            FuzzySet fsVeryFar = new FuzzySet("VeryFar", new TrapezoidalFunction(4, 7, TrapezoidalFunction.EdgeType.Left));
            // Linguistik Distance
            LinguisticVariable lvDistance = new LinguisticVariable("Distance", 0, 10);
            lvDistance.AddLabel(fsClose);
            lvDistance.AddLabel(fsFar);
            lvDistance.AddLabel(fsVeryFar);

            // Road Angle ((-90)-90)
            FuzzySet fsDown = new FuzzySet("Down", new TrapezoidalFunction(-40, -20, TrapezoidalFunction.EdgeType.Right));
            FuzzySet fsFlat = new FuzzySet("Flat", new TrapezoidalFunction(-25, 0, 25));
            FuzzySet fsUp = new FuzzySet("Up", new TrapezoidalFunction(20, 40, TrapezoidalFunction.EdgeType.Left));
            // Linguistik Road Angle
            LinguisticVariable lvAngle = new LinguisticVariable("Angle", -90, 90);
            lvAngle.AddLabel(fsDown);
            lvAngle.AddLabel(fsFlat);
            lvAngle.AddLabel(fsUp);

            // OUTPUT

            // Braking Rate (0-10)
            FuzzySet fsBrakeWeak = new FuzzySet("Weak", new TrapezoidalFunction(3, 4, TrapezoidalFunction.EdgeType.Right));
            FuzzySet fsBrakeMedium = new FuzzySet("Medium", new TrapezoidalFunction(3, 4, 6, 7));
            FuzzySet fsBrakeStrong = new FuzzySet("Strong", new TrapezoidalFunction(6, 7, TrapezoidalFunction.EdgeType.Left));
            // Linguistik Braking Rate
            LinguisticVariable lvBrakingRate = new LinguisticVariable("BrakingRate", 0, 10);
            lvBrakingRate.AddLabel(fsBrakeWeak);
            lvBrakingRate.AddLabel(fsBrakeMedium);
            lvBrakingRate.AddLabel(fsBrakeStrong);

            // Database
            Database fuzzyDB = new Database();
            fuzzyDB.AddVariable(lvDistance);
            fuzzyDB.AddVariable(lvAngle);
            fuzzyDB.AddVariable(lvSpeed);
            fuzzyDB.AddVariable(lvBrakingRate);

            // Inferensi System Engine
            InferenceSystem IS = new InferenceSystem(fuzzyDB, new CentroidDefuzzifier(1000));

            // Rules
            IS.NewRule("Rule 1", "IF Speed IS Slow AND Distance IS Close AND Angle IS Down THEN BrakingRate IS Strong");
            IS.NewRule("Rule 2", "IF Speed IS Slow AND Distance IS Close AND Angle IS Up THEN BrakingRate IS Weak");
            IS.NewRule("Rule 3", "IF Speed IS Slow AND Distance IS Close AND Angle IS Flat THEN BrakingRate IS Medium");
            IS.NewRule("Rule 4", "IF Speed IS Slow AND Distance IS Far AND Angle IS Flat THEN BrakingRate IS Weak");
            IS.NewRule("Rule 5", "IF Speed IS Slow AND Distance IS Far AND Angle IS Up THEN BrakingRate IS Weak");
            IS.NewRule("Rule 6", "IF Speed IS Slow AND Distance IS Far AND Angle IS Down THEN BrakingRate IS Medium");
            IS.NewRule("Rule 7", "IF Speed IS Slow AND Distance IS VeryFar AND Angle IS Flat THEN BrakingRate IS Weak");
            IS.NewRule("Rule 8", "IF Speed IS Slow AND Distance IS VeryFar AND Angle IS Up THEN BrakingRate IS Weak");
            IS.NewRule("Rule 9", "IF Speed IS Slow AND Distance IS VeryFar AND Angle IS Down THEN BrakingRate IS Medium");
            IS.NewRule("Rule 10", "IF Speed IS Medium AND Distance IS Close AND Angle IS Flat THEN BrakingRate IS Strong");
            IS.NewRule("Rule 11", "IF Speed IS Medium AND Distance IS Close AND Angle IS Up THEN BrakingRate IS Medium");
            IS.NewRule("Rule 12", "IF Speed IS Medium AND Distance IS Close AND Angle IS Down THEN BrakingRate IS Strong");
            IS.NewRule("Rule 13", "IF Speed IS Medium AND Distance IS Far AND Angle IS Flat THEN BrakingRate IS Medium");
            IS.NewRule("Rule 14", "IF Speed IS Medium AND Distance IS Far AND Angle IS Up THEN BrakingRate IS Weak");
            IS.NewRule("Rule 15", "IF Speed IS Medium AND Distance IS Far AND Angle IS Down THEN BrakingRate IS Strong");
            IS.NewRule("Rule 16", "IF Speed IS Medium AND Distance IS VeryFar AND Angle IS Flat THEN BrakingRate IS Weak");
            IS.NewRule("Rule 17", "IF Speed IS Medium AND Distance IS VeryFar AND Angle IS Up THEN BrakingRate IS Weak");
            IS.NewRule("Rule 18", "IF Speed IS Medium AND Distance IS VeryFar AND Angle IS Down THEN BrakingRate IS Medium");
            IS.NewRule("Rule 19", "IF Speed IS Fast AND Distance IS Close AND Angle IS Flat THEN BrakingRate IS Strong");
            IS.NewRule("Rule 20", "IF Speed IS Fast AND Distance IS Close AND Angle IS Up THEN BrakingRate IS Medium");
            IS.NewRule("Rule 21", "IF Speed IS Fast AND Distance IS Close AND Angle IS Down THEN BrakingRate IS Strong");
            IS.NewRule("Rule 22", "IF Speed IS Fast AND Distance IS Far AND Angle IS Flat THEN BrakingRate IS Strong");
            IS.NewRule("Rule 23", "IF Speed IS Fast AND Distance IS Far AND Angle IS Up THEN BrakingRate IS Medium");
            IS.NewRule("Rule 24", "IF Speed IS Fast AND Distance IS Far AND Angle IS Down THEN BrakingRate IS Strong");
            IS.NewRule("Rule 25", "IF Speed IS Fast AND Distance IS VeryFar AND Angle IS Flat THEN BrakingRate IS Medium");
            IS.NewRule("Rule 26", "IF Speed IS Fast AND Distance IS VeryFar AND Angle IS Up THEN BrakingRate IS Weak");
            IS.NewRule("Rule 27", "IF Speed IS Fast AND Distance IS VeryFar AND Angle IS Down THEN BrakingRate IS Strong");

            // Set Input

            IS.SetInput("Speed", (float)Convert.ToDouble(TB_Speed.Value));
            IS.SetInput("Distance", (float)Convert.ToDouble(TB_Distance.Value));

            if (TB_AngleMin.Value != 0)
            {
                IS.SetInput("Angle", (float)Convert.ToDouble(TB_AngleMin.Value));
            }

            IS.SetInput("Angle", (float)Convert.ToDouble(TB_AnglePlus.Value));

            // Get output
            double BrakeLevel = IS.Evaluate("BrakingRate");

            if (TB_Speed.Value == 0 && TB_Distance.Value == 0 && TB_AngleMin.Value == 0 && TB_AnglePlus.Value == 0)
            {
                BrakeLevel = 0;
                Gauge_Break.Value = Convert.ToInt32(BrakeLevel * 10);
                lblvalueBrake.Text = Convert.ToString(Math.Ceiling(BrakeLevel));
            }
            else
            {
                Gauge_Break.Value = Convert.ToInt32(BrakeLevel * 10);
            }

            lblvalueBrake.Text = Convert.ToString(Math.Ceiling(BrakeLevel));
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

