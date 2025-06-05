using CsvHelper.Configuration.Attributes;

namespace OpenDataAnalyzerMvc.Models
{
    public class ElderCareRecord
    {
        [Name("區域")]
        public string 區域 { get; set; }

        [Name("電話問安")]
        public int 電話問安 { get; set; }

        [Name("長照服務")]
        public int 長照服務 { get; set; }

        [Name("其他服務")]
        public int 其他服務 { get; set; }

        [Name("合計")]
        public int 合計 { get; set; }

        [Name("服務人次")]
        public int 服務人次 { get; set; }
    }
}
