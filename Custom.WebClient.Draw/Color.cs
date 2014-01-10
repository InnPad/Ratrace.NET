// Color.cs
//

using System;

namespace Custom
{
    public class Color
    {
        public int _red;
        public int _green;
        public int _blue;
        public int _alpha;
        public string _value;
        public bool _rgb;

        public Color(string color)
        {
            _value = color;

            // Trim trailing/leading whitespace
            color = color.ReplaceRegex(new RegularExpression(@"^\s*|\s*$"), "");

            // Expand three-digit hex
            color = color.ReplaceRegex(new RegularExpression(@"^#?([a-f0-9])([a-f0-9])([a-f0-9])$"), "#$1$1$2$2$3$3");

            // Determine if input is RGB(A)
            string[] rgb = color.Match(new RegularExpression("^rgba?\\(\\s*" +
                                                             "(\\d|[1-9]\\d|1\\d{2}|2[0-4][0-9]|25[0-5])" +
                                                             "\\s*,\\s*" +
                                                             "(\\d|[1-9]\\d|1\\d{2}|2[0-4][0-9]|25[0-5])" +
                                                             "\\s*,\\s*" +
                                                             "(\\d|[1-9]\\d|1\\d{2}|2[0-4][0-9]|25[0-5])" +
                                                             "(?:\\s*,\\s*" +
                                                             "(0|1|0?\\.\\d+))?" +
                                                             "\\s*\\)$"
                                                             , "i"));

            if (rgb != null)
            {
                _rgb = true;
                _alpha = rgb[4] != null ? int.Parse(rgb[4]) : 0;
                _red = int.Parse(rgb[1]);
                _green = int.Parse(rgb[2]);
                _blue = int.Parse(rgb[3]);
            }
            else
            {
                string[] web = color.Match(new RegularExpression(@"^#?([a-f0-9][a-f0-9])([a-f0-9][a-f0-9])([a-f0-9][a-f0-9])"));
                _rgb = false;
                _alpha = 0;
                _red = int.Parse(web[1], 16);
                _green = int.Parse(web[2], 16);
                _blue = int.Parse(web[3], 16);
            }
        }

        public string Value
        {
            get { return _value; }
        }

        public string Lighter(double ratio)
        {
            // Calculate ratio
            Number difference = Math.Round(ratio * 256);
            int red = Math.Min(_red + difference, 255);
            int green = Math.Min(_green + difference, 255);
            int blue = Math.Min(_blue + difference, 255);

            string color = _rgb ?
                    (_alpha != 0 ? string.Format("rgba({0}, {1}, {2}, {3})", red, green, blue, _alpha)
                        : string.Format("rgb({0}, {1}, {2})", red, green, blue))
                        : string.Concat("#", red.ToString(16), green.ToString(16), blue.ToString(16));

            return color;
        }

        public string Darker(double ratio)
        {
            // Calculate ratio
            Number difference = -Math.Round(ratio * 256);
            int red = Math.Max(_red + difference, 0);
            int green = Math.Max(_green + difference, 0);
            int blue = Math.Max(_blue + difference, 0);

            string color = _rgb ?
                    (_alpha != 0 ? string.Format("rgba({0}, {1}, {2}, {3})", red, green, blue, _alpha)
                        : string.Format("rgb({0}, {1}, {2})", red, green, blue))
                        : string.Format("#{0:x2}{1:x2}{2:x2}", red, green, blue);

            return color;
        }
    }
}
