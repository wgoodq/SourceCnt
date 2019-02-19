using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace SourceCnt
{
    public class RootFolder
    {
        // 统计对象根目录
        public string rootPath = "";
        // 统计对象文件类型
        public string[] fileTypes;

        public FileWriter fileWriter;
        public FileCollector fileCollector;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="path">目标文件夹</param>
        /// <param name="types">目标文件类型（示例：*.java;*.cs）</param>
        public RootFolder(string path, string types)
        {
            rootPath = path;
            if (types.EndsWith(";"))
            {
                types = types.TrimEnd(";".ToCharArray());
            }
            fileTypes = types.Split(";".ToCharArray());

            fileWriter = new FileWriter(rootPath);
            fileCollector = new FileCollector();
        }

        /// <summary>
        /// 对外入口
        /// </summary>
        /// <returns></returns>
        public string Init()
        {
            string rtnParam = "";
            try
            {
                foreach (string fileType in fileTypes)
                {
                    // 在目标文件夹内，逐层寻找目标文件进行统计。
                    ReadFile(fileType);
                }

                // 输出汇总信息。
                fileWriter.WriteFooter(fileCollector,fileTypes);

                // 关闭FileWriter
                fileWriter.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rtnParam;
        }

        /// <summary>
        /// 筛选指定文件夹内的指定类型文件
        /// </summary>
        /// <param name="folderPath"></param>
        /// <returns></returns>
        private string ReadFile(string fileType)
        {
            string rtnParam = "";

            // 创建根目录文件夹对象。
            DirectoryInfo directoryInfo = new DirectoryInfo(rootPath);

            // 统计当前文件夹及所有子目录内所有指定类型文件信息。
            foreach (FileInfo fileInfo in directoryInfo.GetFiles(fileType, SearchOption.AllDirectories))
            {
                FileReader fileReader = new FileReader(fileInfo);
                fileCollector.files.Add(fileReader);
                fileWriter.WriteLine(fileReader);
            }

            return rtnParam;
        }

        public string GetOutPutFilePath()
        {
            return fileWriter.filePath;
        }
    }
}