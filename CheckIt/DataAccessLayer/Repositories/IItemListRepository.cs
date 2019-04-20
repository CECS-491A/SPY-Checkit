﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIt.DataAccessLayer.Repositories
{
    public interface IItemListRepository
    {
        ItemList GetItemList(Guid userID, Guid itemID);
        List<Item> GetItemsByUserID(Guid userID);

        void AddItemList(ItemList itemlist);
        void RemoveItemList(ItemList itemlist);
        void RemoveItemList(Guid userID, Guid itemID);
    }
}
