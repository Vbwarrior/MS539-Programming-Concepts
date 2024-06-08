namespace Exception_Handling_Demo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

            int txtLength = txtTextOnly.Text.Length;

            for (int i = 0; i < txtLength; i++)
            {
                if (!(char.IsLetter(txtTextOnly.Text[i])))
                {
                    if (txtTextOnly.Text[i] == ' ') { continue; }
                    errorProvider1.SetError(txtTextOnly, "Only Letters Allowed");
                    break;
                }
            }


            if (!int.TryParse(txtIntegersOnly.Text, out int myInt))
            {
                errorProvider2.SetError(txtIntegersOnly, "Only Integers Allowed");
            }

          string boolTest =  txtBooleaneOnly.Text.ToLower();
            if (!bool.TryParse(boolTest, out bool myBool))
            {
                errorProvider3.SetError(txtBooleaneOnly, "Only true and false answers allowed");
            }

            if(numOddNumbersOnly.Value %2 ==0)
            {
                errorProvider4.SetError(numOddNumbersOnly, "Only odd numbers allowed");

            }




        }
    }
}
