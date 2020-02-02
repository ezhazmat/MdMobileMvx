using System;

using MdMobileMvx.Core.Models;
using MdMobileMvx.Core.ViewModels;

namespace MdMobileMvx.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
