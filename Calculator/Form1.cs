namespace Calculator
{
    public partial class Form1 : Form
    {
        public CalculatorLogic calc;
        public Form1()
        {
            InitializeComponent();
            calc = new CalculatorLogic(textBox1);
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            calc.AddNum(byte.Parse(((Button)sender).Text));
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            clearAction();
            ((Button)sender).BackColor = Color.Yellow;

            calc.SetAction(((Button)sender).Text[0]);
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            clearAction();
            calc.Calculate();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAction();
            calc.Clear();
        }

        private void clearAction()
        {
            button13.BackColor = SystemColors.HotTrack;
            button14.BackColor = SystemColors.HotTrack;
            button15.BackColor = SystemColors.HotTrack;
            button16.BackColor = SystemColors.HotTrack;
        }
    }
}