#define MyAppName "Pong"
#define MyAppVersion "5.0"
#define MyAppPublisher "Skitters"
#define MyAppURL "https://twitter.com/RockingGamer37"
#define MyAppExeName "Pong.exe"
[Setup]
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DisableProgramGroupPage=yes
OutputDir=D:\Codes\UnityGames\Builds\Windows\Installers\Pong
OutputBaseFilename=Pong
SetupIconFile=D:\Codes\UnityGames\Pong\Assets\Icons\Logo.ico
Compression=lzma
SolidCompression=yes
[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
[Files]
Source: "D:\Codes\UnityGames\Builds\Windows\Pong\Pong.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Codes\UnityGames\Builds\Windows\Pong\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

