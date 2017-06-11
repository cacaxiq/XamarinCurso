using System;
using Organizacao.Models;
namespace Organizacao.Services
{
    public class ItemStore : CloudDataStore<Item>,IDataStore<Item>
    {
    }
}
