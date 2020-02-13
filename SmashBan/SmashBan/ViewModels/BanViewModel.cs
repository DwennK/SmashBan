using System;

using SmashBan.Models;

namespace SmashBan.ViewModels
{
    public class BanViewModel : BaseViewModel
    {
        public Stage stage { get; set; }
        public BanViewModel(Stage stage = null)
        {
            Title = "Ban";
            this.stage = stage;
        }
    }
}
