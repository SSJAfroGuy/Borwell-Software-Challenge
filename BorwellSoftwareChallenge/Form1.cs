using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace BorwellSoftwareChallenge
{
    public partial class frnHome : Form
    {
        //Declare and set variables to a defauly value
        double Volume = 0;
        double AreaOfFloor = 0;
        double AmountOfPaint = 0;
        int error = 0;

        public frnHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialise soundPlayer
            SoundPlayer Music = new SoundPlayer
            {
                SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\BG_Music.wav"
            };
            //Plays BGM
            Music.PlayLooping();
        }

        //This method will ensure only numbers can be entered into specific text boxes - Called by all USER INPUT text boxes that should only accept numbers
        private void Numbers_Only(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            //Checks the value entered in the text box is a digit. 8 = backspace key 46 = Del key. Allows user to delete their inputs.
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        //Methods below run the Numbers_Only method to make sure a user can't input non numeric values. This also has validation to ensure only 1 decimal can be used. 
        private void TxtbWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numbers_Only(sender, e);

            if (e.KeyChar == '.')
            {
                if (txtbWidth.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
        }

        private void TxtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numbers_Only(sender, e);

            if (e.KeyChar == '.')
            {
                if (txtbHeight.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
        }

        private void TxtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numbers_Only(sender, e);

            if (e.KeyChar == '.')
            {
                if (txtbLength.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
        }

        //Validates and calculates the users inputs. This should be split between multiple functions to follow OOP better :v
        private void BtnCalculate_Click(object sender, EventArgs e)
        {

            //Checks to ensure the user hasn't only entered a decimal point
            if (txtbWidth.Text == "." || txtbHeight.Text == "." || txtbLength.Text == ".")
            {
                //Sets the error vriable to be 1 - indicates there is an error
                error = 1;

                //Initialise variables for MessageBox
                string MessageText = "Please insert some numbers before your decimal point";
                string CaptionText = "User input error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                //Shows the MessageBox
                MessageBox.Show(MessageText, CaptionText, buttons);
            }

            //checks to make sure the user has input values
            else if (txtbHeight.TextLength == 0 || txtbWidth.TextLength == 0 || txtbLength.TextLength == 0)
            {
                //Sets the error vriable to be 1 - indicates there is an error
                error = 1;

                //Initialise variables for MessageBox
                string MessageText = "Please input all the data required";
                string CaptionText = "User input error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                //Shows the MessageBox
                MessageBox.Show(MessageText, CaptionText, buttons);
            }

            //Checks to see if the user has input valid numbers
            else if (Convert.ToDouble(txtbWidth.Text) <= 0 || (Convert.ToDouble(txtbLength.Text) <= 0 || (Convert.ToDouble(txtbHeight.Text) <= 0)))
            {
                //Sets the error vriable to be 1 - indicates there is an error
                error = 1;

                //Initialise variables for MessageBox
                string MessageText = "Please input realistic data (0 is not a realistic value)";
                string CaptionText = "User input error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                //Shows the MessageBox
                MessageBox.Show(MessageText, CaptionText, buttons);
            }

            else
            {
                //If all values are present, ensure the program knows there are no errors
                error = 0;
            }

            //If there are no errors do the calculations (All of these would require seperate unit tests to ensure the values all calculate properly independently. 
            if (error == 0)
            {
                //Calculates the volume for the room (W * L * H)
                Volume = (Convert.ToDouble(txtbWidth.Text) * Convert.ToDouble(txtbLength.Text) * Convert.ToDouble(txtbHeight.Text));

                //Calculates the area for the floor (L * W) 
                AreaOfFloor = Convert.ToDouble(txtbWidth.Text) * Convert.ToDouble(txtbLength.Text);

                //Calculate amount of paint needed. Find area of walls - 2 walls will have different areas, each side will be matching. 1Litre for every 10m^2 - divide end result by 10. Consider rounding?
                AmountOfPaint = (((2 * (Convert.ToDouble(txtbWidth.Text) * Convert.ToDouble(txtbHeight.Text))) + (2 * (Convert.ToDouble(txtbWidth.Text) * Convert.ToDouble(txtbHeight.Text)))) / 10);

                //Update text boxes to show the calculated variables
                txtbVolumeOfRoom.Text = Convert.ToString(Volume);
                txtbAreaOfFloor.Text = Convert.ToString(AreaOfFloor);
                txtbAmountOfPaint.Text = Convert.ToString(AmountOfPaint);
            }
        }
    }
}
