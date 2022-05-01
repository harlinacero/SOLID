using System;
using System.Collections.Generic;

namespace OpenClosed
{
    public class Banner : ControlBase, IControlWeb
    {
        private readonly IEnumerable<Image> _images;
        private readonly int _transition;

        public Banner(IEnumerable<Image> images, int transition)
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
