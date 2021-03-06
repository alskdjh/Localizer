using System;
using System.Reflection;
using Localizer.DataModel;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;
using static Localizer.Lang;

namespace Localizer.Helpers
{
    public static class UI
    {
        public static string GetPkgLabelText(IPackage p)
        {
            return _("PackageDisplay", _(p.Enabled ? "PackageEnabled" : "PackageDisabled"), p.Name, p.Version, p.Author);
        }

        public static void ShowInfoMessage(string message, int gotoMenu, UIState state = null, string altButtonText = "", Action altButtonAction = null)
        {
            var infoMsgUI = GetModLoaderUI("infoMessage") ?? throw new Exception("Cannot Find infoMessage field");

            infoMsgUI.Invoke("Show", message, gotoMenu, state, altButtonText, altButtonAction);
        }

        public static object GetModLoaderUI(string uiName)
        {
            return "Terraria.ModLoader.UI.Interface".Type()?.ValueOf(uiName);
        }

        public static void SafeBegin(this SpriteBatch sb)
        {
            try
            {
                sb.Begin();
            }
            catch (InvalidOperationException)
            {
            }
        }
        public static void SafeBegin(this SpriteBatch sb, SamplerState sampler, RasterizerState rasterizer)
        {
            try
            {
                sb.Begin(SpriteSortMode.Immediate, BlendState.NonPremultiplied, sampler, null, rasterizer);
            }
            catch (InvalidOperationException)
            {
            }
        }

        public static void SafeEnd(this SpriteBatch sb)
        {
            try
            {
                sb.End();
            }
            catch (InvalidOperationException)
            {
            }
        }
    }
}
