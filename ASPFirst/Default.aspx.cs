using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPFirst
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        int int_noOfClicks = 0;
        int[,] gameArray = new int[3, 3];


        public void checkCamp()
        {
            if (Session["camp"] == null)
            {
                Session["camp"] = "X";
            }
            else
            {
                if (Session["camp"] == "X")
                {
                    Session["camp"] = "O";
                }
                else
                {
                    Session["camp"] = "X";
                }
            }
        }
        
        public void buttonAction(Button button, string camp)
        {
            if (button.Text == " ")
            {
                button.Text = camp;
                button.Enabled = false;
                btn_start.Enabled = false;
                btn_start.Text = "You need to finish the game first...";
                if(camp == "X")
                {
                    lbl_message.Text = "0 is next";
                }
                else
                {
                    lbl_message.Text = "X is next";
                }
            }
        }

        public void checkRow(Button button_1, Button button_2, Button button_3, string message, string camp)
        {
            if (button_1.Text == camp && button_2.Text == camp && button_3.Text == camp)
            {
                lbl_message.Text = camp + message;
                btn_start.Enabled = true;
                btn_start.Text = "Start A New Game";
                disableAllButtons();
            }
        }

        public void disableAllButtons()
        {
            btn_1.Enabled = false;
            btn_2.Enabled = false;
            btn_3.Enabled = false;
            btn_4.Enabled = false;
            btn_5.Enabled = false;
            btn_6.Enabled = false;
            btn_7.Enabled = false;
            btn_8.Enabled = false;
            btn_9.Enabled = false;
        }

        public void checkVictory(string camp)
        {
            //horizontal lines
            checkRow(btn_1, btn_2, btn_3, " Wins!", camp);
            checkRow(btn_4, btn_5, btn_6, " Wins!", camp);
            checkRow(btn_7, btn_8, btn_9, " Wins!", camp);
            //vertical lines
            checkRow(btn_1, btn_4, btn_7, " Wins!", camp);
            checkRow(btn_2, btn_5, btn_8, " Wins!", camp);
            checkRow(btn_3, btn_6, btn_9, " Wins!", camp);
            //diagonals
            checkRow(btn_1, btn_5, btn_9, " Wins!", camp);
            checkRow(btn_3, btn_5, btn_7, " Wins!", camp);

            if (btn_1.Text != " " && btn_2.Text != " " && btn_3.Text != " " && btn_4.Text != " " && btn_5.Text != " " && btn_6.Text != " " && btn_7.Text != " " && btn_8.Text != " " && btn_9.Text != " ")
            {
                lbl_message.Text = "Draw!";
                btn_start.Enabled = true;
                btn_start.Text = "Start A New Game";
                disableAllButtons();
            }
        }

        public void resetBoard()
        {
            btn_1.Text = " "; 
            btn_1.Enabled = true;

            btn_2.Text = " "; 
            btn_2.Enabled = true;

            btn_3.Text = " "; 
            btn_3.Enabled = true;

            btn_4.Text = " "; 
            btn_4.Enabled = true;

            btn_5.Text = " "; 
            btn_5.Enabled = true;

            btn_6.Text = " "; 
            btn_6.Enabled = true;

            btn_7.Text = " "; 
            btn_7.Enabled = true;

            btn_8.Text = " "; 
            btn_8.Enabled = true;

            btn_9.Text = " "; 
            btn_9.Enabled = true;

            Session["camp"] = null;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btn_1_Click(object sender, EventArgs e)
        {
            checkCamp();
            buttonAction(btn_1, Session["camp"].ToString());
            checkVictory(Session["camp"].ToString());
        }

        protected void btn_2_Click(object sender, EventArgs e)
        {
            checkCamp();
            buttonAction(btn_2, Session["camp"].ToString());
            checkVictory(Session["camp"].ToString());
        }

        protected void btn_3_Click(object sender, EventArgs e)
        {
            checkCamp();
            buttonAction(btn_3, Session["camp"].ToString());
            checkVictory(Session["camp"].ToString());
        }

        protected void btn_4_Click(object sender, EventArgs e)
        {
            checkCamp();
            buttonAction(btn_4, Session["camp"].ToString());
            checkVictory(Session["camp"].ToString());
        }

        protected void btn_5_Click(object sender, EventArgs e)
        {
            checkCamp();
            buttonAction(btn_5, Session["camp"].ToString());
            checkVictory(Session["camp"].ToString());
        }

        protected void btn_6_Click(object sender, EventArgs e)
        {
            checkCamp();
            buttonAction(btn_6, Session["camp"].ToString());
            checkVictory(Session["camp"].ToString());
        }

        protected void btn_7_Click(object sender, EventArgs e)
        {
            checkCamp();
            buttonAction(btn_7, Session["camp"].ToString());
            checkVictory(Session["camp"].ToString());
        }

        protected void btn_8_Click(object sender, EventArgs e)
        {
            checkCamp();
            buttonAction(btn_8, Session["camp"].ToString());
            checkVictory(Session["camp"].ToString());
        }

        protected void btn_9_Click(object sender, EventArgs e)
        {
            checkCamp();
            buttonAction(btn_9, Session["camp"].ToString());
            checkVictory(Session["camp"].ToString());
        }

        protected void btn_start_Click(object sender, EventArgs e)
        {
            resetBoard();
        }
    }
}