using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SourceCnt
{
    public class FileCollector
    {
        public List<FileReader> files = new List<FileReader>();

        public CountInfo GetTotalCountInfo()
        {
            return GetCountInfo(true, "");
        }

        public CountInfo GetCountInfo(string fileType)
        {
            return GetCountInfo(false, fileType);
        }

        /// <summary>
        /// 统计整个项目的信息
        /// </summary>
        /// <param name="flag">true：fileType条件无效</param>
        /// <param name="fileType">文件类型</param>
        /// <returns></returns>
        public CountInfo GetCountInfo(bool flag, string fileType)
        {
            CountInfo rtnParam = new CountInfo();

            string type = "";
            if (flag)
            {
                rtnParam.fileType = "总计";
            }
            else
            {
                rtnParam.fileType = fileType;
                type = fileType.Split(".".ToCharArray())[1];
            }

            foreach (FileReader fr in files)
            {
                if (flag || fr.fileName.EndsWith(type, StringComparison.CurrentCultureIgnoreCase))
                {
                    rtnParam.blankCnt = rtnParam.blankCnt + fr.blankCnt;
                    rtnParam.commentCnt = rtnParam.commentCnt + fr.commentCnt;
                    rtnParam.effectiveCnt = rtnParam.effectiveCnt + fr.effectiveCnt;
                    rtnParam.totalCnt = rtnParam.totalCnt + fr.totalCnt;
                }
            }

            return rtnParam;
        }
    }

    public class CountInfo
    {
        // 文件类型
        public string fileType = "";
        // 实际行数
        public int effectiveCnt = 0;
        // 注释行数
        public int commentCnt = 0;
        // 空白行数
        public int blankCnt = 0;
        // 总行数
        public int totalCnt = 0;
    }
}
