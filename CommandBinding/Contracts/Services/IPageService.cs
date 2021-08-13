using System;

namespace CommandBinding.Contracts.Services
{
    public interface IPageService
    {
        Type GetPageType(string key);
    }
}
