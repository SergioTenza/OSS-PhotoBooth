using System;

namespace PhotoBooth.Contracts.Services
{
    public interface IPageService
    {
        Type GetPageType(string key);
    }
}
