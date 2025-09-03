namespace NewApp.Middleware
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Custom logic before the next middleware
            Console.WriteLine("Custom Middleware: Before next middleware");
            Console.WriteLine("" + context.Request.Path);


            await _next(context);

            // Custom logic after the next middleware
            Console.WriteLine("Custom Middleware: After next middleware"); 
        }
    }
}