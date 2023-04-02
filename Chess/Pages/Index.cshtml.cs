using Chess.Hubs;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Chess.Pages
{
    public class IndexModel : PageModel
    {
        private GameHub hub;

        public IndexModel(GameHub hub)
        {
            this.hub = hub;
        }
    }
}
