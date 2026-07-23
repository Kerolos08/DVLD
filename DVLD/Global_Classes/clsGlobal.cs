using DVLD_BusinessLayer;
using System;
using System.IO;
using System.Windows.Forms;

namespace DVLD.Global_Classes
{
    internal class clsGlobal
    {
        public static clsUser CurrentUser;

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            try
            {
                //returns the folder where the executable runs
                string CurrentRunnigFolder = System.IO.Directory.GetCurrentDirectory();

                string filePath = Path.Combine(CurrentRunnigFolder, @"\data.txt");

                //Forget me state
                if (Username == "" && File.Exists(filePath))
                {
                    File.Delete(filePath);
                    return true;
                }

                string Text = Username + '|' + Password;

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(Text);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }

        public static bool GetStoredUsernameAndPassword(ref string Username, ref string Password)
        {
            try
            {
                string CurrentRunnigFolder = System.IO.Directory.GetCurrentDirectory();

                string filePath = Path.Combine(CurrentRunnigFolder, @"\data.txt");

                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] Result = line.Split('|');
                            Username = Result[0];
                            Password = Result[1];
                        }
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }
    }
}
