using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
  public partial class Form1 : Form
  {
    private const string capital = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
    private const string lowercase = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
    private const string numbers = "0 1 2 3 4 5 6 7 8 9";
    public const string specialCharacters = "~ ! @ # $ % ^ & * + - /  . , \\ { } [ ] ( ) ; :";    

    public Form1()
    {
      InitializeComponent();
    }

    private void Copy_passwd_Click(object sender, EventArgs e)
    {
      Clipboard.SetText(Text_passwd.Text);      
    }   

    private void New_passwd_Click(object sender, EventArgs e)
    {
      Text_passwd.Text = GeneratePassword(Convert.ToInt32(Passwd_length.Value));
    }

    private string GeneratePassword(int length_passwd)
    {
      StringBuilder passwd_build = new StringBuilder();
      Random random_number = new Random();
      string[] passwd_split = new string[] { };

      if (Capital_letters.Checked)
      {        
        passwd_build.Append(capital);
      }
      if (Lowecase_letters.Checked)
      {       
        passwd_build.Append(lowercase);
      }
      if (Numbers.Checked)
      {        
        passwd_build.Append(numbers);
      }
      if (Special_characters.Checked)
      {        
        passwd_build.Append(specialCharacters);
      }

      passwd_split = passwd_build.ToString().Split(' ');
      passwd_build.Clear();

      for (int i = 0; i < length_passwd; i++)
      {
        passwd_build.Append(passwd_split[random_number.Next(passwd_split.Length)]);          
      }

      return passwd_build.ToString();
    }

  }
}
