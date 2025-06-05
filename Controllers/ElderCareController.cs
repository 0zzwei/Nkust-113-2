using Microsoft.AspNetCore.Mvc;
using OpenDataAnalyzerMvc.Services;
using OpenDataAnalyzerMvc.Models;

namespace OpenDataAnalyzerMvc.Controllers
{
    public class ElderCareController : Controller
    {
        private readonly ElderCareService _elderCareService;

        public ElderCareController(ElderCareService elderCareService)
        {
            _elderCareService = elderCareService;
        }

        // 顯示資料列表
        public IActionResult Index()
        {
            var records = _elderCareService.GetRecords();
            return View(records);
        }

        // 顯示單筆資料詳細資訊
        public IActionResult Details(int id)
        {
            var records = _elderCareService.GetRecords();
            if (id < 0 || id >= records.Count)
            {
                return NotFound();
            }

            var record = records[id];
            return View(record);
        }

        // 其他功能（如 Upload, Report）可再補上
    }
}
