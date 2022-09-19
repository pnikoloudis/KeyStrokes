using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;

namespace KeyStrokes
{
    public partial class Form1 : Form
    {
        public int countKeys = 0;
        public bool isFirstTime = true;

        public Form1()
        {
            InitializeComponent();
            RichTxtBox.Multiline = true;
            RichTxtBox.KeyDown += RichTxtBox_KeyDown;
        }

        private void RichTxtBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if(isFirstTime)
            {
                RichTxtBox.AppendText($"KeyDown code: {e.KeyCode}, value: {e.KeyValue}, modifiers: {e.Modifiers}" + Environment.NewLine);
                countKeys++;
                TxtCounter.Text = countKeys.ToString();
                isFirstTime = false;
            }
            else
            {
                RichTxtBox.AppendText(Environment.NewLine);
                RichTxtBox.AppendText($"KeyDown code: {e.KeyCode}, value: {e.KeyValue}, modifiers: {e.Modifiers}" + Environment.NewLine);
                countKeys++;
                TxtCounter.Text = countKeys.ToString();
            }
        }

        private void TxtCounter_TextChanged(object sender, EventArgs e)
        {
            //nothing to add here...
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        //The following piece of code closes the window when pressing the 'Esc' button.
        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (keyData == (Keys.Escape))
        //    {
        //        Close();
        //        return true;
        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}
    }
}