using System;

namespace OpenClosed
{
    /// <summary>
    /// Control tipo imagen
    /// </summary>
    public class Image : ControlBase, IControlWeb
    {
        private readonly string _url;
        private readonly string _witdh;
        private readonly string _height;

        public Image(string url, string witdh, string height)
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
}
