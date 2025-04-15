using System.Text;
using Challenge.BolivarJimenez.Helpers;

namespace Challenge.BolivarJimenez;

public partial class OldPhone : Form
{
    const string SendKey = "#";     // Send key
    string output = String.Empty;   // Output to be displayed on simulated old phone screen
    private bool newInput = true;

    public OldPhone()
    {
        InitializeComponent();
    }
    private void Button_Click(object sender, EventArgs e)
    {
        // Get key "text" as current key
        string currentKey = ((Button)sender).Text;
        
        // Check for new input
        if(newInput)
        {
            // First run or new input; clear screen
            txtDisplay.Text = String.Empty;
            newInput = false;
        }
        
        // Update screen with current key
        txtDisplay.Text += currentKey;

        // If send key (#) start processing
        if (currentKey == SendKey)
        {
            // Process input and show result on screen
            output = Helper.OldPhonePad(txtDisplay.Text);
            txtDisplay.Text = output;
            
            // Reset state waiting for next input
            output = String.Empty;
            newInput = true;
        }
    }        
}
