=========================================================
AUTO UPDATE EXE – C# Solution (Visual Studio Project)
=========================================================

📌 Overview:
------------
This is a C# Auto-Updater application built in Microsoft Visual Studio. 
It checks a remote version file and updates the main application if a newer version is available.

Built for Windows Desktop apps, this solution is ideal for developers who want seamless, version-controlled updates without user intervention.

🔧 Technologies:
---------------
- Language: C#
- IDE: Visual Studio (2022 recommended)
- Framework: .NET Framework 4.7.2 (or your version)
- Architecture: 32-bit / 64-bit supported
- Format: Windows Forms (WinForms)

📁 Project Structure:
---------------------
/AutoUpdateApp/         → Main auto-updater logic (EXE)
/MainApp/               → Your actual application that will be updated
/UpdateInfo.json        → Sample version configuration file
/README.txt             → Project documentation

📦 Requirements:
----------------
- Visual Studio installed (.NET desktop development workload)
- Hosting for `UpdateInfo.json` and latest EXE (GitHub, VPS, Dropbox, etc.)
- Windows OS

🚀 Setup Instructions:
----------------------
1. Clone or download this repository to your system.
2. Open the solution `.sln` file in Visual Studio.
3. Modify the `UpdateInfo.json` URL and logic to point to your hosted version info.
4. Build both projects: Updater and MainApp.
5. When launching the main app, trigger the updater before or during runtime.

📝 How Auto Update Works:
--------------------------
1. `UpdateInfo.json` (hosted online) holds:
   - Latest version number
   - URL to the updated EXE

Example `UpdateInfo.json`:
```json
{
  "version": "1.2.0",
  "url": "https://yourdomain.com/files/MainApp.exe"
}
