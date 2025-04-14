using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using TodoStarter.Shared;

namespace TodoStarter.Frontend.Pages
{
    public partial class Home : IComponent
    {
        [Inject]
        private HttpClient Http {get; set;}

        private List<TodoItem>? todos;
        
        protected override async Task OnInitializedAsync()
        {
           todos = await Http.GetFromJsonAsync<List<TodoItem>>("todo");
        }

        // TODO: Erstelle hier Funktionen, die die Endpunkte in der API aufrufen und mit der Api kommunizieren
        protected async Task DeleteItem(int id)
        {
            // TODO
        }
    }
}
