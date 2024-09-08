

namespace MAS1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        public int[][] mass =
            {
            new int[] { 1, 2, 3, 4, 5, 6},
            new int[] { 0, 0, 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0, 0, 0},
            };
        public int[][] gg =
            {
            new int[] { 1, 2, 3, 4, 5},
            new int[] { 0, 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0, 0},
            };








        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox8.Text) > 5)
                {
                    textBox8.Clear();
                }
            }
            catch { }

            if (!Char.IsDigit(e.KeyChar))
            {
                // Запрет на ввод более одной десятичной точки.
                if (Convert.ToInt32(e.KeyChar) > 6 || e.KeyChar != 1)
                {   
                    
                    e.Handled = true;
                }
                
                
            }






        }
        static int[] BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }




        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            mass[0][0] = rnd.Next(-20, 30);
            mass[0][1] = rnd.Next(-20, 30);
            mass[0][2] = rnd.Next(-20, 30);
            mass[0][3] = rnd.Next(-20, 30);
            mass[0][4] = rnd.Next(-20, 30);
            mass[0][5] = rnd.Next(-20, 30);
            mass[1][0] = rnd.Next(-20, 30);
            mass[1][1] = rnd.Next(-20, 30);
            mass[1][2] = rnd.Next(-20, 30);
            mass[1][3] = rnd.Next(-20, 30);
            mass[1][4] = rnd.Next(-20, 30);
            mass[1][5] = rnd.Next(-20, 30);
            mass[2][0] = rnd.Next(-20, 30);
            mass[2][1] = rnd.Next(-20, 30);
            mass[2][2] = rnd.Next(-20, 30);
            mass[2][3] = rnd.Next(-20, 30);
            mass[2][4] = rnd.Next(-20, 30);
            mass[2][5] = rnd.Next(-20, 30);
            mass[3][0] = rnd.Next(-20, 30);
            mass[3][1] = rnd.Next(-20, 30);
            mass[3][2] = rnd.Next(-20, 30);
            mass[3][3] = rnd.Next(-20, 30);
            mass[3][4] = rnd.Next(-20, 30);
            mass[3][5] = rnd.Next(-20, 30);
            mass[4][0] = rnd.Next(-20, 30);
            mass[4][1] = rnd.Next(-20, 30);
            mass[4][2] = rnd.Next(-20, 30);
            mass[4][3] = rnd.Next(-20, 30);
            mass[4][4] = rnd.Next(-20, 30);
            mass[4][5] = rnd.Next(-20, 30);

            label4.Text = ($"{mass[0][0]}     {mass[0][1]}         {mass[0][2]}           {mass[0][3]}           {mass[0][4]}           {mass[0][5]}");
            label5.Text = ($"{mass[1][0]}     {mass[1][1]}         {mass[1][2]}           {mass[1][3]}           {mass[1][4]}           {mass[1][5]}");
            label6.Text = ($"{mass[2][0]}     {mass[2][1]}         {mass[2][2]}           {mass[2][3]}           {mass[2][4]}           {mass[2][5]}");
            label7.Text = ($"{mass[3][0]}     {mass[3][1]}         {mass[3][2]}           {mass[3][3]}           {mass[3][4]}           {mass[3][5]}");
            label8.Text = ($"{mass[4][0]}     {mass[4][1]}         {mass[4][2]}           {mass[4][3]}           {mass[4][4]}           {mass[4][5]}");


            gg[0][0] = mass[0][0];
            gg[0][1] = mass[1][0];
            gg[0][2] = mass[2][0];
            gg[0][3] = mass[3][0];
            gg[0][4] = mass[4][0];

            gg[1][0] = mass[0][1];
            gg[1][1] = mass[1][1];
            gg[1][2] = mass[2][1];
            gg[1][3] = mass[3][1];
            gg[1][4] = mass[4][1];

            gg[2][0] = mass[0][2];
            gg[2][1] = mass[1][2];
            gg[2][2] = mass[2][2];
            gg[2][3] = mass[3][2];
            gg[2][4] = mass[4][2];

            gg[3][0] = mass[0][3];
            gg[3][1] = mass[1][3];
            gg[3][2] = mass[2][3];
            gg[3][3] = mass[3][3];
            gg[3][4] = mass[4][3];

            gg[4][0] = mass[0][4];
            gg[4][1] = mass[1][4];
            gg[4][2] = mass[2][4];
            gg[4][3] = mass[3][4];
            gg[4][4] = mass[4][4];

            gg[5][0] = mass[0][5];
            gg[5][1] = mass[1][5];
            gg[5][2] = mass[2][5];
            gg[5][3] = mass[3][5];
            gg[5][4] = mass[4][5];

















            //label9.Text = ($"{mass[5][0]}           {mass[5][1]}           {mass[5][2]}           {mass[5][3]}           {mass[5][4]}");
        }

        private int[] bol(int[] x)
        {
            int h = x[0];
            for (int i = 1; i < 6; i++)
            {
                if (x[i] > h)
                {
                    h = x[i];
                }
            }
            return x;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int[] g = [-21, -22, -23, -24, -25, -26];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (mass[j][i] > g[i])
                    {
                        g[i] = mass[j][i];
                        gg[i].Append(mass[j][i]);
                    }
                }
            }

            textBox2.Text = Convert.ToString(g[0]);
            textBox3.Text = Convert.ToString(g[1]);
            textBox4.Text = Convert.ToString(g[2]);
            textBox5.Text = Convert.ToString(g[3]);
            textBox6.Text = Convert.ToString(g[4]);
            textBox7.Text = Convert.ToString(g[5]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox7_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox8.Text) > 6 || Convert.ToInt32(textBox8.Text) < 1)  
            {
                textBox8.Clear();
                
            }
            else
            {
                string st = textBox8.Text;
                int y;
                int.TryParse(st, out y);
                y = y - 1;


                textBox1.Text = ($"{Convert.ToString(BubbleSort(gg[y])[0])}   {Convert.ToString(BubbleSort(gg[y])[1])}   {Convert.ToString(BubbleSort(gg[y])[2])}   {Convert.ToString(BubbleSort(gg[y])[3])}   {Convert.ToString(BubbleSort(gg[y])[4])}");
                //textBox1.Text = ($"{Convert.ToString(BubbleSort(gg[Convert.ToInt32(textBox8.Text)])[0])}");

            }
        }
           

        private void button4_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
        }
    }
}
