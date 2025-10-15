using Microsoft.Extensions.Logging;
using Oryn.Maui.Font.Poppins;

namespace sample
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddPoppinsFonts(); // <-- add this if using this font to global.
                                             // using: FontFamily="Regular" (Italic, Medium, SemiBold, Bold, etc..)
                    // fonts.AddPoppinsFontsPartial(); // <-- add this if using this font as partial.
                    // using: FontFamily="PoppinsRegular" (PoppinsItalic, PoppinsMedium, PoppinsSemiBold, PoppinsBold, etc..)
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
