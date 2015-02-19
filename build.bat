

@rem build
setlocal
@rem preparing environment

@IF EXIST "c:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\Tools\vsvars32.bat" SET devenv="c:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\Tools\vsvars32.bat"
@IF EXIST "c:\Program Files\Microsoft Visual Studio 10.0\Common7\Tools\vsvars32.bat" SET devenv="c:\Program Files\Microsoft Visual Studio 10.0\Common7\Tools\vsvars32.bat"
@IF EXIST "c:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\Tools\vsvars32.bat" SET devenv="c:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\Tools\vsvars32.bat"
@IF EXIST "c:\Program Files\Microsoft Visual Studio 11.0\Common7\Tools\vsvars32.bat" SET devenv="c:\Program Files\Microsoft Visual Studio 11.0\Common7\Tools\vsvars32.bat"
@IF EXIST "c:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\Tools\vsvars32.bat" SET devenv="C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\Tools\vsvars32.bat"
@IF EXIST "C:\Program Files\Microsoft Visual Studio 12.0\Common7\Tools\vsvars32.bat" SET devenv="C:\Program Files\Microsoft Visual Studio 12.0\Common7\Tools\vsvars32.bat"

set cur_dir=%CD%
call %devenv% || exit /b 1
set SLNPATH=src\Asn1Net.Forms.Viewer.sln

@rem build version (.NET 4.0)
msbuild %SLNPATH% /p:Configuration=Release;TargetFrameworkVersion=v4.5 /toolsversion:4.0 /target:ReBuild || exit /b 1


@rem set variables
set OUTDIR=build\Asn1Net.Forms.Viewer\
set SRCDIR=src\Asn1Net.Forms.Viewer\bin\Release

@rem prepare output directory
rmdir /S /Q %OUTDIR%
mkdir %OUTDIR% || exit /b 1

@rem copy files to output directory
copy %SRCDIR%\*.exe %OUTDIR% || exit /b 1
copy %SRCDIR%\*.dll %OUTDIR% || exit /b 1
copy %SRCDIR%\*.xml %OUTDIR% || exit /b 1

@rem set license variables
set LICENSEDIR=%OUTDIR%\License
mkdir %LICENSEDIR%

@rem copy licenses to output directory
copy LICENSE %LICENSEDIR%\license.txt || exit /b 1
copy agpl-3.0.txt %LICENSEDIR% || exit /b 1
copy README.md %LICENSEDIR%\Readme.txt || exit /b 1

@rem copy 3rd party licences
pushd src\packages\Asn1Net.Reader.* || exit /b 1
copy 3rd-party-license.txt ..\..\..\%LICENSEDIR%\asn1net.reader-3rd-party-license.txt || exit /b 1
copy license.txt ..\..\..\%LICENSEDIR%\asn1net.reader-license.txt || exit /b 1
popd

pushd src\packages\Asn1Net.Forms.TreeView.* || exit /b 1
copy 3rd-party-license.txt ..\..\..\%LICENSEDIR%\asn1net.forms.treeview-3rd-party-license.txt || exit /b 1
copy license.txt ..\..\..\%LICENSEDIR%\asn1net.forms.treeview-license.txt || exit /b 1
popd

endlocal

@echo BUILD SUCCEEDED !!!
@exit /b 0