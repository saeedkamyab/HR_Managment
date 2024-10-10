using Hanssens.Net;
using HR_Managment.MVC.Contracts;

namespace HR_Managment.MVC.Services
{
    public class LocalStorageService : ILocalStorageService
    {
        private LocalStorage _storage;

        public LocalStorageService(LocalStorage storage)
        {
            _storage = storage;
            var config = new LocalStorageConfiguration()
            {
                AutoLoad = true,
                AutoSave = true,
                Filename = "HR.LEAVEMGMT"

            };
            _storage = new LocalStorage(config);

        }
        public void ClearStorage(List<string> Keys)
        {
            foreach (var key in Keys)
            {
                _storage.Remove(key);
            }
        }

        public bool Exists(string key)
        {
            return _storage.Exists(key);

        }

        public T GetStorageValue<T>(string key)
        {
            return _storage.Get<T>(key);
        }

        public void SetStorageValue<T>(string key, T value)
        {
            _storage.Store(key, value);
            _storage.Persist();
        }
    }
}
