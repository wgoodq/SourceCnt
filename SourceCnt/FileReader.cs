using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SourceCnt
{
    public class FileReader
    {
        // 文件路径
        public string filePath = "";
        // 文件名
        public string fileName = "";
        // 实际行数
        public int effectiveCnt = 0;
        // 注释行数
        public int commentCnt = 0;
        // 空白行数
        public int blankCnt = 0;
        // 总行数
        public int totalCnt = 0;

        public FileReader(FileInfo fileInfo)
        {
            filePath = fileInfo.FullName;
            fileName = fileInfo.Name;

            analyse();
        }

        /// <summary>
        /// 解析文件。
        /// </summary>
        public void analyse()
        {
            StreamReader streamReader = new StreamReader(filePath,Encoding.UTF8);
            
            string line = "";

            // 用于标识是否处于注释内
            bool inCommentFlag = false;
            
            while ((line = streamReader.ReadLine()) != null)
            {
                line = line.Trim();

                // 统计总行数
                totalCnt++;

                if (inCommentFlag)
                {
                    commentCnt++;
                    if (line.Contains(@"*/"))
                    {
                        inCommentFlag = false;
                    }
                }
                else
                {
                    if (line.Equals(""))
                    {
                        // 空白行
                        blankCnt++;
                    }
                    else if (line.StartsWith(@"//"))
                    {
                        // 单行注释
                        commentCnt++;
                    }
                    else if (line.Contains(@"/*"))
                    {
                        // 多行注释
                        commentCnt++;

                        // 本行不含有终止符,才是多行注释。
                        if (!line.Contains(@"*/"))
                        {
                            inCommentFlag = true; 
                        }
                    }
                    else
                    {
                        // 有效代码行数
                        effectiveCnt++;
                    }
                }
            }
        }
    }
}