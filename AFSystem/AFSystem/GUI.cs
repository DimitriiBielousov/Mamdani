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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            indicator.Top = ((ns1.BunifuImageButton)sender).Top - 10;
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        //{

        //}

        //private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        //{

        //}

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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Gauge_Break_Load(object sender, EventArgs e)
        {

        }

        private void Value_AnglePlus_Click(object sender, EventArgs e)
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

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }


        private void TB_Speed_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            // Kecepatan (0-120)
            FuzzySet fsLambat = new FuzzySet("Lambat", new TrapezoidalFunction(30, 50, TrapezoidalFunction.EdgeType.Right));
            FuzzySet fsSedang = new FuzzySet("Sedang", new TrapezoidalFunction(40, 60, 80));
            FuzzySet fsCepat = new FuzzySet("Cepat", new TrapezoidalFunction(70, 80, TrapezoidalFunction.EdgeType.Left));
            // Linguistik Kecepatan
            LinguisticVariable lvKecepatan = new LinguisticVariable("Kecepatan", 0, 120);
            lvKecepatan.AddLabel(fsLambat);
            lvKecepatan.AddLabel(fsSedang);
            lvKecepatan.AddLabel(fsCepat);

            // Jarak (0-10)
            FuzzySet fsDekat = new FuzzySet("Dekat", new TrapezoidalFunction(1, 2, TrapezoidalFunction.EdgeType.Right));
            FuzzySet fsJauh = new FuzzySet("Jauh", new TrapezoidalFunction(1, 4, 5));
            FuzzySet fsSangatJauh = new FuzzySet("SangatJauh", new TrapezoidalFunction(4, 7, TrapezoidalFunction.EdgeType.Left));
            // Linguistik Jarak
            LinguisticVariable lvJarak = new LinguisticVariable("Jarak", 0, 10);
            lvJarak.AddLabel(fsDekat);
            lvJarak.AddLabel(fsJauh);
            lvJarak.AddLabel(fsSangatJauh);

            // Kemiringan Jalan ((-90)-90)
            FuzzySet fsTurun = new FuzzySet("Turun", new TrapezoidalFunction(-40, -20, TrapezoidalFunction.EdgeType.Right));
            FuzzySet fsDatar = new FuzzySet("Datar", new TrapezoidalFunction(-25, 0, 25));
            FuzzySet fsNaik = new FuzzySet("Naik", new TrapezoidalFunction(20, 40, TrapezoidalFunction.EdgeType.Left));
            // Linguistik Kemiringan Jalan
            LinguisticVariable lvKemiringan = new LinguisticVariable("Kemiringan", -90, 90);
            lvKemiringan.AddLabel(fsTurun);
            lvKemiringan.AddLabel(fsDatar);
            lvKemiringan.AddLabel(fsNaik);

            // OUTPUT

            // Tingkat Pengereman (0-10)
            FuzzySet fsLemah = new FuzzySet("Lemah", new TrapezoidalFunction(3, 4, TrapezoidalFunction.EdgeType.Right));
            FuzzySet fsMedium = new FuzzySet("Sedang", new TrapezoidalFunction(3, 4, 6, 7));
            FuzzySet fsKuat = new FuzzySet("Kuat", new TrapezoidalFunction(6, 7, TrapezoidalFunction.EdgeType.Left));
            // Linguistik Kecepatan
            LinguisticVariable lvTingkatPengereman = new LinguisticVariable("TingkatPengereman", 0, 10);
            lvTingkatPengereman.AddLabel(fsLemah);
            lvTingkatPengereman.AddLabel(fsMedium);
            lvTingkatPengereman.AddLabel(fsKuat);

            // Database
            Database fuzzyDB = new Database();
            fuzzyDB.AddVariable(lvJarak);
            fuzzyDB.AddVariable(lvKemiringan);
            fuzzyDB.AddVariable(lvKecepatan);
            fuzzyDB.AddVariable(lvTingkatPengereman);

            // Inferensi System Engine
            InferenceSystem IS = new InferenceSystem(fuzzyDB, new CentroidDefuzzifier(1000));

            // Rules
            IS.NewRule("Rule 1", "IF Kecepatan IS Lambat AND Jarak IS Dekat AND Kemiringan IS Turun THEN TingkatPengereman IS Kuat");
            IS.NewRule("Rule 2", "IF Kecepatan IS Lambat AND Jarak IS Dekat AND Kemiringan IS Naik THEN TingkatPengereman IS Lemah");
            IS.NewRule("Rule 3", "IF Kecepatan IS Lambat AND Jarak IS Dekat AND Kemiringan IS Datar THEN TingkatPengereman IS Sedang");
            IS.NewRule("Rule 4", "IF Kecepatan IS Lambat AND Jarak IS Jauh AND Kemiringan IS Datar THEN TingkatPengereman IS Lemah");
            IS.NewRule("Rule 5", "IF Kecepatan IS Lambat AND Jarak IS Jauh AND Kemiringan IS Naik THEN TingkatPengereman IS Lemah");
            IS.NewRule("Rule 6", "IF Kecepatan IS Lambat AND Jarak IS Jauh AND Kemiringan IS Turun THEN TingkatPengereman IS Sedang");
            IS.NewRule("Rule 7", "IF Kecepatan IS Lambat AND Jarak IS SangatJauh AND Kemiringan IS Datar THEN TingkatPengereman IS Lemah");
            IS.NewRule("Rule 8", "IF Kecepatan IS Lambat AND Jarak IS SangatJauh AND Kemiringan IS Naik THEN TingkatPengereman IS Lemah");
            IS.NewRule("Rule 9", "IF Kecepatan IS Lambat AND Jarak IS SangatJauh AND Kemiringan IS Turun THEN TingkatPengereman IS Sedang");
            IS.NewRule("Rule 10", "IF Kecepatan IS Sedang AND Jarak IS Dekat AND Kemiringan IS Datar THEN TingkatPengereman IS Kuat");
            IS.NewRule("Rule 11", "IF Kecepatan IS Sedang AND Jarak IS Dekat AND Kemiringan IS Naik THEN TingkatPengereman IS Sedang");
            IS.NewRule("Rule 12", "IF Kecepatan IS Sedang AND Jarak IS Dekat AND Kemiringan IS Turun THEN TingkatPengereman IS Kuat");
            IS.NewRule("Rule 13", "IF Kecepatan IS Sedang AND Jarak IS Jauh AND Kemiringan IS Datar THEN TingkatPengereman IS Sedang");
            IS.NewRule("Rule 14", "IF Kecepatan IS Sedang AND Jarak IS Jauh AND Kemiringan IS Naik THEN TingkatPengereman IS Lemah");
            IS.NewRule("Rule 15", "IF Kecepatan IS Sedang AND Jarak IS Jauh AND Kemiringan IS Turun THEN TingkatPengereman IS Kuat");
            IS.NewRule("Rule 16", "IF Kecepatan IS Sedang AND Jarak IS SangatJauh AND Kemiringan IS Datar THEN TingkatPengereman IS Lemah");
            IS.NewRule("Rule 17", "IF Kecepatan IS Sedang AND Jarak IS SangatJauh AND Kemiringan IS Naik THEN TingkatPengereman IS Lemah");
            IS.NewRule("Rule 18", "IF Kecepatan IS Sedang AND Jarak IS SangatJauh AND Kemiringan IS Turun THEN TingkatPengereman IS Sedang");
            IS.NewRule("Rule 19", "IF Kecepatan IS Cepat AND Jarak IS Dekat AND Kemiringan IS Datar THEN TingkatPengereman IS Kuat");
            IS.NewRule("Rule 20", "IF Kecepatan IS Cepat AND Jarak IS Dekat AND Kemiringan IS Naik THEN TingkatPengereman IS Sedang");
            IS.NewRule("Rule 21", "IF Kecepatan IS Cepat AND Jarak IS Dekat AND Kemiringan IS Turun THEN TingkatPengereman IS Kuat");
            IS.NewRule("Rule 22", "IF Kecepatan IS Cepat AND Jarak IS Jauh AND Kemiringan IS Datar THEN TingkatPengereman IS Kuat");
            IS.NewRule("Rule 23", "IF Kecepatan IS Cepat AND Jarak IS Jauh AND Kemiringan IS Naik THEN TingkatPengereman IS Sedang");
            IS.NewRule("Rule 24", "IF Kecepatan IS Cepat AND Jarak IS Jauh AND Kemiringan IS Turun THEN TingkatPengereman IS Kuat");
            IS.NewRule("Rule 25", "IF Kecepatan IS Cepat AND Jarak IS SangatJauh AND Kemiringan IS Datar THEN TingkatPengereman IS Sedang");
            IS.NewRule("Rule 26", "IF Kecepatan IS Cepat AND Jarak IS SangatJauh AND Kemiringan IS Naik THEN TingkatPengereman IS Lemah");
            IS.NewRule("Rule 27", "IF Kecepatan IS Cepat AND Jarak IS SangatJauh AND Kemiringan IS Turun THEN TingkatPengereman IS Kuat");

            // Set Input

            IS.SetInput("Kecepatan", (float)Convert.ToDouble(TB_Speed.Value));
            IS.SetInput("Jarak", (float)Convert.ToDouble(TB_Distance.Value));
            if (TB_AngleMin.Value != 0)
            {
                IS.SetInput("Kemiringan", (float)Convert.ToDouble(TB_AngleMin.Value));
            }
            IS.SetInput("Kemiringan", (float)Convert.ToDouble(TB_AnglePlus.Value));

            // Get output
            double BrakeLevel = IS.Evaluate("TingkatPengereman");

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
    }
}

