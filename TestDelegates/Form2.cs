namespace TestDelegates
{
    public partial class Form2 : Form
    {
        private Action<string, bool> _applyCallback;
        public Form2(Action<string, bool> applyCallback)
        {
            _applyCallback = applyCallback;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _applyCallback?.Invoke(textBox1.Text, checkBox1.Checked);
            Close();
        }
    }
}
