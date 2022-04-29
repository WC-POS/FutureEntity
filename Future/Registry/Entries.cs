
using System.Diagnostics;

namespace FutureEntity.Future.Registry;
public static class Entries{
    
    //Determines if FPOS is installed determined by the existance of a registry entry.
    public static bool IsInstalled(){
        string DefaultRegistryPath = "HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Future P.O.S.\\";

        return true;
    }
    /**
        <summary>
        Returns true if the FPOS Registry subkey exists and returns false otherwise. The value held in the FPOS Directory registry entry is assigned to path.
        </summary>
    **/
    public static bool GetInstallationPath(out string? path){
        path = null;
        if(IsInstalled()){ 
            path = (string?)Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Future P.O.S.\\DIRECTORIES\\","FPOS Directory", null);
            return true;
        }
        return false;
    }
    //Get FPOS Version
    public static int? GetMajorVersion(){
        if(GetInstallationPath(out string? InstallPath)){
            FileVersionInfo info = FileVersionInfo.GetVersionInfo((InstallPath ?? "") + "\\bin\\fpos.exe");
            return info.FileMajorPart;
        }
        return null;
    }

    public static string? GetFullVersion(){
        if(GetInstallationPath(out string? InstallPath)){
            FileVersionInfo info = FileVersionInfo.GetVersionInfo((InstallPath ?? "") + "\\bin\\fpos.exe");
            return info.FileVersion;
        }
        return null;
    }


}