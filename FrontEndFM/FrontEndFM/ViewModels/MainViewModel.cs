using FrontEndFM.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FrontEndFM.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public List<int> Items { get; set; } = new List<int>() { 0, 1, 2 };

        private List<MenusHelper> menuItems;
        public List<MenusHelper> MenuItems
        {
            get { return menuItems; }
            set 
            {
                menuItems = value;
                OnPropertyChanged();
            }
        }

        private int selectedNoticeIndex;

        public int SelectedNoticeIndex
        {
            get { return selectedNoticeIndex; }
            set 
            {
                selectedNoticeIndex = value;
                OnPropertyChanged();
            }
        }





        public MenusHelper MenusHelperObj { get; set; }
        public ICommand ChangeMenuCommand { get; set; }
        public ICommand CreateEmailCommand { get; set; }
        public ICommand PrevNoticeCommand { get; set; }
        public ICommand NextNoticeCommand { get; set; }
        public MainViewModel()
        {
            createmenus();
            ChangeMenuCommand = new Command<MenusHelper>(ChangeMenu);
            CreateEmailCommand = new Command(async () => await CreateEmail());
            NextNoticeCommand = new Command(NextNotice);
            PrevNoticeCommand = new Command(PrevNotice);
            initializevars();
        }
        public void NextNotice()
        {
            switch (SelectedNoticeIndex)
            {
                case 0:
                    SelectedNoticeIndex = SelectedNoticeIndex + 1;
                    changecolormenuitems(SelectedNoticeIndex);
                    return;
                case 1:
                    SelectedNoticeIndex = SelectedNoticeIndex + 1;
                    changecolormenuitems(SelectedNoticeIndex);
                    return;
                case 2:
                    SelectedNoticeIndex = SelectedNoticeIndex + 1;
                    changecolormenuitems(SelectedNoticeIndex);
                    return;
                case 3:
                    SelectedNoticeIndex = 0;
                    changecolormenuitems(SelectedNoticeIndex);
                    return;
            }
        }
        private void changecolormenuitems(int item)
        {
            foreach(var ite in MenuItems)
            {
                if(ite.id == item)
                {
                    ite.isselected = true;
                    ite.Color = Color.Black;
                }
                else
                {
                    ite.isselected = false;
                    ite.Color = Color.FromRgba(0, 0, 0, 0.45);
                }
            }
        }
        public void PrevNotice()
        {
            switch (SelectedNoticeIndex)
            {
                case 0:
                    SelectedNoticeIndex = 3;
                    changecolormenuitems(SelectedNoticeIndex);
                    return;
                case 1:
                    SelectedNoticeIndex = SelectedNoticeIndex - 1;
                    changecolormenuitems(SelectedNoticeIndex);
                    return;
                case 2:
                    SelectedNoticeIndex = SelectedNoticeIndex - 1;
                    changecolormenuitems(SelectedNoticeIndex);
                    return;
                case 3:
                    SelectedNoticeIndex = SelectedNoticeIndex - 1;
                    changecolormenuitems(SelectedNoticeIndex);
                    return;
            }
        }
        public async Task CreateEmail()
        {
            await Xamarin.Essentials.Email.ComposeAsync(
                "I want a quote", 
                "I need you to build an application");
        }
        private void ChangeMenu(MenusHelper item)
        {
            SelectedNoticeIndex = item.id;
            
            foreach (var notice in MenuItems)
            {
                if(notice.id == item.id)
                {
                    notice.isselected = true;
                    notice.Color = Color.Black;
                }
                else
                {
                    notice.isselected = false;
                    notice.Color = Color.FromRgba(0, 0, 0, 0.45);

                }
            }
        }

   
        private void initializevars()
        {
            SelectedNoticeIndex = 0;
        }

        private void createmenus()
        {
            MenusHelperObj = new MenusHelper();
            MenuItems = MenusHelperObj.creation();
        }
    }
}
