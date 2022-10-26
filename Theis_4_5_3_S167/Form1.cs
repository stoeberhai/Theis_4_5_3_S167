namespace Theis_4_5_3_S167
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            int a = 9;
            int b = 21;
            LblInputData.Text = "a = " + a + "\nb = " + b;
            LblOutputData.Text = "Das Maximum von a und b = " + CalcMaxValue(a, b);
        }

        private int CalcMaxValue(int x, int y)
            {
                return Math.Max(x, y);
            }
    }
}