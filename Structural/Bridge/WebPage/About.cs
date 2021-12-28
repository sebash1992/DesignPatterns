using Bridge.Theme;

namespace Bridge.WebPage
{
    public class About : IWebPage
    {
        protected ITheme theme;

        public About(ITheme theme)
        {
            this.theme = theme;
        }

        public string GetContent()
        {
            return $"About page in {theme.GetColor()}";
        }
    }
}
