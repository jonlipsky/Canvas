using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.Extensions.Logging;

namespace Blazor.Extensions.Canvas.Test.Pages
{
    public class IndexComponent : BlazorComponent
    {
        private Canvas2dContext _context;

        protected BECanvasComponent _canvasReference;

        [Inject] private ILogger<IndexComponent> _logger { get; set; }

        protected override void OnAfterRender()
        {
            this._context = this._canvasReference.CreateCanvas2d();
            this._context.FillStyle = "green";

            this._context.FillRect(10, 100, 100, 100);

            this._context.Font = "48px serif";
            this._context.StrokeText("Hello Blazor!!!", 10, 100);
        }
    }
}
