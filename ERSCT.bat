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
echo ������������������������������������������������������������������������������
echo �㺸�n�k���s���ഫ�u��G      
echo    1.�M����e�s��  
echo    2.�ഫ�s��     
echo    3.�d�ݾާ@����
echo    4.���}�s�ɦ�m   
echo    5.���}
echo ������������������������������������������������������������������������������
set /p n=�п�J�ﶵ�G 
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
echo ���\�M���s�� 
ren EldenRing ERSCT_Saves_1(Don't_move)
goto :caozuo 

:2 
echo �ഫ�s�ɤ��е���...
ren EldenRing ERSCT_Saves_2(Don't_move)
ren ERSCT_Saves_1(Don't_move) EldenRing
ren ERSCT_Saves_2(Don't_move) ERSCT_Saves_1(Don't_move)
echo �ഫ����
goto :caozuo 

:3 
echo �d�ݾާ@���� 
start https://hongyihanksblog.ml/ERSCT
goto :caozuo 

:4 
echo ���}�s�ɦ�m 
start %USERPROFILE%/AppData/Roaming/EldenRing
goto :caozuo 

:5
echo ���}
exit 
goto :caozuo
