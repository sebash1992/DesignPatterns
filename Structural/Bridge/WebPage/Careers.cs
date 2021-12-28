using Bridge.Theme;

namespace Bridge.WebPage
{
    public class Careers : IWebPage
    {
        protected ITheme theme;

        public Careers(ITheme theme)
        {
            this.theme = theme;
        }

        public string GetContent()
        {
            return $"Careers page in {theme.GetColor()}";
        }
    }
}
