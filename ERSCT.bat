::[Bat To Exe Converter]
::
::YAwzoRdxOk+EWAjk
::fBw5plQjdCyDJGyX8VAjFAxRQgeKAE+1EbsQ5+n//NaikH4+YK8aSrz47oirEtMw3gjBR6UO4kZTm8RCBRhXHg==
::YAwzuBVtJxjWCl3EqQJgSA==
::ZR4luwNxJguZRRnk
::Yhs/ulQjdF+5
::cxAkpRVqdFKZSDk=
::cBs/ulQjdF+5
::ZR41oxFsdFKZSDk=
::eBoioBt6dFKZSDk=
::cRo6pxp7LAbNWATEpCI=
::egkzugNsPRvcWATEpCI=
::dAsiuh18IRvcCxnZtBJQ
::cRYluBh/LU+EWAnk
::YxY4rhs+aU+IeA==
::cxY6rQJ7JhzQF1fEqQJhZko0
::ZQ05rAF9IBncCkqN+0xwdVsFAlXi
::ZQ05rAF9IAHYFVzEqQIVGih3eGQ=
::eg0/rx1wNQPfEVWB+kM9LVsJDCGwD0iOZg==
::fBEirQZwNQPfEVWB+kM9LVsJDCGwD0iOZg==
::cRolqwZ3JBvQF1fEqQK4wcXTpNoFxbA81UCbGjh+IhIBaLmViQu5l3ReDXELxTdz
::dhA7uBVwLU+EWH2L4UA8LTM0
::YQ03rBFzNR3SWATElA==
::dhAmsQZ3MwfNWATE3E0+LwJdZAWMNws=
::ZQ0/vhVqMQ3MEVWAtB9wSA==
::Zg8zqx1/OA3MEVWAtB9wSA==
::dhA7pRFwIByZRRnk
::Zh4grVQjdCyDJGyX8VAjFAxRQgeKAE+1EbsQ5+n//NaikH4+YK8aSrz47oirEtMw3gjBR6UO4kZ/qvgvOFVdZhfL
::YB416Ek+ZG8=
::
::
::978f952a14a936cc963da21a135fa983
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
