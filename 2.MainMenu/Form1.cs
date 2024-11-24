namespace _2.MainMenu
{
    public partial class Form1 : Form
    {
        MenuStrip MyMenu;
        ToolStripMenuItem m1, m2, subm1, subm2, subm3, subm4, subm5, subm6;
        Label l;
        bool flag = true;
        bool flag2 = true;
        public Form1()
        {
            InitializeComponent();
            l = new Label();
            l.Parent = this;
            l.Location = new Point(10, 100);
            l.Width = 200;
            l.Height = 50;
            l.BorderStyle = BorderStyle.FixedSingle;
            this.Text = "Работа с меню";
            MyMenu = new MenuStrip();
            m1 = new ToolStripMenuItem("Игра");
            m1.MouseEnter += new EventHandler(subm1_Select);
            MyMenu.Items.Add(m1);
            m2 = new ToolStripMenuItem("О программе");
            m2.MouseEnter += new EventHandler(subm1_Select);
            MyMenu.Items.Add(m2);
            subm1 = new ToolStripMenuItem("Начать игру");
            subm1.Click += new EventHandler(BeginGame);
            subm1.MouseEnter += new EventHandler(subm1_Select);
            m1.DropDownItems.Add(subm1);
            subm2 = new ToolStripMenuItem("Уровень");
            subm2.MouseEnter += new EventHandler(subm1_Select);
            m1.DropDownItems.Add(subm2);
            subm3 = new ToolStripMenuItem("Лёгкий уровень");
            subm2.DropDownItems.Add(subm3);
            subm3.Checked = true;
            subm4 = new ToolStripMenuItem("Средний уровень");
            subm2.DropDownItems.Add(subm4);
            subm5 = new ToolStripMenuItem("Сложный уровень");
            subm2.DropDownItems.Add(subm5);
          
            subm3.Click += new EventHandler(Level);

            subm3.MouseEnter += new EventHandler(subm1_Select);
            subm4.Click += new EventHandler(Level); ;
            subm4.MouseEnter += new EventHandler(subm1_Select);
            subm5.Click += new EventHandler(Level); ;
            subm5.MouseEnter += new EventHandler(subm1_Select);
            subm6 = new ToolStripMenuItem("Выход");
            m1.DropDownItems.Add(subm6);
            subm6.Click += new EventHandler(Quit);
            subm6.MouseEnter += new EventHandler(subm1_Select);
            Controls.Add(MyMenu);
            MainMenuStrip = MyMenu;
        }

        private void subm1_Select(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem) sender;
            l.Text = item.Text;
        }

        //обработчик пункта меню Уровень

        private void Level(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            for (int i = 0; i < subm2.DropDownItems.Count; i++)
            {
                ToolStripMenuItem menuitem = (ToolStripMenuItem) subm2.DropDownItems[i];
                menuitem.Checked = false;
            }
            item.Checked = true;
            MessageBox.Show("Пункт меню " + item.Text);
        }


        //обработчик пункта меню Выход
        private void Quit(object sender, EventArgs e)
        {
            Close();
        }

        //обработчик пункта меню Начать игру
        private void BeginGame(object sender, EventArgs e)
        {
            MessageBox.Show("Пункт меню 'Начать игру'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag2)
            {
                button1.Text = "Включить пункт меню \"О программе\"";
                MyMenu.Items.Remove(m2);
            }
            else
            {
                button1.Text = "Отключить пункт меню \"О программе\"";
                m2 = new ToolStripMenuItem("О программе");
                m2.MouseEnter += new EventHandler(subm1_Select);
                MyMenu.Items.Add(m2);
            }
            flag2 = !flag2;
        }
    }
}