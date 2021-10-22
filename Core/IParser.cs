using AngleSharp.Html.Dom;

namespace FirstParseTelegramBot.Core
{
    interface IParser<T> where T:class
    {
        T Parse(IHtmlDocument document);
    }
}
