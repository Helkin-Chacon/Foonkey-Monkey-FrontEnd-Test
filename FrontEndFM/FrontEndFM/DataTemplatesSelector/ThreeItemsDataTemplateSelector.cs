using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FrontEndFM.DataTemplatesSelector
{
    internal class ThreeItemsDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate cerotemplate { get; set; }
        public DataTemplate unotemplate { get; set; }
        public DataTemplate dostemplate { get; set; }


        public int vamoave { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {

            var index = int.Parse(item.ToString());

            switch (index)
            {
                case 0:
                    return cerotemplate;
                case 1:
                    return unotemplate;
                case 2:
                    return dostemplate;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
