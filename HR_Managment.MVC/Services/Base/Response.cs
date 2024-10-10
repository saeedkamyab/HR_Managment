﻿namespace HR_Managment.MVC.Services.Base
{
    public class Response<T>
    {
        public string Message { get; set; }
        public string ValidationErrors { get; set; }
        public T Data { get; set; }
        public bool Success { get; set; }
    }
}
