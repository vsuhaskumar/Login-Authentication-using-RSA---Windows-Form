using System;
using System.Drawing;
using System.Windows.Forms;

namespace Suhas
{
    public partial class Form1 : Form
    {
        int uflag;
        int u_num;
        int u_cap;
        int pflag;
        int p_cap;
        int p_len;
        int p_spl;
        int p_num;
        
        public Form1()
        {
            InitializeComponent();
            uflag = 0;//Invalid
            u_num = 0;//invalid
            u_cap = 0;//invalid
            pflag = 0; //Invalid
            p_cap = 0;//invalid
            p_len = 0;//invalid
            p_spl = 0;//invalid
            p_num = 0;//invalid
        }

        void setUFlag()
        {
            String uname = UserName.Text;
            char[] un = uname.ToCharArray();
           if (uname.Length < 5)
                uflag = 0;
          // for alphabet ( upper only )
            for (int i = 0; i < uname.Length; i++)
            {
                if ((un[i] >= 65 && un[i] <= 90))
                {
                    u_cap = 1;
                    break;
                }
                else
                    u_cap = 0;

            }
            // for number
            for(int i = 0; i < uname.Length ;i++ )
            {
                if (un[i] >= 48 && un[i] <= 57)
                {
                    u_num = 1;
                    break;
                }
                else
                    u_num = 0;
            }
            
            // if uname has both number and capital letter and length >=5 
            if (uname.Length >= 5 && u_cap == 1 && u_num == 1)
                    uflag = 1;
                else
                    uflag = 0;
            
        }

        void setPFlag()
        {
            String passw = Password.Text;
            char[] pn = passw.ToCharArray();
            if (pn.Length < 8)
                p_len = 0;
            else
                p_len = 1;

            //character is alphabet
            for (int i = 0; i < passw.Length; i++)
            {
                if (pn[i] >= 65 && pn[i] <= 90)
                {
                    p_cap = 1;
                    break;
                }
                else
                    p_cap = 0;
            }

            for (int i = 0; i < passw.Length; i++)
            {
                // character is not an alphabet(upper and lower case) or a number
                if(!(pn[i] >=65 && pn[i] <= 90) && !(pn[i] >= 97 && pn[i] <= 122 ) && !(pn[i] >= 48 && pn[i] <= 57))
                {
                    p_spl = 1;
                    break;
                }
                else
                    p_spl = 0;
            }
        //character is number
            for (int i = 0; i < passw.Length; i++)
            {
                if (pn[i] >= 48 && pn[i] <= 57)
                {
                    p_num = 1;
                    break;
                }
                else
                    p_num = 0;
            }

            if ((p_spl == 1) && (p_len == 1) && (p_cap == 1) && (p_num ==1))
                pflag = 1;
            else
                pflag = 0;

            
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            setUFlag();
            
            if (uflag == 0)
            {
                UValid.Text = "Invalid!!!";
                UValid.ForeColor = Color.Red;
            }
            else
            {
                UValid.Text = "Valid!!!";
                UValid.ForeColor = Color.Green;
            }

            
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            setPFlag();

            if (pflag == 0)
            {
                PValid.Text = "Invalid!!!";
                PValid.ForeColor = Color.Red;
            }
            else
            {
                PValid.Text = "Valid!!!";
                PValid.ForeColor = Color.Green;
            }
        }
        int power(int m, int exp, int mod)
        {
            int res = 1;
            for (int i = 0; i < exp; i++)
                res = (res*m)%mod;
            return res;
        }
        String RSA(String text)
        {
            char[] message = text.ToCharArray();
            int e, n, phi, p = 19, q = 23;
            n = p * q;
            phi = (p - 1) * (q - 1);
            e = 13;
            n = 61;
            int[] cipher = new int[text.Length];
            for (int i = 0; i < text.Length; i++)
                cipher[i] = power(message[i], e, n);
            String res="";
            for (int i = 0; i < cipher.Length; i++)
                res += cipher[i].ToString();
            return res;
                
        }

        private void HelpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(" 1. User-name must be minimum 5 characters and have at least 1 capital letter and 1 number . \n 2.Password must be minimum 8 characters and have at least 1 Capital Letter , 1 Special character and 1 number.");
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            String cipher_uname = RSA(UserName.Text);
            String cipher_passw = RSA(Password.Text);
            MessageBox.Show("Encrypted UserName : " + cipher_uname + "\nEncrypted Password : " + cipher_passw);

        }

        
    }
}
