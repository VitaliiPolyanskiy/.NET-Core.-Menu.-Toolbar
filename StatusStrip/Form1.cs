namespace StatusStrip
{
    public partial class Form1 : Form
    {
        Random random;  
        public Form1()
        {
            InitializeComponent();

            infoLabel.Text = "Текущие дата и время:";
            string str = DateTime.Now.DayOfWeek.ToString();
            dayOfWeek.Text = str;
            timer1.Start();
            random = new Random();  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            toolStripProgressBar1.Value = random.Next(100);
        }
    }
}
