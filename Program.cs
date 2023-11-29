using Microsoft.Extensions.Configuration;

namespace pr2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            builder.Configuration.AddXmlFile("Apple.xml");
            builder.Configuration.AddJsonFile("Microsoft.json");
            builder.Configuration.AddIniFile("Google.ini");

            Company apple = new Company();
            IConfigurationSection XMLSectionData = app.Configuration.GetSection("apple");
            XMLSectionData.Bind(apple);

            Company microsoft = new Company();
            IConfigurationSection JSONsectionData = app.Configuration.GetSection("microsoft");
            JSONsectionData.Bind(microsoft);

            Company google = new Company();
            IConfigurationSection INIsectionData = app.Configuration.GetSection("google");
            INIsectionData.Bind(google);

            // app.Map("/", () => $"{Math.Max(apple.Employees, Math.Max(microsoft.Employees, google.Employees))}");
            app.Map("/", () => apple.ToString() + microsoft.ToString() + google.ToString());

            app.Run();
        }
    }
}