﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using emCommon;
using emModel;
using System.Data;
using System.Data.SqlClient;

namespace emDAL
{
    public class EmService
    {
        public static List<em> GetShow() {
            List<em> list = new List<em>();
            string sql = "SELECT*FROM dbo.em";
            SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, sql, null);
            while (dr.Read())
            {
                em e = new em();
                e.Name = dr["Name"].ToString();
                e.Age = Convert.ToInt32(dr["Age"]);
                e.EmType = dr["EmType"].ToString();
                list.Add(e);

            }

            return list;
        }

        public static int AddEm(em e) {
            string sql = @"INSERT INTO dbo.em
                           ( name, age, emtype )
                            VALUES  (@name,
                                     @age, 
                                     @emtype   )";

            SqlParameter[] pa = new SqlParameter[] {
                new SqlParameter("@name",e.Name),
                new SqlParameter("@age",e.Age),
                new SqlParameter("@emtype",e.EmType)
            };

            int num = SqlHelper.ExecuteNonQuery(CommandType.Text,sql,pa);
            return num;
        }


        public static int DeleteEm(em e) {
            string sql = "DELETE FROM dbo.em WHERE name=@name";
            SqlParameter[] pa = new SqlParameter[] {
                new SqlParameter("@name",e.Name)
        }; 
            return SqlHelper.ExecuteNonQuery(CommandType.Text,sql,pa);
        }
    }
}
