using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinFormsAssessment.Models;

namespace XamarinFormsAssessment.Services
{
    public class DBService
    {
        private readonly SQLiteAsyncConnection database;

        public DBService(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Entry>().Wait();
        }

        public Task<List<Entry>> GetAllEntriesAsync()
        {
            return database.Table<Entry>().ToListAsync();
        }

        public Task<Entry> GetEntryAsync(int id)
        {
            return database.Table<Entry>().Where(i => i.EntryID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveEntryAsync(Entry entry)
        {
            return database.InsertAsync(entry);
        }

        public Task<int> DeleteEntryAsync(Entry entry)
        {  
            return database.DeleteAsync(entry); 
        }
    }
}