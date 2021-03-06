/*
Keppy's Driver blacklist system
*/

BOOL ProcessBlackList(){
	// Blacklist system init
	TCHAR defaultstring[MAX_PATH];
	TCHAR userstring[MAX_PATH];
	TCHAR defaultblacklistdirectory[MAX_PATH];
	TCHAR userblacklistdirectory[MAX_PATH];
	TCHAR modulename[MAX_PATH];
	// VirtualMIDISynth 1.x ban init
	TCHAR vmidisynthpath[MAX_PATH];
	SHGetFolderPath(NULL, CSIDL_SYSTEM, NULL, 0, vmidisynthpath);
	PathAppend(vmidisynthpath, _T("\\VirtualMIDISynth\\VirtualMIDISynth.dll"));
	GetModuleFileName(NULL, modulename, MAX_PATH);
	PathStripPath(modulename);
	try {
		if (PathFileExists(vmidisynthpath)) {
			MessageBox(NULL, L"Please uninstall VirtualMIDISynth 1.x before using this driver.\n\nWhy this? Well, VirtualMIDISynth 1.x causes a DLL Hell while loading the BASS libraries, that's why you need to uninstall it before using my driver.\n\nYou can still use VirtualMIDISynth 2.x, since it doesn't load the DLLs directly into the MIDI application.", L"Keppy's Driver", MB_OK | MB_ICONERROR | MB_SYSTEMMODAL);
			return 0x0;
		}
		else {
			if (GetWindowsDirectory(defaultblacklistdirectory, MAX_PATH)) {
				_tcscat(defaultblacklistdirectory, L"\\keppymididrv.defaultblacklist");
				std::wifstream file(defaultblacklistdirectory);
				if (file) {
					// The default blacklist exists, continue
					OutputDebugString(defaultblacklistdirectory);
					while (file.getline(defaultstring, sizeof(defaultstring) / sizeof(*defaultstring)))
					{
						if (_tcsicmp(modulename, defaultstring) == 0) {
							return 0x0;
						}
					}
				}
				else {
					MessageBox(NULL, L"The default blacklist is missing, or the driver is not installed properly!\nFatal error, can not continue!\n\nPress OK to quit.", L"Keppy's MIDI Driver - FATAL ERROR", MB_OK | MB_ICONERROR | MB_SYSTEMMODAL);
					exit(0);
				}
			}
			if (SUCCEEDED(SHGetFolderPath(NULL, CSIDL_LOCAL_APPDATA, NULL, 0, userblacklistdirectory))) {
				PathAppend(userblacklistdirectory, _T("\\Keppy's Driver\\blacklist\\keppymididrv.blacklist"));
				std::wifstream file(userblacklistdirectory);
				OutputDebugString(userblacklistdirectory);
				while (file.getline(userstring, sizeof(userstring) / sizeof(*userstring)))
				{
					if (_tcsicmp(modulename, userstring) == 0) {
						std::wstring modulenamelpcwstr(modulename);
						std::wstring concatted_stdstr = L"Keppy's Driver - " + modulenamelpcwstr + L" is blacklisted";
						LPCWSTR messageboxtitle = concatted_stdstr.c_str();
						MessageBox(NULL, L"This program has been manually blacklisted.\n\nThe driver will be automatically unloaded by WinMM.", messageboxtitle, MB_OK | MB_ICONEXCLAMATION | MB_SYSTEMMODAL);
						return 0x0;
					}
				}
			}
			return 0x1;
		}
	}
	catch (std::exception & e) {
		OutputDebugStringA(e.what());
		exit;
	}
}

BOOL BannedSystemProcess() {
	// These processes are PERMANENTLY banned because of some internal bugs inside them.
	TCHAR modulename[MAX_PATH];
	TCHAR bannedconsent[MAX_PATH];
	TCHAR bannedexplorer[MAX_PATH];
	TCHAR bannedcsrss[MAX_PATH];
	TCHAR bannedscratch[MAX_PATH];
	_tcscpy_s(bannedconsent, _countof(bannedconsent), _T("consent.exe"));
	_tcscpy_s(bannedexplorer, _countof(bannedexplorer), _T("explorer.exe"));
	_tcscpy_s(bannedcsrss, _countof(bannedcsrss), _T("csrss.exe"));
	_tcscpy_s(bannedcsrss, _countof(bannedscratch), _T("scratch.exe"));
	GetModuleFileName(NULL, modulename, MAX_PATH);
	PathStripPath(modulename);
	if (!_tcsicmp(modulename, bannedconsent) | !_tcsicmp(modulename, bannedexplorer) | !_tcsicmp(modulename, bannedcsrss) | !_tcsicmp(modulename, bannedscratch)) {
		return TRUE;
		// It's a blacklisted process, so it can NOT create a BASS audio stream.
	}
	else {
		return FALSE;
		// It's not a blacklisted process, so it can create a BASS audio stream.
	}
}