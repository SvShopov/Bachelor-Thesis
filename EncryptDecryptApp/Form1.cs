using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EncryptDecryptApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mode2Opt1.Enabled = false;
            Mode2Opt2.Enabled = false;
            PFileBox.Enabled = false;
            KFileBox.Enabled = false;
            RFileBox.Enabled = false;
            AlphaBox2.Enabled = false;
            StepBox.Enabled = false;

            Mode1Opt1.Checked = true;
            Button1.Enabled = false;            
            
        }



        private void Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button1.Enabled = true;
            if (Combo.SelectedIndex == 3 || Combo.SelectedIndex == 4 || Combo.SelectedIndex == 5 || Combo.SelectedIndex == 2)
            {
                if (KeyBox.Text == "")
                {
                    Button1.Enabled = false;
                }
            }

            if (Combo.SelectedIndex == 1)
            {
                Mode2Opt1.Enabled = true;
                Mode2Opt2.Enabled = true;
                Mode1Opt1.Enabled = false;
                Mode1Opt2.Enabled = false;
                KeyBox.Enabled = false;
                AlphaBox2.Enabled = true;
                StepBox.Enabled = false;
                KFileCheck.Enabled = false;
            }
            else if (Combo.SelectedIndex == 0)
            {
                Mode2Opt1.Enabled = false;
                Mode2Opt2.Enabled = false;
                Mode1Opt1.Enabled = true;
                Mode1Opt2.Enabled = true;
                KeyBox.Enabled = false;
                AlphaBox2.Enabled = false;
                StepBox.Enabled = true;
                KFileCheck.Enabled = false;
            }
            else
            {
                Mode2Opt1.Enabled = false;
                Mode2Opt2.Enabled = false;
                Mode1Opt1.Enabled = true;
                Mode1Opt2.Enabled = true;
                KeyBox.Enabled = true;
                AlphaBox2.Enabled = false;
                StepBox.Enabled = false;
                KFileCheck.Enabled = true;
            }
        }


        private void PFileCheck_CheckedChanged(object sender, EventArgs e)
        {
            PlainBox.Enabled = (PFileCheck.CheckState != CheckState.Checked);
            PFileBox.Enabled = (PFileCheck.CheckState == CheckState.Checked);
        }

        private void KFileCheck_CheckedChanged(object sender, EventArgs e)
        {
            KeyBox.Enabled = (KFileCheck.CheckState != CheckState.Checked);
            KFileBox.Enabled = (KFileCheck.CheckState == CheckState.Checked);
        }

        private void RFileCheck_CheckedChanged(object sender, EventArgs e)
        {
            RFileBox.Enabled = (RFileCheck.CheckState == CheckState.Checked);
        }

       

        private void Button1_Click(object sender, EventArgs e)
        {
            string plaintext = "";
            if (PFileCheck.Checked == true)
            {
                plaintext = ReadFile(PFileBox.Text).ToUpper();
            }
            else
            {
                plaintext = PlainBox.Text.ToUpper();
            }
            char[] plain = plaintext.ToCharArray();
            
            string alphabet = ReadFile(AlphaBox.Text);
            //try
            //{
            //    char[] alpha1 = alphabet.ToCharArray();
            //}
            //catch (FormatException ex)
            //{
            //    MessageBox.Show("Wrong alphabet format!");
            //    throw;
            //}
            char[] alpha = alphabet.ToCharArray();
                      


            int selection = Combo.SelectedIndex + 1;
            if (selection == 1)
            {
                if (Mode1Opt1.Checked == true)
                {
                    ResultBox.Text = Encrypt1(plain, alpha, Decimal.ToInt32(StepBox.Value));
                }
                else if (Mode1Opt2.Checked == true)
                {
                    ResultBox.Text = Decrypt1(plain, alpha, Decimal.ToInt32(StepBox.Value));
                }
            }
            else if (selection == 2)
            {
                if (Mode2Opt1.Checked == true)
                {
                    try
                    {
                        char[] alpha2 = ReadFile(AlphaBox2.Text).ToCharArray();
                        ResultBox.Text = Code2(plain, alpha, alpha2);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Грешен формат на изходната азбука!", "Wrong alphabet format");
                        //throw;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Изходната азбука не съществува или не е с размера на входната!", "Alphabet missing or wrong length");
                    }

                }
                else if (Mode2Opt2.Checked == true)
                {
                    string s = ReadFile(AlphaBox2.Text);
                    try
                    {
                        int[] alpha2 = s.Split(' ').Select(int.Parse).ToArray();
                        ResultBox.Text = CodeNum2(plain, alpha, alpha2);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Грешен формат на изходната азбука!", "Wrong alphabet format");
                        //throw;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Изходната азбука не съществува или не е с размера на входната!", "Alphabet missing or wrong length");
                    }
                    
                }
            }
            else if (selection == 3)
            {
                string key = "";
                if (KFileCheck.Checked == true)
                {
                    key = ReadFile(KFileBox.Text).ToUpper();
                }
                else
                {
                    key = KeyBox.Text.ToUpper();
                }

                if (Mode1Opt1.Checked == true)
                {
                    ResultBox.Text = Encrypt3(plaintext,key,alpha);
                }
                else if (Mode1Opt2.Checked == true)
                {
                    ResultBox.Text = Decrypt3(plaintext,key,alpha);
                }
            }
            else if (selection == 4)
            {
                string key = "";
                if (KFileCheck.Checked == true)
                {
                    key = ReadFile(KFileBox.Text).ToUpper();
                }
                else
                {
                    key = KeyBox.Text.ToUpper();
                }

                if (Mode1Opt1.Checked == true)
                {
                    ResultBox.Text = Encrypt4(plaintext, alpha, key); ;
                }
                else if (Mode1Opt2.Checked == true)
                {
                    ResultBox.Text = Decrypt4(plaintext, alpha, key); ;
                }
            }
            else if (selection == 5)
            {
                string key = "";
                if (KFileCheck.Checked == true)
                {
                    key = ReadFile(KFileBox.Text).ToUpper();
                }
                else
                {
                    key = KeyBox.Text.ToUpper();
                }

                int blocks1 = plaintext.Length / key.Length;
                if (plaintext.Length % key.Length != 0)
                {
                    blocks1++;
                }

                char[] fixedplain = FixPlain(plaintext.ToCharArray(), key.ToCharArray(), blocks1);

                if (Mode1Opt1.Checked == true)
                {
                    ResultBox.Text = Encrypt5(key,fixedplain);
                }
                else if (Mode1Opt2.Checked == true)
                {
                    ResultBox.Text = Decrypt5(key,fixedplain);
                }
            }
            else if (selection == 6)
            {
                string key = "";
                if (KFileCheck.Checked == true)
                {
                    key = ReadFile(KFileBox.Text).ToUpper();
                }
                else
                {
                    key = KeyBox.Text.ToUpper();
                }

                int blocks1 = plaintext.Length / key.Length;
                if (plaintext.Length % key.Length != 0)
                {
                    blocks1++;
                }

                char[] fixedplain = FixPlain(plaintext.ToCharArray(), key.ToCharArray(), blocks1);

                if (Mode1Opt1.Checked == true)
                {
                    ResultBox.Text = Encrypt6(key, fixedplain);
                }
                else if (Mode1Opt2.Checked == true)
                {
                    ResultBox.Text = Decrypt6(key, fixedplain);
                }
            }

            if (RFileCheck.Checked == true)
            {
                WriteFile(ResultBox.Text, RFileBox.Text);
            }
        }

        //----------------------------------
        static string ReadFile(string name)
        {
            //string path = "../../../" + name + ".txt";
            string path = name + ".txt";
            string result = "";
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                result = sr.ReadLine().ToUpper();
                sr.Close();
            }

            return result;
        }

        static void WriteFile(string result, string name)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //string path = "../" + name + ".txt";
            string path = desktop + "/" + name + ".txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(result);
            }
        }

        static string Encrypt1(char[] input, char[] alpha, int num)
        {
            List<int> nums = new List<int>();
            for (int j = 0; j < input.Length; j++)
            {
                for (int i = 0; i < alpha.Length; i++)
                {
                    if (input[j] == alpha[i])
                    {
                        int alphanum = i + 1;
                        int newnum = (alphanum + num) % alpha.Length;
                        if (newnum == 0)
                        {
                            nums.Add(alpha.Length);
                        }
                        else
                        {
                            nums.Add(newnum);
                        }
                    }
                }
            }

            string result = "";

            for (int i = 0; i < nums.Count; i++)
            {
                for (int j = 0; j < alpha.Length; j++)
                {
                    if (j == nums[i] - 1)
                    {
                        result += alpha[j];
                    }
                }
            }

            return result;
        }

        static string Decrypt1(char[] input, char[] alpha, int num)
        {
            List<int> nums = new List<int>();
            for (int j = 0; j < input.Length; j++)
            {
                for (int i = 0; i < alpha.Length; i++)
                {
                    if (input[j] == alpha[i])
                    {
                        int alphanum = i + 1;
                        int newnum = (alphanum - num) % alpha.Length;

                        if (newnum <= 0)
                        {
                            nums.Add(newnum + alpha.Length);
                        }
                        else
                        {
                            nums.Add(newnum);
                        }
                    }
                }
            }

            string result = "";

            for (int i = 0; i < nums.Count; i++)
            {
                for (int j = 0; j < alpha.Length; j++)
                {
                    if (j == nums[i] - 1)
                    {
                        result += alpha[j];
                    }
                }
            }

            return result;
        }

        static string Code2(char[] inputt, char[] alpha1, char[] alpha2)
        {
            int position = 0;
            string result = "";
            for (int j = 0; j < inputt.Length; j++)
            {
                for (int i = 0; i < alpha1.Length; i++)
                {
                    if (inputt[j] == alpha1[i])
                    {
                        position = i;

                        result += alpha2[position];
                    }
                }
            }
            return result;
        }

        static string CodeNum2(char[] inputt, char[] alpha1, int[] alpha2)
        {
            int position = 0;
            string result = "";
            for (int j = 0; j < inputt.Length; j++)
            {
                for (int i = 0; i < alpha1.Length; i++)
                {
                    if (inputt[j] == alpha1[i])
                    {
                        position = i;

                        if (j == inputt.Length - 1)
                        {
                            result += alpha2[position];
                        }
                        else
                        {
                            result += alpha2[position];
                            result += '.';
                        }
                    }
                }
            }
            return result;
        }

        static string Encrypt3(string plain, string key, char[] alpha)
        {
            int i;
            string result = "";
            int posM;
            int posK;
            for (i = 0; i < plain.Length; i++)
            {
                posM = ReturnPosition(plain[i], alpha);
                if (posM == -1)
                {
                    return string.Empty;
                }
                if (i < key.Length)
                {
                    posK = ReturnPosition(key[i], alpha);
                }
                else
                {
                    posK = ReturnPosition(key[i % key.Length], alpha);
                }
                result += alpha[(posM + posK + 1) % alpha.Length];
            }
            return result;
        }

        static string Decrypt3(string plain, string key, char[] alpha)
        {
            int i;
            string result = "";
            int posM;
            int posK;
            for (i = 0; i < plain.Length; i++)
            {
                posM = ReturnPosition(plain[i], alpha);
                if (i < key.Length)
                {
                    posK = ReturnPosition(key[i], alpha);
                }
                else
                {
                    posK = ReturnPosition(key[i % key.Length], alpha);
                }
                int d = (posM - posK - 1);
                if (d >= 0)
                    result += alpha[d];
                else
                    result += alpha[d + alpha.Length];
            }
            return result;
        }

        static int ReturnPosition(char c, char[] alpha)
        {
            for (int i = 0; i < alpha.Length; i++)
            {
                if (c == alpha[i])
                {
                    return i;
                }
            }
            return -1;
        }

        static string Encrypt4(string input, char[] alpha, string key)
        {
            char[] inputt = input.ToCharArray();
            int j = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (alpha.Contains(input[i]))
                    inputt[i] = alpha[(Array.IndexOf(alpha, input[i]) + Array.IndexOf(alpha, key[j])) % alpha.Length];
                j = (j + 1) % key.Length;
            }
            string result = new string(inputt);
            return result;
        }

        static string Decrypt4(string input, char[] alpha, string key)
        {
            char[] inputt = input.ToCharArray();
            int j = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (alpha.Contains(input[i]))
                    inputt[i] = input[i] >= key[j] ?
                    (char)(input[i] - key[j] + 'A') : (char)('A' + ('Z' - key[j] + input[i] - 'A') + 1);
                //j = j + 1 == key.Length ? 0 : j + 1; // if j+1 == keylength  j = 0  else j = j+1
                if (j + 1 == key.Length)
                {
                    j = 0;
                }
                else
                {
                    j++;
                }
            }
            string result = new string(inputt);
            return result;
        }

        static char[] FixPlain(char[] inputt, char[] keyy, int blocks)
        {
            int additionalblocks = keyy.Length * blocks - inputt.Length;
            char[] plain = new char[inputt.Length + additionalblocks];

            for (int i = 0; i < inputt.Length; i++)
            {
                plain[i] = inputt[i];
            }
            for (int i = inputt.Length; i < plain.Length; i++)
            {
                plain[i] = '.';
            }

            return plain;
        }

        static int[] KeyLetToNum(string key)
        {
            string keyorder = String.Concat(key.OrderBy(c => c));
            char[] order = keyorder.ToCharArray();
            int[] result = new int[order.Length];

            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < order.Length; j++)
                {
                    if (key[i] == order[j])
                    {
                        result[i] = j + 1;
                    }
                }
            }
            return result;
        }

        static string Encrypt5(string keyy, char[] plain)
        {
            string result = "";
            int[] key = KeyLetToNum(keyy);

            int[] temp = new int[key.Length];
            for (int i = 0; i < key.Length; i++)
            {
                temp[i] = key[i];
            }

            int blocksize = key.Length;

            List<char[]> list = new List<char[]>();

            for (int i = 0; i < plain.Length; i += blocksize)
            {
                char[] part = new char[blocksize];

                Array.Copy(plain, i, part, 0, blocksize);
                list.Add(part);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Array.Sort(key, list[i]);

                for (int j = 0; j < key.Length; j++)
                {
                    key[j] = temp[j];
                }
                string fpart = new string(list[i]);
                result += fpart;
            }

            return result;
        }

        static string Decrypt5(string keyy, char[] res)
        {
            string result = "";
            int[] key = KeyLetToNum(keyy);
            int blocksize = key.Length;

            List<char[]> list = new List<char[]>();

            for (int i = 0; i < res.Length; i += blocksize)
            {
                char[] part = new char[blocksize];

                Array.Copy(res, i, part, 0, blocksize);
                list.Add(part);
            }

            int[] newkey = new int[key.Length];
            for (int j = 0; j < key.Length; j++)
            {
                for (int k = 0; k < key.Length; k++)
                {
                    if (k + 1 == key[j])
                    {
                        newkey[k] = j + 1;
                    }
                }
            }
            int[] temp = new int[newkey.Length];
            for (int i = 0; i < newkey.Length; i++)
            {
                temp[i] = newkey[i];
            }

            for (int i = 0; i < list.Count; i++)
            {
                Array.Sort(newkey, list[i]);

                for (int j = 0; j < key.Length; j++)
                {
                    newkey[j] = temp[j];
                }
                string fpart = new string(list[i]);
                result += fpart;
            }

            return result;
        }

        static string Encrypt6(string keyy, char[] plain)
        {
            string result1 = "";
            int[] key = KeyLetToNum(keyy);

            int[] temp = new int[key.Length];
            for (int i = 0; i < key.Length; i++)
            {
                temp[i] = key[i];
            }

            int blocksize = key.Length;

            List<char[]> list = new List<char[]>();

            for (int i = 0; i < plain.Length; i += blocksize)
            {
                char[] part = new char[blocksize];

                Array.Copy(plain, i, part, 0, blocksize);
                list.Add(part);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Array.Sort(key, list[i]);

                for (int j = 0; j < key.Length; j++)
                {
                    key[j] = temp[j];
                }
                string fpart = new string(list[i]);
                result1 += fpart;
            }
            //Console.WriteLine(result1);

            char[] fin = result1.ToCharArray();
            string result2 = "";

            for (int j = 0; j < fin.Length / list.Count; j++)
            {
                for (int i = j; i < fin.Length; i += fin.Length / list.Count)
                {
                    result2 += fin[i];
                }
            }
            return result2;
        }


        static string Decrypt6(string keyy, char[] inputt)
        {
            List<char[]> list = new List<char[]>();
            int[] key = KeyLetToNum(keyy);
            int blocksize = key.Length;
            int num = inputt.Length / blocksize;

            int[] newkey = new int[key.Length];
            for (int j = 0; j < key.Length; j++)
            {
                for (int k = 0; k < key.Length; k++)
                {
                    if (k + 1 == key[j])
                    {
                        newkey[k] = j + 1;
                    }
                }
            }


            int count = 0;
            char[,] field = new char[blocksize, num];
            for (int i = 0; i < blocksize; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    field[i, j] = inputt[count++];
                }
            }

            string work = "";
            for (int j = 0; j < num; j++)
            {
                for (int i = 0; i < blocksize; i++)
                {
                    char[] part = new char[blocksize];
                    part[i] = field[i, j];
                    work += part[i];
                }
            }
            char[] workchar = work.ToCharArray();

            int[] temp = new int[newkey.Length];
            for (int i = 0; i < newkey.Length; i++)
            {
                temp[i] = newkey[i];
            }

            for (int i = 0; i < work.Length; i += blocksize)
            {
                char[] part = new char[blocksize];

                Array.Copy(workchar, i, part, 0, blocksize);
                list.Add(part);
            }

            string result = "";
            for (int i = 0; i < list.Count; i++)
            {
                Array.Sort(newkey, list[i]);

                for (int j = 0; j < newkey.Length; j++)
                {
                    newkey[j] = temp[j];
                }
                string fpart = new string(list[i]);
                result += fpart;
            }
            return result;
        }

        private void Mode1Opt1_CheckedChanged(object sender, EventArgs e)
        {
            if (Mode1Opt1.Checked == true)
            {
                Button1.Text = "Криптиране";
            }
            else if (Mode1Opt2.Checked == true)
            {
                Button1.Text = "Декриптиране";
            }
        }

        private void Mode2Opt1_CheckedChanged(object sender, EventArgs e)
        {
            Button1.Text = "Криптиране";
        }

        private void KeyBox_TextChanged(object sender, EventArgs e)
        {
            Button1.Enabled = true;
        }

        private void KFileBox_TextChanged(object sender, EventArgs e)
        {
            Button1.Enabled = true;
        }
    }
}
