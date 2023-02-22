setlocal
set arg1=%1
set arg2=%2
set arg2clean=%arg2::=%
xcopy /Y %arg1% %arg2clean%