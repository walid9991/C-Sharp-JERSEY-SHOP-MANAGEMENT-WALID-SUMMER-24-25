using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace WFA_Sample_A
{
    class DataAccess
    {
        private SqlConnection sqlcon = null!;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand? sqlcom;
        public SqlCommand? Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter? sda;
        public SqlDataAdapter? Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet? ds;
        public DataSet? Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        public DataAccess()
        {
            this.Sqlcon = new SqlConnection(@"Server=ROHAN\SQLEXPRESS;Database=JERSEY SHOP;User Id=sa;Password=rohan;Encrypt=False;TrustServerCertificate=True;");
            this.Sqlcon.Open();
        }

        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }

        public DataTable ExecuteQueryTable(string sql)
        {
            try
            {
                this.QueryText(sql);
                this.Sda = new SqlDataAdapter(this.Sqlcom);
                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds);

                if (this.Ds.Tables.Count > 0)
                {
                    return this.Ds.Tables[0];
                }
                else
                {
                    return new DataTable();
                }
            }
            catch (Exception)
            {
                return new DataTable(); // Return empty table instead of null
            }
        }
        private void QueryText(string query, params SqlParameter[] parameters)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
            if (parameters != null && parameters.Length > 0)
            {
                this.Sqlcom.Parameters.AddRange(parameters);
            }
        }
        public int ExecuteDMLQuery(string sql, params SqlParameter[] parameters)
        {
            this.QueryText(sql, parameters);
            return this.Sqlcom.ExecuteNonQuery();
        }

        public int ExecuteUpdateQuery(string sql)
        {
            this.QueryText(sql);
            return this.Sqlcom!.ExecuteNonQuery();
        }
        public object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            this.QueryText(sql, parameters);
            return this.Sqlcom.ExecuteScalar();
        }
        public DataSet ExecuteQuery(string sql, params SqlParameter[] parameters)
        {
            this.QueryText(sql, parameters);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds;
        }
        public int ExecuteParameterizedQuery(string sql, SqlParameter[] parameters)
        {
            try
            {
                this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
                if (parameters != null)
                {
                    this.Sqlcom.Parameters.AddRange(parameters);
                }
                return this.Sqlcom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
                return 0;
            }
        }
        public DataTable ExecuteParameterizedQueryTable(string sql, SqlParameter[] parameters)
        {
            try
            {
                this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
                if (parameters != null && parameters.Length > 0)
                {
                    this.Sqlcom.Parameters.AddRange(parameters);
                }

                this.Sda = new SqlDataAdapter(this.Sqlcom);
                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds);

                if (this.Ds.Tables.Count > 0)
                {
                    return this.Ds.Tables[0];
                }
                else
                {
                    return new DataTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
                return new DataTable();
            }
        }
        public DataTable ExecuteQueryTable(string sql, SqlParameter[] parameters)
        {
            try
            {
                this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
                if (parameters != null && parameters.Length > 0)
                {
                    this.Sqlcom.Parameters.AddRange(parameters);
                }

                this.Sda = new SqlDataAdapter(this.Sqlcom);
                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds);

                if (this.Ds.Tables.Count > 0)
                {
                    return this.Ds.Tables[0];
                }
                else
                {
                    return new DataTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
                return new DataTable();
            }
        }

    }
}


