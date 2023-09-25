using System.Text.RegularExpressions;

namespace kalkulator
{
    public partial class MainPage : ContentPage
    {
        private bool isRooted = true;
        private bool isMemory = false;
        private char CalcType;
        private double NumOne;
        private double NumTwo;
        private double pr;
        private double FinalNum;
        private double zam;

        public MainPage()
        {
            InitializeComponent();
        }

        private void On1Clicked(object sender, EventArgs e)
        {
            if(isRooted)
            {
                wynikLbl.Text = "1";
                isRooted = false;
            }
            else
            wynikLbl.Text += "1";
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void On2Clicked(object sender, EventArgs e)
        {
            if (isRooted)
            {
                wynikLbl.Text = "2";
                isRooted = false;
            }
            else
                wynikLbl.Text += "2";
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void On3Clicked(object sender, EventArgs e)
        {
            if (isRooted)
            {
                wynikLbl.Text = "3";
                isRooted = false;
            }
            else
                wynikLbl.Text += "3";
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void On4Clicked(object sender, EventArgs e)
        {
            if (isRooted)
            {
                wynikLbl.Text = "4";
                isRooted = false;
            }
            else
                wynikLbl.Text += "4";
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void On5Clicked(object sender, EventArgs e)
        {
            if (isRooted)
            {
                wynikLbl.Text = "5";
                isRooted = false;
            }
            else
                wynikLbl.Text += "5";
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void On6Clicked(object sender, EventArgs e)
        {
            if (isRooted)
            {
                wynikLbl.Text = "6";
                isRooted = false;
            }
            else
                wynikLbl.Text += "6";
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void On7Clicked(object sender, EventArgs e)
        {
            if (isRooted)
            {
                wynikLbl.Text = "7";
                isRooted = false;
            }
            else
                wynikLbl.Text += "7";
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void On8Clicked(object sender, EventArgs e)
        {
            if (isRooted)
            {
                wynikLbl.Text = "8";
                isRooted = false;
            }
            else
                wynikLbl.Text += "8";
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void On9Clicked(object sender, EventArgs e)
        {
            if (isRooted)
            {
                wynikLbl.Text = "9";
                isRooted = false;
            }
            else
                wynikLbl.Text += "9";
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void On0Clicked(object sender, EventArgs e)
        {
            if (!isRooted)
                wynikLbl.Text += "0";
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void OnDzClicked(object sender, EventArgs e)
        {
            if (CalcType != ' ')
                OnEqClicked(sender, e);
            double.TryParse(wynikLbl.Text, out pr);
            NumOne = pr;
            Oldequals.Text = NumOne.ToString() + " / ";
            CalcType = '/';
            isRooted = true;
            isMemory = false;

        }
        private void OnMnClicked(object sender, EventArgs e)
        {
            if (CalcType != ' ')
                OnEqClicked(sender, e);
            double.TryParse(wynikLbl.Text, out pr);
            NumOne = pr;
            Oldequals.Text = NumOne.ToString() + " * ";
            CalcType = '*';
            isRooted = true;
            isMemory = false;
        }
        private void OnOdClicked(object sender, EventArgs e)
        {
            if (CalcType != ' ')
                OnEqClicked(sender, e);
            double.TryParse(wynikLbl.Text, out pr);
            NumOne = pr;
            Oldequals.Text = NumOne.ToString() + " - ";
            CalcType = '-';
            isRooted = true;
            isMemory = false;
        }
        private void OnDoClicked(object sender, EventArgs e)
        {
            if(CalcType != ' ')
                OnEqClicked(sender, e);
            double.TryParse(wynikLbl.Text, out pr);
            NumOne = pr;
            Oldequals.Text = NumOne.ToString() + " + ";
            CalcType = '+';
            isRooted = true;
            isMemory = false;
        }
        private void OnUjClicked(object sender, EventArgs e)
        {
            if (!isRooted)
            {
                zam = double.Parse(wynikLbl.Text) * (-1);
                wynikLbl.Text = zam.ToString();
            }   
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void OnDotClicked(object sender, EventArgs e)
        {
            if (isRooted)
            {
                wynikLbl.Text += ".";
                isRooted = false;
            }
            else
                wynikLbl.Text += ",";
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void OnDelClicked(object sender, EventArgs e)
        {
            if(wynikLbl.Text.Length<=1)
            {
                wynikLbl.Text = "0";
                isRooted = true;
            }
            else
                wynikLbl.Text = wynikLbl.Text.Remove(wynikLbl.Text.Length - 1);
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void OnCeClicked(object sender, EventArgs e)
        {
            wynikLbl.Text = "0";
            Oldequals.Text = "";
            FinalNum = 0;
            isRooted = true; isMemory=false;
            SemanticScreenReader.Announce(wynikLbl.Text);
        }
        private void OnEqClicked(object sender, EventArgs e)
        {
            if(!isRooted && !isMemory)
            {
                isRooted = true;
                isMemory = true;
                double.TryParse(wynikLbl.Text,out pr);
                NumTwo = pr;
                Oldequals.Text += NumTwo.ToString() + " = ";
                if(CalcType=='+')
                {
                    FinalNum = NumOne + NumTwo;
                    wynikLbl.Text = FinalNum.ToString();
                }
                if (CalcType == '-')
                {
                    FinalNum = NumOne - NumTwo;
                    wynikLbl.Text = FinalNum.ToString();
                }
                if (CalcType == '/')
                {
                    FinalNum = NumOne / NumTwo;
                    wynikLbl.Text = FinalNum.ToString();
                }
                if (CalcType == '*')
                {
                    FinalNum = NumOne * NumTwo;
                    wynikLbl.Text = FinalNum.ToString();
                }
            }
        }
    }
}