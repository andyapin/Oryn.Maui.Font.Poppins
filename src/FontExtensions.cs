namespace Plugin.Toolkit.Fonts.Poppins
{
    public static class FontExtensions
    {
        /// <summary>
        /// Add font to global. using: FontFamily="Regular" *(Italic, Medium, SemiBold, Bold, etc..)
        /// </summary>
        public static IFontCollection AddPoppinsFonts(this IFontCollection fonts)
        {
            var thisAssembly = typeof(FontExtensions).Assembly;
            fonts.AddEmbeddedResourceFont(thisAssembly, "PoppinsRegular.ttf", FontAliases.PoppinsRegular);
            fonts.AddEmbeddedResourceFont(thisAssembly, "PoppinsItalic.ttf", FontAliases.PoppinsItalic);
            fonts.AddEmbeddedResourceFont(thisAssembly, "PoppinsMedium.ttf", FontAliases.PoppinsMedium);
            fonts.AddEmbeddedResourceFont(thisAssembly, "PoppinsMediumItalic.ttf", FontAliases.PoppinsMediumItalic);
            fonts.AddEmbeddedResourceFont(thisAssembly, "PoppinsSemiBold.ttf", FontAliases.PoppinsSemiBold);
            fonts.AddEmbeddedResourceFont(thisAssembly, "PoppinsSemiBoldItalic.ttf", FontAliases.PoppinsSemiBoldItalic);
            fonts.AddEmbeddedResourceFont(thisAssembly, "PoppinsBold.ttf", FontAliases.PoppinsBold);
            fonts.AddEmbeddedResourceFont(thisAssembly, "PoppinsBoldItalic.ttf", FontAliases.PoppinsBoldItalic);
            return fonts;
        }

        /// <summary>
        /// Add font to partial. using: FontFamily="PoppinsRegular" *(PoppinsItalic, PoppinsMedium, PoppinsSemiBold, PoppinsBold, etc..)
        /// </summary>
        public static IFontCollection AddPoppinsFontsPartial(this IFontCollection fonts)
        {
            var thisAssembly = typeof(FontExtensions).Assembly;
            fonts.AddEmbeddedResourceFont(thisAssembly, "PoppinsRegular.ttf", FontAliases.Name + FontAliases.PoppinsRegular);
            fonts.AddEmbeddedResourceFont(thisAssembly, "PoppinsItalic.ttf", FontAliases.Name + FontAliases.PoppinsItalic);
            fonts.AddEmbeddedResourceFont(thisAssembly, "PoppinsMedium.ttf", FontAliases.Name + FontAliases.PoppinsMedium);
            fonts.AddEmbeddedResourceFont(thisAssembly, "PoppinsMediumItalic.ttf", FontAliases.Name + FontAliases.PoppinsMediumItalic);
            fonts.AddEmbeddedResourceFont(thisAssembly, "PoppinsSemiBold.ttf", FontAliases.Name + FontAliases.PoppinsSemiBold);
            fonts.AddEmbeddedResourceFont(thisAssembly, "PoppinsSemiBoldItalic.ttf", FontAliases.Name + FontAliases.PoppinsSemiBoldItalic);
            fonts.AddEmbeddedResourceFont(thisAssembly, "PoppinsBold.ttf", FontAliases.Name + FontAliases.PoppinsBold);
            fonts.AddEmbeddedResourceFont(thisAssembly, "PoppinsBoldItalic.ttf", FontAliases.Name + FontAliases.PoppinsBoldItalic);
            return fonts;
        }
    }
}
