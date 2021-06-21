using App1.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace App1.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        public ItemDetailViewModel()
        {
            Title = "Descrição da Oferta";
        }

        private string itemId;
        private string text;
        private string description;
        private string explanation;
        private bool isStartVisible;
        public string Id { get; set; }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public string Explanation
        {
            get => explanation;
            set => SetProperty(ref explanation, value);
        }

        public bool IsStartVisible
        {
            get => isStartVisible;
            set => SetProperty(ref isStartVisible, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                Description = item.Description;
                Explanation = item.Explanation;
                IsStartVisible = false;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }

        public async void OnButtonClicked(object sender, EventArgs args)
        {
            IsStartVisible = true;
        }
    }
}
