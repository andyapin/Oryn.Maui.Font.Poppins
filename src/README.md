
# Plugin.Toolkit.Fonts.Poppins

**Effortlessly integrate the Poppins font family into your .NET MAUI applications.** 

Poppins, a popular geometric sans-serif typeface, offers a clean and modern aesthetic, supporting a wide range of languages.

This plugin simplifies the process of including the Poppins font family in your .NET MAUI apps, eliminating the need for manual font embedding and registration. It provides pre-configured font resources that can be easily accessed and applied to your UI elements.

## Key Features

*   Easy integration with .NET MAUI projects.
*   Includes various weights and styles of the Poppins font (e.g., Regular, Bold, Italic, etc.).
*   Optimized for performance in mobile and desktop environments.
*   Cross-platform compatibility (iOS, Android, Windows, macOS).
*   Example project demonstrating usage.

## Installation

You can install the plugin via NuGet:

```bash
Install-Package Plugin.Toolkit.Fonts.Poppins
```

## Usage

1.  **Register the font:**

    In your `MauiProgram.cs` file:

    ```csharp
    using Plugin.Toolkit.Fonts.Poppins;

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
	                fonts.AddPoppinsFonts(); // <-- add this
                });

            return builder.Build();
        }
    }
    ```

2.  **Use the font in XAML:**

    ```xml
    <Label Text="Hello Poppins!" FontFamily="Regular" />
    <Label Text="This is Bold Poppins!" FontFamily="Bold" />
    ```

    Or with *Style*:

    ```xml
    <Style TargetType="Label" x:Key="PoppinsLabelStyle">
        <Setter Property="FontFamily" Value="SemiBold"/>
    </Style>

    <Label Text="Hello Poppins with style!" Style="{StaticResource PoppinsLabelStyle}"/>
    ```

## Example Project

The repository includes a sample MAUI project demonstrating the usage of the plugin. You can find it in the `samples` directory.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request.
