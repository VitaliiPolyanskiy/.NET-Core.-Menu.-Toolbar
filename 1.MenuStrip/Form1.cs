namespace _1.MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem obj = (ToolStripMenuItem)sender;
            MessageBox.Show(obj.Text);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem obj = (ToolStripMenuItem)sender;
            MessageBox.Show(obj.Text);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem obj = (ToolStripMenuItem)sender;
            MessageBox.Show(obj.Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem obj = (ToolStripMenuItem)sender;
            MessageBox.Show(obj.Text);
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem obj = (ToolStripMenuItem)sender;
            MessageBox.Show(obj.Text);
        }
    }
}