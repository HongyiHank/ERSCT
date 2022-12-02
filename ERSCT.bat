@Echo off
Title ERSCT                                              
Color 6   
cd %USERPROFILE%/AppData/Roaming
:caozuo  
echo ═══════════════════════════════════════
echo 艾爾登法環存檔轉換工具：      
echo    1.清除當前存檔  
echo    2.轉換存檔     
echo    3.查看操作說明
echo    4.打開存檔位置   
echo    5.離開
echo ═══════════════════════════════════════
set /p n=請輸入選項： 
if "%n%"=="" cls&goto :caozuo 
if "%n%"=="1" call :1 
if "%n%"=="2" call :2 
if "%n%"=="3" call :3 
if "%n%"=="4" call :4 
if "%n%"=="5" call :5
if /i "%n%"=="n" exit 
pause 
goto :eof 

:1 
echo 成功清除存檔 
ren EldenRing ERSCT_Saves_1(Don't_move)
goto :caozuo 

:2 
echo 轉換存檔中請等待...
ren EldenRing ERSCT_Saves_2(Don't_move)
ren ERSCT_Saves_1(Don't_move) EldenRing
ren ERSCT_Saves_2(Don't_move) ERSCT_Saves_1(Don't_move)
echo 轉換完成
goto :caozuo 

:3 
echo 查看操作說明 
start https://hongyihanksblog.ml/ERSCT
goto :caozuo 

:4 
echo 打開存檔位置 
start %USERPROFILE%/AppData/Roaming/EldenRing
goto :caozuo 

:5
echo 離開
exit 
goto :caozuo
