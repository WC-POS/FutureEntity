
namespace FutureEntity.Future.Util;
using FutureEntity.Future.Registry;
using System.Xml;

public static class DBInfo{

    public static bool Exists(){
        if(Entries.GetInstallationPath(out string? installPath)){
            string dbInfoPath = installPath! +"\\data\\dbinfo.xml";
            return File.Exists(dbInfoPath);
        }
        return false;
    }

    public static string? GetServerName(){
        if(Exists()){
            string dbInfoPath = path +"\\data\\dbinfo.xml";
            if(File.Exists(dbInfoPath)){
                XmlDocument doc = new XmlDocument();
                doc.Load(dbInfoPath);
            }
        }
        return null;
    }

    public static string? GetInstancename(){
        return null;
    }

}