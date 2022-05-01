using System;

namespace OpenClosed
{
    public class Label : ControlBase, IControlWeb
    {
        private readonly string _text;
        private readonly string _name;
        private readonly int _size;

        public Label(string text, string name, int size) 
        {
            _text = text;
            _name = name;
            _size = size;
        }

        public string GetProperties()
        {
            return $"<h{_size} id='{_id}' name='{_name}'>{_text}</h{_size}> ";
        }
    }
}
