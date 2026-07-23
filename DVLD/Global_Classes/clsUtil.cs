using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Global_Classes
{
    internal class clsUtil
    {
        public static string GenerateGUID()
        {
            return Guid.NewGuid().ToString();
        }

        public static bool CreateDirectoryIfDoesNotExist (string DirPath)
        {
            if(!Directory.Exists(DirPath))
            {
                try
                {
                    Directory.CreateDirectory(DirPath);
                    return true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }
            return true;
        }

        public static string RenameImageWithGUID (string OriginalImagePath)
        {
            string ImageExt = Path.GetExtension(OriginalImagePath);
            return GenerateGUID() + ImageExt;
        }

        public static bool CopyImageToProjectImageDirectory (ref string SourceImage)
        {
            string DestinationDir = @"C:\DVLD_PeopleImages\";

            if (!CreateDirectoryIfDoesNotExist(DestinationDir))
                return false;

            string DestinationFile = Path.Combine(DestinationDir, RenameImageWithGUID(SourceImage));

            try
            {
                File.Copy(SourceImage, DestinationFile, true);
            }
            catch(IOException iox)
            {
                MessageBox.Show(iox.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            SourceImage = DestinationFile;
            return true;
        }
    }
}
