// ElderCareService.cs
using System.Globalization;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using OpenDataAnalyzerMvc.Models;

namespace OpenDataAnalyzerMvc.Services
{
    public class ElderCareService
    {
        private readonly IWebHostEnvironment _environment;
        private readonly string _fileName = "114-1年桃園市列冊獨居老人服務概況.csv";

        public ElderCareService(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public List<ElderCareRecord> GetRecords()
        {
            var filePath = Path.Combine(_environment.WebRootPath, "data", _fileName);

            // 註冊 Big5 編碼支援
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            using var reader = new StreamReader(filePath, Encoding.GetEncoding("big5"));
            using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                HeaderValidated = null,
                MissingFieldFound = null
            });

            // 支援千位符號，如 23,475
            csv.Context.TypeConverterOptionsCache.GetOptions<int>().NumberStyles = NumberStyles.AllowThousands;

            return csv.GetRecords<ElderCareRecord>().ToList();
        }
    }
}
