# OpenDataAnalyzerMvc

這是一個 ASP.NET Core MVC 專案，使用政府開放資料 (OpenData) - 桃園市列冊獨居老人服務概況，進行資料讀取與網頁展示。

## 功能

- 讀取 CSV 檔案並轉為模型資料
- 使用 Service 模式封裝資料邏輯
- 在網頁上以表格形式顯示

## 使用方式

1. 將 CSV 放置於 `wwwroot/data/` 目錄下
2. 執行 `dotnet run`
3. 瀏覽 `http://localhost:5005/ElderCare` 查看結果
