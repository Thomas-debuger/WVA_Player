# WAV Player 音效檔播放器 🎵

這是一個使用 C# Windows Forms 開發的輕量級 WAV 音效播放工具。提供直覺的圖形化使用者介面 (GUI)，讓使用者可以輕鬆選取、單次播放、循環播放及停止 `.wav` 格式的音訊檔案。

## 🌟 功能特色 (Features)

* **📂 瀏覽檔案 (Browse):** 內建檔案篩選器，專注於尋找 `.wav` 格式檔案，選取後自動顯示完整檔案路徑。
* **▶️ 播放 (Play):** 載入並播放選取的音訊。具備 Try-Catch 錯誤處理機制，若檔案路徑無效或讀取失敗，會跳出友善的錯誤提示視窗，避免程式崩潰。
* **🔁 重複播放 (Loop):** 支援音訊無縫循環播放，適合用來測試背景音樂 (BGM) 或持續性音效。
* **⏹️ 停止 (Stop):** 一鍵中斷目前的音訊播放狀態。
* **🛡️ 防誤觸機制:** 點擊「結束」按鈕或點擊視窗右上角 `X` 關閉程式時，會觸發 `FormClosing` 事件，跳出確認對話方塊，防止使用者意外關閉應用程式。

## 🛠️ 開發環境與技術 (Tech Stack)

* **程式語言:** C#
* **應用程式框架:** Windows Forms (.NET)
* **音訊處理核心:** `System.Media.SoundPlayer`
* **開發工具:** Visual Studio 2022

## 📸 執行畫面 (Screenshots)

> 💡 **操作提示：** 將程式執行時的截圖命名為 `screenshot.png`，並上傳至此 GitHub 專案的根目錄中，圖片就會自動顯示在下方。

![WAV Player 執行畫面](./screenshot.png)

## 🚀 執行與編譯說明 (Getting Started)

### 先決條件
請確保您的電腦已安裝 [Visual Studio 2022](https://visualstudio.microsoft.com/zh-hant/vs/)，並包含「.NET 桌面開發」工作負載。

### 執行步驟
1. 複製此專案到本地端：
   ```bash
   git clone [https://github.com/Thomas-debuger/WVA_Player.git](https://github.com/Thomas-debuger/WVA_Player.git)

2. 進入專案資料夾，對著 `WVA_Player.sln` 方案檔點擊兩下，以 Visual Studio 開啟專案。
3. 在 Visual Studio 中，按下鍵盤上的 `F5` 鍵，或點擊上方工具列的 **[啟動]** 按鈕。
4. 程式執行後：
* 點擊 **[瀏覽]** 選擇電腦中的任一 `.wav` 檔案。
* 點擊 **[播放]** 或 **[重複播放]** 來聆聽音效。
* 點擊 **[停止]** 結束播放。



## 📂 核心程式碼架構

本專案將播放器物件實例化為類別成員變數，確保所有按鈕事件都能共享同一個控制狀態：

```csharp

SoundPlayer player; // 宣告播放器物件為全域可用

```
