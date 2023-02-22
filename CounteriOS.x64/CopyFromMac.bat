setlocal
set arg1=%1
set arg1clean=%arg1::=%
set arg2=%2
xcopy /Y %arg1clean% %arg2%