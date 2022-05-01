using OpenClosed;
using System;
using System.Collections.Generic;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IControlWeb> list = new ();
            List<Image> images = new ();
            var image = new Image("http", "300", "400");
            var imag2 = new Image("http2", "100", "500");
            var imag3 = new Image("http3", "200", "600");
            var text = new Label("hola", "img", 6);
            

            images.AddRange(new List<Image>() { image, imag2, imag3 });
            var banner = new Banner(images, 20);

            list.AddRange(new List<IControlWeb>() { image, text, banner});
            
            foreach (var control in list)
            {
                Console.WriteLine(control.GetProperties());
            }

        }
    }

  


}
