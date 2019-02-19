using System.IO;
using System.Text;

namespace SourceCnt
{
    public class FileWriter
    {
        // 被创建文件的全路径
        public string filePath = "";

        // 默认结果输出文件名
        private static string defaultFileName = "LineCount";
        // 重复文件名后缀编号
        private static int numb = 0;
        private StreamWriter streamWriter;
        // 被创建文件所在文件夹路径
        private static string folderPath = "";

        public FileWriter(string rootPath)
        {
            folderPath = rootPath;
            GetFileFullName(defaultFileName);
            streamWriter = new StreamWriter(filePath, true, Encoding.UTF8);
            WriteHeader();
        }

        public void WriteHeader()
        {
            streamWriter.WriteLine("文件名,实际行数,注释行数,空白行数,总行数,文件路径");
        }

        public void WriteLine(FileReader fs)
        {
            string line = string.Format("{0},{1},{2},{3},{4},{5}", fs.fileName, fs.effectiveCnt, fs.commentCnt, fs.blankCnt, fs.totalCnt, fs.filePath);
            streamWriter.WriteLine(line);
        }

        public void WriteLine(string line)
        {
            streamWriter.WriteLine(line);
        }

        public void WriteFooter(FileCollector fileCollector, string[] fileTypes)
        {
            streamWriter.WriteLine();
            streamWriter.WriteLine(",总实际行数,总注释行数,总空白行数,总行数");

            CountInfo ci;
            string line;

            if (fileTypes.Length > 1)
            {
                foreach (string fileType in fileTypes)
                {
                    ci = fileCollector.GetCountInfo(fileType);
                    line = string.Format("{0},{1},{2},{3},{4}", ci.fileType, ci.effectiveCnt, ci.commentCnt, ci.blankCnt, ci.totalCnt);
                    streamWriter.WriteLine(line);
                }
            }

            ci = fileCollector.GetTotalCountInfo();
            line = string.Format("{0},{1},{2},{3},{4}", ci.fileType, ci.effectiveCnt, ci.commentCnt, ci.blankCnt, ci.totalCnt);
            streamWriter.WriteLine(line);

        }

        public void Close()
        {
            streamWriter.Close();
        }

        /// <summary>
        /// 校验输出目标文件是否存在,若存在，则在文件夹名称后面追加序号，以作区别。
        /// </summary>
        /// <param name="fileName">输出结果的文件名</param>
        private void GetFileFullName(string fileName)
        {
            filePath = string.Format(@"{0}\{1}.csv", folderPath, fileName);

            // 验证输出目标文件是否存在,若存在，则在文件夹名称后面追加序号，以作区别。
            if (File.Exists(filePath))
            {
                numb++;
                GetFileFullName(string.Format("{0}({1})", defaultFileName, numb));
            }
        }
    }
}