using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using Microsoft.Extensions.Logging;
//using Microsoft.Maui.EssentialsCompat;
//using Microsoft.Maui.Essentials; //Microsoft.Maui.EssentialsCompat
using Microsoft.Maui.Devices;
using System.Text;
using System.Net.Http;
using System.Text.Json;
namespace MauiApp1.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _currentDateTime;

        public string CurrentDateTime
        { 
            get => _currentDateTime;
            set
            {
                _currentDateTime = value;
                OnPropertyChanged();
            }
        }
        //private bool _isVisible;
        //public bool IsVisible
        //{
        //    get { return _isVisible; }
        //    set
        //    {
        //        if (_isVisible != value)
        //        {
        //            _isVisible = value;
        //            OnPropertyChanged(nameof(IsVisible));
        //        }
        //    }
        //}
        public ICommand UpdateTimeCommand { get; }
        //public ICommand LoadDataCommand { get; private set; }

        public MainViewModel()
        {
            UpdateTimeCommand = new Command(UpdateTime);
            CurrentDateTime = DateTime.Now.ToString("F");
            //LoadDataCommand = new Command(ExecuteLoadDataCommand);
        }
        private void ExecuteLoadDataCommand()
        {
            // Код для завантаження даних
        }
        private void UpdateTime()
        {
            CurrentDateTime = DateTime.Now.ToString("F");
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //public string DeviceInfo
        //{ 
        //    get
        //    { 
        //        var deviceInfo = new StringBuilder()

        //            .AppendLine($"Model: {DeviceInfo.Model}")

        //            .AppendLine($"Manufacturer: {DeviceInfo.Manufacturer}")

        //            .AppendLine($" Platform: {DeviceInfo.Platform}")

        //            .AppendLine($"OS Version: {DeviceInfo.VersionString}");

        //        return deviceInfo.ToString();

        //    }

        //}
        


        private async Task FetchDataFromApiAsync()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/todos/1");

            if (response.IsSuccessStatusCode)
            {

                var json = await response.Content.ReadAsStringAsync();
                var todoltem = JsonSerializer.Deserialize<TodoItem>(json);
                // Process the todoltem as needed
            }
        }

public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

