namespace PlatigeImage.Forms
{
    public partial class NumberOfDataToGenerateForm : Form
    {
        public int InputValue { get; private set; }

        public NumberOfDataToGenerateForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int inputValue;
            if (int.TryParse(teNumberOfDataToGenerate.Text, out inputValue))
            {
                InputValue = inputValue;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Proszę wprowadzić poprawną liczbę.");
            }            
        }
    }
}
