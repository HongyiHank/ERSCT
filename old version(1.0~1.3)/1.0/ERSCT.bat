@Echo off
Title ERSCT                                              
Color 6   
cd %USERPROFILE%/AppData/Roaming
:caozuo  
echo ������������������������������������������������������������������������������
echo �㺸�n�k���s���ഫ�u��G      
echo    1.�M����e�s��  
echo    2.�ഫ�s��     
echo    3.�d�ݾާ@����
echo    4.���}   
echo ������������������������������������������������������������������������������
set /p n=�п�J�ﶵ�G 
if "%n%"=="" cls&goto :caozuo 
if "%n%"=="1" call :1 
if "%n%"=="2" call :2 
if "%n%"=="3" call :3 
if "%n%"=="4" call :4 
if /i "%n%"=="n" exit 
pause 
goto :eof 

:1 
echo ���\�M���s�� 
ren EldenRing ERSCT_Saves_1(Don't_move)
goto :caozuo 

:2 
echo �ഫ�s�ɤ��е���...(�Фū��������)
ren EldenRing ERSCT_Saves_2(Don't_move)
timeout /t 1
ren ERSCT_Saves_1(Don't_move) EldenRing
timeout /t 1
ren ERSCT_Saves_2(Don't_move) ERSCT_Saves_1(Don't_move)
timeout /t 1
echo �ഫ����
goto :caozuo 

:3 
echo �d�ݾާ@���� 
start https://hongyihanksblog.ml/ERSCT
goto :caozuo 

:4
echo ���}
exit 
goto :caozuo
