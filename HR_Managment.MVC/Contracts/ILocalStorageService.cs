namespace HR_Managment.MVC.Contracts
{
    public interface  ILocalStorageService
    {
        void ClearStorage(List<string>Keys);
        bool Exists(string key);
        T GetStorageValue<T>(string key);
        void SetStorageValue<T>(string key, T value);
    }
}
