using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostageCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }
        protected void Change(object sender, EventArgs e)
        {
            Mainfunc();
        }

        protected void Mainfunc()
        {
            //check for text/check boxes values if dont exist
            if (!valuesExist()) return;
            //volume logic(L*W*H)
            int volume = 0;
            if (!tryGetVolume(out volume)) return;
            //assigning multipliers ground-.15, air-.25, nextday-.45
            double multiplier = getMultiplier();
            //determine cost(volume * multiplier)
            double cost = volume * multiplier;
            //show user the info
            Label1.Text = String.Format("Your parcel will cost {0} to ship.",cost);
        }
        //checks to see if values exist; returns them if they do
        private bool valuesExist()
        {
            //check for buttons
            if (!RadioButton1.Checked 
                && !RadioButton2.Checked
                && !RadioButton3.Checked)
                return false;
            // check for textboxes
            if (TextBox1.Text.Trim().Length == 0 
                || TextBox2.Text.Trim().Length == 0
                )
                return false;
            //if values are present then continue
            return true;
        }
        //logic for volume calculation
        private bool tryGetVolume(out int volume)
        {
            //init vars
            volume = 0;
            int width = 0;
            int height = 0;
            int length = 0;
            //link text boxes to variables
            //also check to make sure txtbox values can be parsed into integers
            if (!int.TryParse(TextBox1.Text.Trim(), out width)) return false;
            if (!int.TryParse(TextBox2.Text.Trim(), out height)) return false;
            if (!int.TryParse(TextBox3.Text.Trim(), out length)) length = 1;
            //if values are present then continue
            volume = width * height * length;
            return true;
        }
        //logic for multiplier
        private double getMultiplier()
        {
            if (RadioButton1.Checked) return .15;
            else if (RadioButton2.Checked) return .25;
            else if (RadioButton3.Checked) return .45;
            else return 0;
        }
    }
}