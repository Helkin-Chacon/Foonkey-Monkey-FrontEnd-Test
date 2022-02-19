using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FrontEndFM.Helpers
{
    public class MenusHelper : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int id { get; set; }
        public string tittle { get; set; }

        private bool isSaved;

        public bool isselected
        {
            get
            {
                return isSaved;
            }
            set
            {
                if (value != isSaved)
                {
                    isSaved = value;
                    OnPropertyChanged();
                }
            }
        }

        private Color color;

        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                if (value != color)
                {
                    color = value;
                    OnPropertyChanged();
                }
            }
        }


        public ICommand ChangeMenuCommand { get; set; }
        public List<MenusHelper> creation()
        {
            MenusHelper menus0 = new MenusHelper();
            MenusHelper menus1 = new MenusHelper();
            MenusHelper menus2 = new MenusHelper();
            MenusHelper menus3 = new MenusHelper();
            List<MenusHelper> ret = new List<MenusHelper>();

            menus0.id = 0;
            menus0.isselected = true;
            menus0.tittle = "Pfizer";
            menus0.Color = Color.Black;
            ret.Add(menus0);

            menus1.id = 1;
            menus1.isselected = false;
            menus1.tittle = "Takeda";
            menus1.Color = Color.FromRgba(0, 0, 0, 0.45);
            ret.Add(menus1);

            menus2.id = 2;
            menus2.isselected = false;
            menus2.tittle = "Boston Scientific Group";
            menus2.Color = Color.FromRgba(0, 0, 0, 0.45);


            ret.Add(menus2);

            menus3.id = 3;
            menus3.isselected = false;
            menus3.tittle = "BSJI";
            menus3.Color = Color.FromRgba(0, 0, 0, 0.45);


            ret.Add(menus3);


            return ret;
        }
    }
}
