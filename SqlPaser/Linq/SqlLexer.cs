using SqlPaser.Linq.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlPaser.Linq
{
    /// <summary>
    /// 语法分析器
    /// </summary>
    public class SqlLexer
    {
        public string Source;
        public SqlLexer(string souce)
        { 
            Source = souce;
        }

        /// <summary>
        /// 解析为token
        /// </summary>
        /// <returns></returns>
        public List<SqlToken> Tokenize()
        {
            return null;
        }
    }
}
