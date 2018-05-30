using System;
using Umbraco.Core.Models;
using USNStarterKit.USNEntities;
using USNStarterKit.USNBackgroundOptions.Models;

namespace USNStarterKit.USNHelpers
{
    public static class USNViewTemplateHelper
    {
        public static USNTemplateStyleSettings GetTemplateStyleSettings(string backgroundColor = null, string buttonColour = null)
        {
            USNTemplateStyleSettings settings = new USNTemplateStyleSettings();

            if (!String.IsNullOrEmpty(backgroundColor))
            {
                switch (backgroundColor)
                {
                    //if background c1, c1 background + c2 text
                    //redorange - black
                    case "ec6425":
                        settings.BackGroundStyle = "c1-bg";
                        settings.HeadingStyle = "c2-text";
                        settings.TextStyle = "c2-text";
                        break;
                    //if background c2, c2 background + c1 text
                    //black - redorange
                    case "101212":
                        settings.BackGroundStyle = "c2-bg";
                        settings.HeadingStyle = "c1-text";
                        settings.TextStyle = "c1-text";
                        break;
                    //if background c3, c3 background + c4 text
                    //blue - gray
                    case "46bea8":
                        settings.BackGroundStyle = "c3-bg";
                        settings.HeadingStyle = "c4-text";
                        settings.TextStyle = "c4-text";
                        break;
                    //if background c4, c4 background + c3 text
                    //gray - blue
                    case "e3ded4":
                        settings.BackGroundStyle = "c4-bg";
                        settings.HeadingStyle = "c3-text";
                        settings.TextStyle = String.Empty;
                        break;
                    //if background c5, c5 background + c6 text
                    //dark gray - gray
                    case "3a342e":
                        settings.BackGroundStyle = "c5-bg";
                        settings.HeadingStyle = "c6-text";
                        settings.TextStyle = String.Empty;
                        break;
                    //if background c6, c6 background + c5 text
                    //gray - dark gray
                    case "6f6862":
                        settings.BackGroundStyle = "c6-bg";
                        settings.HeadingStyle = "c5-text";
                        settings.TextStyle = String.Empty;
                        break;
                    //if no background selected, use primary colors
                    //if no background, c1 background + c2 text
                    default:
                        settings.BackGroundStyle = "c1-bg";
                        settings.HeadingStyle = "c2-text";
                        settings.TextStyle = String.Empty;
                        break;
                }
            }
            //if string is null or empty, use default
            //c1 background + c2 text
            else
            {
                settings.BackGroundStyle = "c1-bg";
                settings.HeadingStyle = "c2-text";
                settings.TextStyle = String.Empty;
            }

            if (!String.IsNullOrEmpty(buttonColour))
            {
                switch (buttonColour)
                {
                    //if button c1, c1 button + c2 text
                    //button redorange - black
                    case "ec6425":
                        settings.ButtonStyle = "c1-bg c2-text";
                        break;
                    //if button c2, c2 button + c1 text
                    //button black - redorange
                    case "101212":
                        settings.ButtonStyle = "c2-bg c1-text";
                        break;
                    //if button c3, c3 button + c4 text
                    //button blue - gray
                    case "46bea8":
                        settings.ButtonStyle = "c3-bg c4-text";
                        break;
                    //if button c4, c4 button + c3 text
                    //button gray - blue
                    case "e3ded4":
                        settings.ButtonStyle = "c4-bg c3-text";
                        break;
                    //if button c5, c5 button + c6 text
                    //button dark gray - gray
                    case "3a342e":
                        settings.ButtonStyle = "c5-bg c6-text";
                        break;
                    //if button c6, c6 button + c5 text
                    //button gray - dark gray
                    case "6f6862":
                        settings.ButtonStyle = "c6-bg c5-text";
                        break;
                    //if no button color selected, c2 button + c1 text
                    //button orange - black
                    default:
                        settings.ButtonStyle = "c2-bg c1-text";
                        break;
                }
            }
            //if button null or empty, default button
            //button orange - black
            else
            {
                settings.ButtonStyle = "c2-bg c1-text";
            }

            return settings;
        }

        public static string GetBackgroundImageStyle(IPublishedContent image = null, USNBackgroundOption backgroundImageOptions = null)
        {
            string output = String.Empty;
            string backgroundImage = String.Empty;
            string backgroundStyle = String.Empty;
            string backgroundPosition = String.Empty;

            if (image != null)
            {
                backgroundImage = String.Format("background-image:url('{0}');", image.Url);

                if (backgroundImageOptions != null)
                {
                    switch (backgroundImageOptions.Style)
                    {
                        case "Cover":
                            backgroundStyle = "background-repeat:no-repeat;background-size:cover;";
                            break;
                        case "Full width":
                            backgroundStyle = "background-repeat:no-repeat;background-size:100% auto;";
                            break;
                        case "Original":
                            backgroundStyle = "background-repeat:no-repeat;background-size:auto;";
                            break;
                        case "Repeat":
                            backgroundStyle = "background-repeat:repeat;background-size:auto;";
                            break;
                        case "Repeat X":
                            backgroundStyle = "background-repeat:repeat-x;background-size:auto;";
                            break;
                        case "Repeat Y":
                            backgroundStyle = "background-repeat:repeat-y;background-size:auto;";
                            break;
                        default:
                            backgroundStyle = "background-repeat:no-repeat;background-size:auto;";
                            break;
                    }

                    switch (backgroundImageOptions.Position)
                    {
                        case "Center / Top":
                            backgroundPosition = "background-position:center top;";
                            break;
                        case "Center / Center":
                            backgroundPosition = "background-position:center center;";
                            break;
                        case "Center / Bottom":
                            backgroundPosition = "background-position:center bottom;";
                            break;
                        case "Right / Top":
                            backgroundPosition = "background-position:right top;";
                            break;
                        case "Right / Center":
                            backgroundPosition = "background-position:right center;";
                            break;
                        case "Right / Bottom":
                            backgroundPosition = "background-position:right bottom;";
                            break;
                        case "Left / Top":
                            backgroundPosition = "background-position:left top;";
                            break;
                        case "Left / Center":
                            backgroundPosition = "background-position:left center;";
                            break;
                        case "Left / Bottom":
                            backgroundPosition = "background-position:left bottom;";
                            break;
                        default:
                            backgroundPosition = "background-position:center center;";
                            break;

                    }

                }

                output = backgroundImage + backgroundStyle + backgroundPosition;

                if (output != String.Empty)
                {
                    output = String.Format(" style=\"{0}\"", output);
                }
            }

            return output;
        }

    }
}
