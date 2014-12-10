using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace MySqlHeader
{
    [Serializable]
    public class ConnString
    {
        /// <summary>
        /// Sql���ݿ������ַ���
        /// </summary>
        private static string _MySqlConnStr = "server=192.168.8.156; user id=root; password=root; database=db_koip; pooling=false;charset=gb2312";
        //private static string _MySqlConnStr = "server=localhost; user id=root; password=ising_99; database=test; pooling=false;charset=gb2312";
       
        public ConnString()
        { }
        /// <summary>
        /// ���û��߻�ȡSql���ݿ������ַ���
        /// </summary>
        public string MySqlConnStr
        {
            get { return ConnString._MySqlConnStr; }
            set { ConnString._MySqlConnStr = value; }
        }
       

        /// <summary>
        /// ����Sql���ݿ������ַ����ľ�̬����
        /// </summary>
        /// <returns></returns>
        public static string GetMySqlConnStr(string strConnection)
        {
            if (!string.IsNullOrEmpty(strConnection))
                //return strConnection;
                return ConfigurationManager.ConnectionStrings[strConnection].ConnectionString.ToString();
            else
            return _MySqlConnStr;
            //if (!string.IsNullOrEmpty(strConnection))
            //{
            //    //return ConfigurationSettings.AppSettings[strConnection];
            //    return ConfigurationManager.ConnectionStrings[strConnection].ConnectionString.ToString();

            //}
            //else
            //{
            //    //return ConfigurationSettings.AppSettings["SqlConnectionString"];
            //    return ConfigurationManager.ConnectionStrings["ConnString_Sql"].ConnectionString.ToString();
            //}
        }
       
        
        
    }
}