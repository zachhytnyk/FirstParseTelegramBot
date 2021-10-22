

namespace FirstParseTelegramBot.Core
{
    interface IParserSettings
    {
        string BaseUrl { get; set; } //сылка на сайт
        string Prefix { get; set; }// интрига
        int StartPoint { get; set; }// начальный индекс для парсинга
        int EndPoint { get; set; }//конечный индекс для парсинга 
    }
}
