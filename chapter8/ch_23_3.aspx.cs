//import header files and namespace

using System;

using System.Drawing;

using System.Web.UI.WebControls;

//namespace to hold the application

namespace _10201_19_3E

{

    //Class to define the timeshow

    public partial class WebTimeShow : System.Web.UI.Page

    {

      /*Method to handle the Init Event of the WebPage */

      protected void Page_Init(object sender,EventArgs e)

        {

            //show the time when the page gets initiated

            lblWebTime.Text =

             DateTime.Now.ToString("HH:MM:ss");

        }

        /* Method to change the text color */

        protected void TextColor_SelectedIndexChanged

                               (object sender, EventArgs e)

        {

            //switch to the appropriate index that is

            //selected

            switch (TextColor.SelectedIndex)

            {

                //set the white color

                case 0:

                    lblWebTime.ForeColor = Color.White;

                    break;

                //set the green color

                case 1:

                    lblWebTime.ForeColor = Color.Green;

                    break;

                //set the blue color

                case 2:

                    lblWebTime.ForeColor = Color.Blue;

                    break;

                //set the red color

                case 3:

                    lblWebTime.ForeColor = Color.Red;

                    break;

            }

        }

/*Method to change the background color*/

protected void ddlBackColor_SelectedIndexChanged(object sender, EventArgs e)

        {

            switch (ddlBackColor.SelectedIndex)

            {

                //change the color to green

                case 0:

                    lblWebTime.BackColor = Color.Green;

                    break;

                //change the color to blue

                case 1:

                    lblWebTime.BackColor = Color.Blue;

                    break;

                //change the color to red

                case 2:

                    lblWebTime.BackColor = Color.Red;

                    break;

            }

        }

        /* Method to change the font size*/

        protected void DropDownList1_SelectedIndexChanged

                               (object sender, EventArgs e)

        {

            switch (ddlFont.SelectedIndex)

            {

                //change the largest font size

                case 0:

                    lblWebTime.Font.Size =

                                  FontUnit.XXLarge;

                    break;

                //change the larger font size

                case 1:

                    lblWebTime.Font.Size = FontUnit.XLarge;

                    break;

                //set the smaller font size

                case 2:

                    lblWebTime.Font.Size =FontUnit.XXSmall;

                    break;

                //change the smallest font size

                case 3:

                    lblWebTime.Font.Size = FontUnit.XSmall;

                    break;

            }

        }

    }

}
