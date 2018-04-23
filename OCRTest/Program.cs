using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using tessnet2;

namespace OCRTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var image = new Bitmap(@"C:\OCRTest\5.bmp");
                var ocr = new Tesseract();
                //ocr.SetVariable("tessedit_char_whitelist", "0123456789"); // If digit only 
                //@"C:\OCRTest\tessdata" contains the language package, without this the method crash and app breaks 
                ocr.Init(@"C:\OCRTest\tessdata", "eng", false);
                var result = ocr.DoOCR(image, Rectangle.Empty);
                foreach (Word word in result)
                    Console.WriteLine("{0} : {1}", word.Confidence, word.Text);

                Console.ReadLine();
            }
            catch (Exception exception)
            {

            }
        }
    }
}
