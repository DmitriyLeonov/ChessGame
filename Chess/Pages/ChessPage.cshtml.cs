using Chess.Hubs;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Chess.Pages
{
    public class ChessPageModel : PageModel
    {
        private GameHub hub;

        public ChessPageModel(GameHub hub)
        {
            this.hub = hub;
        }
    }
}