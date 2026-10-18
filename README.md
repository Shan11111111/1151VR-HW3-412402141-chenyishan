# 1151VR-HW3-412402141-陳怡珊
<br>
1、專案截圖
 <img width="865" height="517" alt="image" src="https://github.com/user-attachments/assets/68e39eaf-328e-4f69-bebe-0660d1ae16e6" />
<br>
2、github連結
<br>
https://github.com/Shan11111111/1151VR-HW3-412402141-chenyishan
<br>
3、youtube連結
<br>
https://youtube.com/shorts/_8F8b6SRGfM?si=tf2_x-hS15dBGExs
<br>
4、製作流程和相關操作
<br>
(1)、建立 Unity 2D 專案
<br>
    使用 Unity Hub 建立 2D 專案，設定主要遊戲場景 TestScene，並調整攝影機與遊戲畫面的顯示比例。
    <br>
(2)、匯入自己手繪的圖片素材<br>
    將輪盤、指針及角色圖片匯入 Unity，利用 Sprite Renderer 將素材配置於遊戲場景中，調整大小、位置與圖層順序，確保畫面正常顯示。<br>
(3)、撰寫輪盤控制程式<br>
    建立 RouletteController.cs，透過 C# 腳本控制輪盤旋轉。主要功能包括：接收玩家的操作指令、控制輪盤開始旋轉、實現加速與減速效果，最後在輪盤停止後呈現最終指向的結果。<br>
(4)、音效匯入<br>
    使用 Unity 的 AudioSource 元件整合旋轉相關音效，增加操作回饋與遊戲的互動感。共三個音效:輪盤開始音效、輪盤轉動音效、輪盤指到最後一格的音效。<br>
(5)、Android 平台設定<br>
    在 Unity 的 Build Profiles 中選擇 Android，並完成下列設定：設定 Android Package Name、將 TestScene 加入建置場景清單、設定輸入系統(old)以支援遊戲控制、使用 Build 功能產生 Android APK。<br>
(6)、建置與測試<br>
    專案已透過 Unity Android Build，Console 顯示 Build completed with a result of 'Succeeded'，確認 APK 建置程序成功。Android 實機操作結果。如YT影片所示。<br>
(7)、遊戲操作說明<br>
1.	點擊螢幕，啟動輪盤遊戲。
2.	透過遊戲所設定的滑鼠或觸控操作啟動旋轉。
3.	觀察輪盤轉動與速度變化。
4.	等待輪盤減速並停止。
5.	依照指針位置確認最終結果。
(8)測試結果<br>
    本專案完成 Unity 2D 輪盤遊戲的基本畫面及旋轉功能，並成功執行 Android 平台建置。開發過程中曾遇到 Unity 新舊輸入系統的相容性問題，導致 RouletteController.cs 無法正確讀取輸入。經過調整 Active Input Handling 設定後，恢復輪盤的正常操作。<br>

