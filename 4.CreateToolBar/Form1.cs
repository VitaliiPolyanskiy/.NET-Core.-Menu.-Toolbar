using System.Text;

namespace _4.CreateToolBar
{
    public partial class Form1 : Form
    {
        ToolStrip tBar;
        ImageList list;
       
        public Form1()
        {
            InitializeComponent();
            list = new ImageList();
            list.ImageSize = new Size(32, 32);
            byte[] imageBytes = Properties.Resources.Open;
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                list.Images.Add(Image.FromStream(ms));
            }
            imageBytes = Properties.Resources.Save;
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                list.Images.Add(Image.FromStream(ms));
            }
            imageBytes = Properties.Resources.Exit;
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                list.Images.Add(Image.FromStream(ms));
            }

            tBar = new ToolStrip();

            tBar.ImageList = list; //привяжем список картинок к тулбару
            ToolStripButton toolBarButton1 = new ToolStripButton();
            toolBarButton1.Click += new EventHandler(tBar_ButtonClick);
            ToolStripButton toolBarButton2 = new ToolStripButton();
            toolBarButton2.Click += new EventHandler(tBar_ButtonClick);
            ToolStripButton toolBarButton3 = new ToolStripButton();
            toolBarButton3.Click += new EventHandler(tBar_ButtonClick);

            toolBarButton1.ImageIndex = 0; //Open
            toolBarButton2.ImageIndex = 1; // Save
            toolBarButton3.ImageIndex = 2; //Exit

            tBar.Items.Add(toolBarButton1);
            tBar.Items.Add(toolBarButton2);
            tBar.Items.Add(toolBarButton3);

            Controls.Add(tBar);

        }

        void tBar_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                ToolStripButton toolBarButton = (ToolStripButton)sender;
                OpenFileDialog f1;
                SaveFileDialog f2;
                switch (toolBarButton.ImageIndex)
                {
                    case 0:

                        f1 = new OpenFileDialog();
                        if (f1.ShowDialog() == DialogResult.OK)
                        {
                            StreamReader r = new StreamReader(f1.FileName, Encoding.Default);
                            textBox1.Text = r.ReadToEnd();
                            r.Close();
                        }
                        break;
                    case 1:
                        f2 = new SaveFileDialog();
                        if (f2.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter w = new StreamWriter(f2.FileName);
                            w.WriteLine(textBox1.Text);
                            w.Close();
                        }
                        break;
                    case 2:
                        Close();
                        break;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}