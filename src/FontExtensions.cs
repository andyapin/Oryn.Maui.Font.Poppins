namespace Plugin.Toolkit.Fonts.Poppins
{
    /// <summary>
    /// Provides extension methods for adding Poppins fonts to an IFontCollection.
    /// </summary>
    public static class FontExtensions
    {
        /// <summary>
        /// Add font to global. using: FontFamily="Regular" *(Italic, Medium, SemiBold, Bold, etc..)
        /// </summary>
        /// <param name="fonts">The font collection to add fonts to.</param>
        /// <returns>The updated font collection.</returns>
        public static IFontCollection AddPoppinsFonts(this IFontCollection fonts)
        {
            fonts.AddFont($"{nameof(FontAliases.PoppinsRegular)}.ttf", FontAliases.PoppinsRegular);
            fonts.AddFont($"{nameof(FontAliases.PoppinsItalic)}.ttf", FontAliases.PoppinsItalic);
            fonts.AddFont($"{nameof(FontAliases.PoppinsMedium)}.ttf", FontAliases.PoppinsMedium);
            fonts.AddFont($"{nameof(FontAliases.PoppinsMediumItalic)}.ttf", FontAliases.PoppinsMediumItalic);
            fonts.AddFont($"{nameof(FontAliases.PoppinsSemiBold)}.ttf", FontAliases.PoppinsSemiBold);
            fonts.AddFont($"{nameof(FontAliases.PoppinsSemiBoldItalic)}.ttf", FontAliases.PoppinsSemiBoldItalic);
            fonts.AddFont($"{nameof(FontAliases.PoppinsBold)}.ttf", FontAliases.PoppinsBold);
            fonts.AddFont($"{nameof(FontAliases.PoppinsBoldItalic)}.ttf", FontAliases.PoppinsBoldItalic);
            return fonts;
        }

        /// <summary>
        /// Add font to partial. using: FontFamily="PoppinsRegular" *(PoppinsItalic, PoppinsMedium, PoppinsSemiBold, PoppinsBold, etc..)
        /// </summary>
        /// <param name="fonts">The font collection to add fonts to.</param>
        /// <returns>The updated font collection.</returns>
        public static IFontCollection AddPoppinsFontsPartial(this IFontCollection fonts)
        {
            fonts.AddFont($"{nameof(FontAliases.PoppinsRegular)}.ttf", nameof(FontAliases.PoppinsRegular));
            fonts.AddFont($"{nameof(FontAliases.PoppinsItalic)}.ttf", nameof(FontAliases.PoppinsItalic));
            fonts.AddFont($"{nameof(FontAliases.PoppinsMedium)}.ttf", nameof(FontAliases.PoppinsMedium));
            fonts.AddFont($"{nameof(FontAliases.PoppinsMediumItalic)}.ttf", nameof(FontAliases.PoppinsMediumItalic));
            fonts.AddFont($"{nameof(FontAliases.PoppinsSemiBold)}.ttf", nameof(FontAliases.PoppinsSemiBold));
            fonts.AddFont($"{nameof(FontAliases.PoppinsSemiBoldItalic)}.ttf", nameof(FontAliases.PoppinsSemiBoldItalic));
            fonts.AddFont($"{nameof(FontAliases.PoppinsBold)}.ttf", nameof(FontAliases.PoppinsBold));
            fonts.AddFont($"{nameof(FontAliases.PoppinsBoldItalic)}.ttf", nameof(FontAliases.PoppinsBoldItalic));
            return fonts;
        }
    }
}
