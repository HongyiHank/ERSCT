c:

cd %USERPROFILE%/AppData/Roaming

if not exist "EldenRing" mkdir "EldenRing"

if not exist "ERSCT_Saves_1(Don't_move)" mkdir "ERSCT_Saves_1(Don't_move)"

ren EldenRing ERSCT_Saves_2(Don't_move)

ren ERSCT_Saves_1(Don't_move) EldenRing

ren ERSCT_Saves_2(Don't_move) ERSCT_Saves_1(Don't_move)