using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class ConnectionDB
    {
       private string _strCon;
        private bool _check = false;
        private SqlConnection _connection;

        public SqlConnection Connection
        {
            get { return _connection; }
            set { _connection = value; }
        }

        private SqlCommand _command;

        public SqlCommand Command
        {
            get { return _command; }
            set { _command = value; }
        }

        private SqlDataAdapter _da;

        public SqlDataAdapter Da
        {
            get { return _da; }
            set { _da = value; }
        }

        private SqlDataReader _reader;

        public SqlDataReader Reader
        {
            get { return _reader; }
            set { _reader = value; }
        }

        public ConnectionDB(string _myStrConnection)
        {
            _strCon = _myStrConnection;
            _connection = new SqlConnection(_strCon);
        }

        public void CallStoredProcedureFromDB(string _myStoredProcedureName)
        {
            try
            {
                _connection.Open();
                _command = _connection.CreateCommand();
                _command.Connection = _connection;
                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = _myStoredProcedureName;
            }
            catch
            {
                throw;
            }
        }

    }
}
