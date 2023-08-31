using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.CommonClasses.ImageTool.Abstract;

namespace WindowsFormsApp.CommonClasses.ImageTool.Concrete
{
    public class ImageAdd : IImageAdd
    {
        void IImageAdd.ImageAdd(string path, PictureBox pbx)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Title = "Urun Resmi Secin";
                fileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string combinedAppPath = Path.Combine(path, Path.GetFileName(fileDialog.FileName));
                    File.Copy(fileDialog.FileName, combinedAppPath,true);
                    pbx.ImageLocation = combinedAppPath;
                    pbx.Image = new Bitmap(fileDialog.FileName);
                }
            }
        }
    }
}
