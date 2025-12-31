namespace Day12_Basic_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.MapControllerRoute(
                name:"default",
                pattern:"{Controller=Home}/{action=Index}/{id?}"
                );
            app.MapControllerRoute(
                name: "demo",
                pattern: "{Controller=demo}/{action=demo}/{nm?}"
                );

            app.Run();
        }
    }
}
