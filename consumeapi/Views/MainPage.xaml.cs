
using System.Net.Http.Json;

using System.Text.Json;

using consumeapi.Models;


namespace consumeapi.Views
{
    public partial class MainPage : ContentPage
    
    
    {
        // private int _count = 0;
        private readonly HttpClient _client;
        
        public MainPage()
        {
            _client = new HttpClient();
            
            
            InitializeComponent();
            
        }

        private async void GetFact_OnPressed(object? sender, EventArgs e)
        {

            var response = await _client.GetFromJsonAsync("https://catfact.ninja/fact", typeof(CatFact));

            if (response is CatFact catFact)
            {
                cfact.Text = catFact.fact;
            }
            
        }
    }
    // public class TodoItem
    // {
    //     public string fact { get; set; }
    //     public string length { get; set; }
    // }
    
    // public class RestService
    // {
    //     HttpClient _client;
    //     JsonSerializerOptions _serializerOptions;
    //
    //     public List<catfact> Items { get; private set; }
    //
    //     public RestService()
    //     {
    //         _client = new HttpClient();
    //         _serializerOptions = new JsonSerializerOptions
    //         {
    //             PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    //             WriteIndented = true
    //         };
    //     }
    //     
    // }
    
    
    
}