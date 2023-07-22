
using Microsoft.Win32.SafeHandles;
using System;

namespace XO_game;

public partial class MainPage : ContentPage
{

  

    int x = 0;
    String winner = "x win";
	public MainPage()
	{
		InitializeComponent();
	}

    // Declare the field 'c' outside the method or within the class
    private string c = "x";


    private void btn_Clicked(object sender, EventArgs e)
    {
        Button[] buttons = new Button[9];
        buttons[0] = btn0;
        buttons[1] = btn1;
        buttons[2] = btn2;
        buttons[3] = btn3;
        buttons[4] = btn4;
        buttons[5] = btn5;
        buttons[6] = btn6;
        buttons[7] = btn7;
        buttons[8] = btn8;

        if (sender is Button button)
        {
            button.Text = c;
            button.IsEnabled = false;
            if (c == "x")
            {
               
                title.Text = "o turn";
                
            }
            else if (c == "o")
            {
                title.Text =  "x turn";
            }
            test(buttons, 0, 1, 2);
            test(buttons, 3, 4, 5);
            test(buttons, 6, 7, 8);
            test(buttons, 0, 3, 6);
            test(buttons, 1, 4, 7);
            test(buttons, 2, 5, 8);
            test(buttons, 0, 4, 8);
            test(buttons, 2, 4,6);
            if (c == "x")
            {
                c = "o";
            }
            else if (c == "o")
            {
                c = "x";
            }
            
        }

    }


// ...

private void test(Button[] btn, int x, int y, int z)
{
    if (btn[x].Text == btn[y].Text && btn[x].Text == btn[z].Text && btn[x].Text != "")
    {
        for (int i = 0; i < 9; i++)
        {
            btn[i].IsEnabled = false; 
        }

        winner = btn[x].Text + " wins!"; 
        title.Text = winner;

            btn[x].BackgroundColor = Color.FromHex("#F00");
            btn[y].BackgroundColor = Color.FromHex("#F00");
            btn[z].BackgroundColor = Color.FromHex("#F00");
            titleBg.BackgroundColor = Color.FromHex("#F00");
            title.TextColor = Color.FromHex("#FFF");

        }
}


private void settings_Clicked(object sender, EventArgs e)
    {
        Button[] buttons = new Button[9];
        buttons[0] = btn0;
        buttons[1] = btn1;
        buttons[2] = btn2;
        buttons[3] = btn3;
        buttons[4] = btn4;
        buttons[5] = btn5;
        buttons[6] = btn6;
        buttons[7] = btn7;
        buttons[8] = btn8;
        for (int i = 0; i < 9; i++)

        {
            title.Text = c + " turn";
            buttons[i].Text = "";
            buttons[i].IsEnabled = true;
            buttons[i].BackgroundColor = Color.FromHex("#000");
            titleBg.BackgroundColor = Color.FromHex("#0f0");
            title.TextColor = Color.FromHex("#000");
        }
    }
}

