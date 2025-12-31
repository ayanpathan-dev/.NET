namespace Day11_ModelAndView1stDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.MapDefaultControllerRoute();
            app.Run();
        }
    }
}
