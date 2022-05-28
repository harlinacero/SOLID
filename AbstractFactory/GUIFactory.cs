using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Pruebas.AbstractFactory
{
    public abstract class FormField
    {
        public string dataField;
        public string label;
        public IEnumerable<JObject> properties;

        public FormField(string dataField, string label, IEnumerable<JObject> properties)
        {
            this.dataField = dataField;
            this.label = label;
            this.properties = properties;
        }
    }
    internal interface ITemplate
    {
        object BuildField(FormField formField);
        object BuildFieldWithData(FormField formField);
    }

    public class SelectBox: FormField, ITemplate
    {
        public SelectBox(string dataField, string label, IEnumerable<JObject> properties) 
            :base(dataField, label, properties)
        {

        }

        public object BuildField(FormField formField)
        {
            var fieldSelect = new List<JObject>();
            foreach (var prop in properties)
            {
                fieldSelect.Add(new JObject(prop));
            }

            return fieldSelect;
        }

        public object BuildFieldWithData(FormField formField)
        {
            var fieldSelect = new List<JObject>();
            foreach (var prop in properties)
            {
                fieldSelect.Add(new JObject(prop));
            }

            return fieldSelect;
        }
    }
}
