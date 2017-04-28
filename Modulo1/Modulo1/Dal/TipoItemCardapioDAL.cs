using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Modulo1.Modelo;
using System.Collections.ObjectModel;
using Modulo1.Infraestructure;

using SQLite.Net;

using Xamarin.Forms;

namespace Modulo1.Dal
{
    public class TipoItemCardapioDAL
    {
        private SQLiteConnection sqlConnection;

        public TipoItemCardapioDAL()
        {
            this.sqlConnection = DependencyService.Get<IDatabaseConnection>().DbConnection();
            this.sqlConnection.CreateTable<TipoItemCardapio>();
        }

        public IEnumerable<TipoItemCardapio> GetAll()
        {
            return (from t in sqlConnection.Table<TipoItemCardapio>() select t).OrderBy(i => i.Nome).ToList();
        }
               
        public TipoItemCardapio GetItemById(long id)
        {
            return sqlConnection.Table<TipoItemCardapio>().FirstOrDefault(t => t.TipoItemCardapioId == id);
        }

        public void DeleteById(long id)
        {
            sqlConnection.Delete<TipoItemCardapio>(id);
        }

        public void Add(TipoItemCardapio tipoItemCardapio)
        {
            sqlConnection.Insert(tipoItemCardapio);
        }

        public void Update(TipoItemCardapio tipoItemCardapio)
        {
            sqlConnection.Update(tipoItemCardapio);
        }
    }
}