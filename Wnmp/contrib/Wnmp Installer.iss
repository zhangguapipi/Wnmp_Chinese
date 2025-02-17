; Wnmp iss
#define public Dependency_NoExampleSetup
#include "CodeDependencies.iss"

#define MyAppName "Wnmp"
#define MyAppVersion "4.0.5"
#define MyAppPublisher "Kurt Cancemi"
#define MyAppURL "https://wnmp.x64architecture.com"
#define MyAppExeName "Wnmp.exe"
#define Year "2021"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{44CF85C5-C9D2-435F-941B-75597AA9A6FB}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
WizardStyle=modern
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={sd}\{#MyAppName}
SourceDir=..\
DefaultGroupName={#MyAppName}
VersionInfoDescription=Wnmp (version {#MyAppVersion})
VersionInfoCopyright=Copyright 2012-{#Year} Kurt Cancemi
VersionInfoCompany=Kurt Cancemi
LicenseFile=docs\Wnmp.LICENSE
InfoBeforeFile=
InfoAfterFile=contrib\postinstall.txt
OutputDir=../WnmpOutput
OutputBaseFilename=Wnmp-{#MyAppVersion}
SetupIconFile=../src/Wnmp/logo.ico
Compression=lzma2/normal
LZMANumBlockThreads=4
LZMAUseSeparateProcess=yes
SolidCompression=false
RestartIfNeededByRun=false
PrivilegesRequired=admin
DirExistsWarning=no
ArchitecturesAllowed=x64
ArchitecturesInstallIn64BitMode=x64

[Languages]
Name: english; MessagesFile: compiler:Default.isl

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked

[Dirs]
Name: "{app}\nginx-bins\default\logs\"

[Files]
Source: contrib\*; DestDir: {app}\contrib; Flags: ignoreversion recursesubdirs createallsubdirs

Source: docs\*; DestDir: {app}\docs; Flags: ignoreversion recursesubdirs createallsubdirs

Source: mariadb-bins\default\bin\*; DestDir: {app}\mariadb-bins\default\bin; Flags: ignoreversion
Source: mariadb-bins\default\include\*; DestDir: {app}\mariadb-bins\default\include; Flags: ignoreversion recursesubdirs createallsubdirs
Source: mariadb-bins\default\lib\*; DestDir: {app}\mariadb-bins\default\lib; Flags: ignoreversion recursesubdirs createallsubdirs
Source: mariadb-bins\default\share\*; DestDir: {app}\mariadb-bins\default\share; Flags: ignoreversion recursesubdirs createallsubdirs

Source: nginx-bins\default\conf\*; Excludes: "key.pem,cert.pem,.gitignore"; DestDir: {app}\nginx-bins\default\conf; Flags: ignoreversion recursesubdirs createallsubdirs
Source: nginx-bins\default\temp\*; DestDir: {app}\nginx-bins\default\temp; Flags: ignoreversion recursesubdirs createallsubdirs

Source: nginx-bins\default\www\phpmyadmin\doc\html\_images\*; DestDir: {app}\nginx-bins\default\www\phpmyadmin\doc\html\_images; Flags: ignoreversion nocompression recursesubdirs createallsubdirs
Source: nginx-bins\default\www\phpmyadmin\themes\metro\img\*; DestDir: {app}\nginx-bins\default\www\phpmyadmin\themes\metro\img; Flags: ignoreversion nocompression recursesubdirs createallsubdirs
Source: nginx-bins\default\www\phpmyadmin\themes\original\img\*; DestDir: {app}\nginx-bins\default\www\phpmyadmin\themes\original\img; Flags: ignoreversion nocompression recursesubdirs createallsubdirs
Source: nginx-bins\default\www\phpmyadmin\themes\pmahomme\img\*; DestDir: {app}\nginx-bins\default\www\phpmyadmin\themes\pmahomme\img; Flags: ignoreversion nocompression recursesubdirs createallsubdirs
Source: nginx-bins\default\www\phpmyadmin\*; Excludes: .gitignore, *.png, *.jpg, *.jpeg; DestDir: {app}\nginx-bins\default\www\phpmyadmin; Flags: ignoreversion recursesubdirs createallsubdirs

Source: nginx-bins\default\www\index.php; DestDir: {app}\nginx-bins\default\www; Flags: ignoreversion onlyifdoesntexist
Source: nginx-bins\default\nginx.exe; DestDir: {app}\nginx-bins\default; Flags: ignoreversion

Source: php-bins\default\*; Excludes: ".gitignore"; DestDir: {app}\php-bins\default; Flags: ignoreversion recursesubdirs createallsubdirs

Source: readme.txt; DestDir: {app}; Flags: ignoreversion
Source: System.ServiceProcess.ServiceController.dll; DestDir: {app}; Flags: ignoreversion
Source: Wnmp.deps.json; DestDir: {app}; Flags: ignoreversion
Source: Wnmp.dll; DestDir: {app}; Flags: ignoreversion
Source: Wnmp.dll.config; DestDir: {app}; Flags: ignoreversion
Source: Wnmp.exe; DestDir: {app}; Flags: ignoreversion
Source: Wnmp.Language.dll; DestDir: {app}; Flags: ignoreversion
Source: Wnmp.Language.pdb; DestDir: {app}; Flags: ignoreversion
Source: Wnmp.pdb; DestDir: {app}; Flags: ignoreversion
Source: Wnmp.runtimeconfig.json; DestDir: {app}; Flags: ignoreversion onlyifdoesntexist
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: {group}\{#MyAppName}; Filename: {app}\{#MyAppExeName}
Name: {group}\{cm:UninstallProgram,{#MyAppName}}; Filename: {uninstallexe}
Name: {commondesktop}\{#MyAppName}; Filename: {app}\{#MyAppExeName}; Tasks: desktopicon

[Run]
Filename: {app}\{#MyAppExeName}; Description: {cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}; Flags: nowait postinstall shellexec
Filename: iexplore.exe; Parameters: "https://wnmp.x64architecture.com"; Verb: open; Flags: shellexec runasoriginaluser

[Code]
procedure InitializeWizard;
begin
  Dependency_InitializeWizard;
end;

function PrepareToInstall(var NeedsRestart: Boolean): String;
begin
  Result := Dependency_PrepareToInstall(NeedsRestart);
end;

function NeedRestart: Boolean;
begin
  Result := Dependency_NeedRestart;
end;

function UpdateReadyMemo(const Space, NewLine, MemoUserInfoInfo, MemoDirInfo, MemoTypeInfo, MemoComponentsInfo, MemoGroupInfo, MemoTasksInfo: String): String;
begin
  Result := Dependency_UpdateReadyMemo(Space, NewLine, MemoUserInfoInfo, MemoDirInfo, MemoTypeInfo, MemoComponentsInfo, MemoGroupInfo, MemoTasksInfo);
end;

function InitializeSetup: Boolean;
begin
  Dependency_AddVC2015To2019;
  Dependency_AddDotNet50Desktop;

  Result := True;
end;