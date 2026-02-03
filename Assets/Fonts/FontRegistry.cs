using ReLogic.Content;
using ReLogic.Graphics;
using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace NoxusBoss.Assets.Fonts;

public class FontRegistry : ModSystem
{
    public static FontRegistry Instance => ModContent.GetInstance<FontRegistry>();

    public static readonly GameCulture EnglishGameCulture = GameCulture.FromCultureName(GameCulture.CultureName.English);

    public static readonly GameCulture ChineseGameCulture = GameCulture.FromCultureName(GameCulture.CultureName.Chinese);

    public static readonly GameCulture RussianGameCulture = GameCulture.FromCultureName(GameCulture.CultureName.Russian);

    // This font deliberately makes no sense, and does not correspond to a real world language.
    public DynamicSpriteFont DivineLanguageTextText
    {
        get
        {
            if (Main.netMode != NetmodeID.Server)
                return Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/DivineLanguageText", AssetRequestMode.ImmediateLoad).Value;

            return FontAssets.MouseText.Value;
        }
    }

    public DynamicSpriteFont NamelessDeityText
    {
        get
        {
            // Chinese characters are not present for this font.
            if (ChineseGameCulture.IsActive)
                return FontAssets.DeathText.Value;

            if (RussianGameCulture.IsActive)
                return Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/NamelessDeityTextRussian", AssetRequestMode.ImmediateLoad).Value;

            return Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/NamelessDeityText", AssetRequestMode.ImmediateLoad).Value;

        }
    }

    public DynamicSpriteFont AvatarPoemText
    {
        get
        {
            // Chinese characters are not present for this font.
            if (ChineseGameCulture.IsActive)
                return FontAssets.DeathText.Value;

            if (RussianGameCulture.IsActive)
                return Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/AvatarPoemTextRussian", AssetRequestMode.ImmediateLoad).Value;

            return Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/AvatarPoemText", AssetRequestMode.ImmediateLoad).Value;
        }
    }

    public DynamicSpriteFont DraedonText
    {
        get
        {
            // Chinese and Russian characters are not present for this font.
            if (ChineseGameCulture.IsActive || RussianGameCulture.IsActive)
                return FontAssets.DeathText.Value;

            return Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/DraedonText", AssetRequestMode.ImmediateLoad).Value;

        }
    }

    public DynamicSpriteFont SolynText
    {
        get
        {
            // Chinese characters are not present for this font.
            if (ChineseGameCulture.IsActive)
                return FontAssets.DeathText.Value;

            if (RussianGameCulture.IsActive)
                return Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/NamelessDeityTextRussian", AssetRequestMode.ImmediateLoad).Value;

            return Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/SolynText", AssetRequestMode.ImmediateLoad).Value;
        }
    }

    public DynamicSpriteFont SolynTextItalics
    {
        get
        {
            // Chinese characters are not present for this font.
            if (ChineseGameCulture.IsActive)
                return FontAssets.DeathText.Value;

            if (RussianGameCulture.IsActive)
                return Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/SolynTextItalicsRussian", AssetRequestMode.ImmediateLoad).Value;

            return Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/SolynTextItalics", AssetRequestMode.ImmediateLoad).Value;
        }
    }

    public DynamicSpriteFont SolynFightDialogue
    {
        get
        {
            // Chinese characters are not present for this font.
            if (ChineseGameCulture.IsActive)
                return FontAssets.DeathText.Value;

            return Mod.Assets.Request<DynamicSpriteFont>("Assets/Fonts/SolynFightDialogue", AssetRequestMode.ImmediateLoad).Value;

        }
    }
}
