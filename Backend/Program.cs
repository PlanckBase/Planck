internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Environment.IsDevelopment();
        var app = builder.Build();

        app.UseDefaultFiles();
        app.UseStaticFiles();
        app.Environment.IsDevelopment();

        app.Run();
    }
}