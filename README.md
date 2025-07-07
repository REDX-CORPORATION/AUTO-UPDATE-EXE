# EXE AUTO UPDATE
===========================
AUTO UPDATE EXE (C#)
===========================

📌 Description:
---------------
This is a C# Auto-Update EXE solution that allows your application to automatically check for updates and download the latest version when available. It removes the hassle of manually updating software for end users.

⚙️ Features:
------------
- Auto version check
- Remote update URL support
- Silent or prompt-based updates
- Lightweight and easy to integrate

📁 Project Structure:
---------------------
- /Updater             --> The auto-update EXE project
- /MainApp             --> Your main application project
- /UpdateInfo.json     --> Sample file for version info
- /README.txt          --> This file

📦 Requirements:
----------------
- .NET Framework 4.x (or your target version)
- Internet access for update checking
- GitHub or any file hosting service for update binaries

🚀 How to Use:
--------------
1. Set up a version file (e.g., `UpdateInfo.json`) on your server with version info and download URL.
2. Integrate the Auto Update EXE into your main project.
3. On app launch, call the updater and check for a new version.
4. If available, download and replace the executable.

🛠️ How to Build:
------------------
1. Open the solution in Visual Studio.
2. Restore NuGet packages (if used).
3. Build the solution (Build > Build Solution).
4. Output EXEs will be in `/bin/Debug` or `/bin/Release`.

📄 Version Format:
------------------
Example `UpdateInfo.json`:
{
  "version": "1.1.0",
  "url": "https://yourdomain.com/files/newversion.exe"
}

📬 Contact / Support:
---------------------
If you need help, feel free to reach out:

Telegram: https://t.me/+OglBPVcrngY1OGQ9  
Discord: https://discord.gg/f7KPc9JyeY

© 2025 RED-X CORPORATION
