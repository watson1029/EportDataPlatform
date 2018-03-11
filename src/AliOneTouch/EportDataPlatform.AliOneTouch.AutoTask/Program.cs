using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace EportDataPlatform.AliOneTouch.AutoTask
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccess.DataBase.AliDataCaptureDa da = new DataAccess.DataBase.AliDataCaptureDa();
            List<string> fileList = da.GetOneTouchList();
            string date = DateTime.Now.ToString("yyyyMMddHH");
            string dir = Watson.Base.DotNetCore.ConfigurationHelper.Configuration.GetSection("XmlSavePath").ToString() + date;
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            //导出Xml
            foreach (string f_name in fileList)
            {
                try
                {
                    string filename = dir + "/" + f_name + ".xml";
                    Entity.Interface.AliApi.Entry entry = new Entity.Interface.AliApi.Entry();
                    entry.EntryHead = da.GetEntryHead(f_name);
                    entry.EntryLists.EntryList = da.GetEntryList(f_name);
                    GenerationXML(entry, filename);
                }
                catch (Exception ex)
                {
                    Watson.Base.DotNetCore.LogHelper.WriteFile(f_name + ".xml生成失败!", ex.ToString());
                }
            }

            //压缩
            try
            {
                using (ZipFile zip = new ZipFile(Encoding.UTF8))
                {
                    zip.AddDirectory(dir); // recurses subdirectories
                    string zipPath = dir + ".zip";
                    zip.Save(zipPath);
                }
            }
            catch (Exception ex)
            {
                Watson.Base.DotNetCore.LogHelper.WriteFile("压缩失败!", ex.ToString());
            }

            //IO
            try
            {
                File.Copy(dir + ".zip", Watson.Base.DotNetCore.ConfigurationHelper.Configuration.GetSection("ZipSavePath") + date + ".zip");
                Directory.Delete(dir);
            }
            catch (Exception ex)
            {
                Watson.Base.DotNetCore.LogHelper.WriteFile("复制文件失败!", ex.ToString());
            }
        }

        public static bool GenerationXML(object obj, string path)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(obj.GetType());
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    xs.Serialize(fs, obj);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("生成" + obj.GetType().ToString() + "XML失败!" + ex.ToString());
            }
        }
    }
}
