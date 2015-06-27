using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using WMPLib;
namespace Mp3Tags
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowsMediaPlayer wmp = new WindowsMediaPlayer();
            string path = args[0];
            DirectoryInfo home = Directory.CreateDirectory(path);
            path = home.FullName;
        
            FileInfo[] files= home.GetFiles();
            foreach (FileInfo f in files)
            {

               IWMPMedia media= wmp.newMedia(f.FullName);
                string name = media.getItemInfo("Title");
                Console.WriteLine(name);
                f.MoveTo(path+"\\"+name+f.Extension);
                                 
            }           
        }
    }
}
