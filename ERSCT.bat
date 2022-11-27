@Echo off
Title ERSCT                                              
Color 6   
cd %USERPROFILE%/AppData/Roaming
:caozuo  
echo שששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששש
echo ¦ד÷¸µn×kְפ¦sְֲֹא´«₪u¨ד¡G      
echo    1.²M°£·ם«e¦sְֹ  
echo    2.ֲא´«¦sְֹ     
echo    3.¬d¬Ý¾Þ§@»¡©ת
echo    4.ֲק¶}   
echo שששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששש
set /p n=½׀¿י₪J¿ן¶µ¡G 
if "%n%"=="" cls&goto :caozuo 
if "%n%"=="1" call :1 
if "%n%"=="2" call :2 
if "%n%"=="3" call :3 
if "%n%"=="4" call :4 
if /i "%n%"=="n" exit 
pause 
goto :eof 

:1 
echo ¦¨¥\²M°£¦sְֹ 
ren EldenRing ERSCT_Saves_1(Don't_move)
goto :caozuo 

:2 
echo ֲא´«¦sְֹ₪₪½׀µ¥«Ý...(½׀₪ֵ«צ¥פ¦ף«צֱה)
ren EldenRing ERSCT_Saves_2(Don't_move)
timeout /t 1
ren ERSCT_Saves_1(Don't_move) EldenRing
timeout /t 1
ren ERSCT_Saves_2(Don't_move) ERSCT_Saves_1(Don't_move)
timeout /t 1
echo ֲא´«§¹¦¨
goto :caozuo 

:3 
echo ¬d¬Ý¾Þ§@»¡©ת 
start https://hongyihanksblog.ml/ERSCT
goto :caozuo 

:4
echo ֲק¶}
exit 
goto :caozuo
