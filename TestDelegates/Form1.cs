namespace TestDelegates
{
    public partial class Form1 : Form
    {
        private const string _checked = "checked";
        private const string _unchecked = "unckecked";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Form2(UpdateUI);
            form2.ShowDialog();
        }

        private void UpdateUI(string text, bool check)
        {
            label1.Text = $"{text} - {GetChecked(check)}";
        }

        private string GetChecked(bool check)
        {
            return check ? _checked : _unchecked;
        }
    }
}
