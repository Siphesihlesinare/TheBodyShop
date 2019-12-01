using SinareBodyApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SinareBodyApp.ShopData
{
    public class ShopDatabase
    {
        readonly SQLiteAsyncConnection database;

        public ShopDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Product>().Wait();
        }

        public Task<List<Product>> GetItemsAsync()
        {
            return database.Table<Product>().ToListAsync();
        }

        public Task<List<Product>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Product>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        }

        public Task<Product> GetItemAsync(int id)
        {
            return database.Table<Product>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Product item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Product item)
        {
            return database.DeleteAsync(item);
        }
    }
}

