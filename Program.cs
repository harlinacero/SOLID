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

    interface IPaintWeb
    {
        public ControlBase ControlWeb();
    }

    public class PaintWeb : IPaintWeb
    {
        public ControlBase ControlWeb()
        {
            return new Label("url", "200", 300);
        }
    }


    interface IControlWeb
    {
        public string GetProperties();
    }

    public abstract class ControlBase
    {
        protected readonly string _id;

        public ControlBase(string id)
        {
            _id = id;
        }
    }
 
    public class Image : ControlBase, IControlWeb
    {
        private readonly string _url;
        private readonly string _witdh;
        private readonly string _height;

        public Image(string url, string witdh, string height):base(new Guid().ToString())
        {
            _url = url;
            _witdh = witdh;
            _height = height;
        }
        public string GetProperties()
        {
            return $"<img id='{_id}' src='{_url}' widht='{_witdh}' height='{_height}'/>";
        }
    }

    public class Label : ControlBase, IControlWeb
    {
        private readonly string _text;
        private readonly string _name;
        private readonly int _size;

        public Label(string text, string name, int size):base(new Guid().ToString())
        {
            _text = text;
            _name = name;
            _size = size;
        }

        public string GetProperties()
        {
            return $"<h{_size} id='{_id}'>{_text}</h{_size}> ";
        }
    }

    public class Banner : ControlBase,IControlWeb
    {
        private readonly IEnumerable<Image> _images;
        private readonly int _transition;
        
        public Banner(IEnumerable<Image> images, int transition):base(new Guid().ToString())
        {
            _images = images;
            _transition = transition;
        }

        public string GetProperties()
        {
            string banner = null;
            foreach (var image in _images)
            {
                banner += $"\n{image.GetProperties()}";
            }
            return $"<div id='{_id}' class='banner' transition='{_transition}'>\n{banner}</div>";
        }
    }


}
