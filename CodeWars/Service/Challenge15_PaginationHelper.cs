using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Service
{
    public class Challenge15_PaginationHelper<T>
    {
        //private readonly IList<T> _collection;
        //private readonly int _itemsPerPage;

        //// TODO: Complete this class

        ///// <summary>
        ///// Constructor, takes in a list of items and the number of items that fit within a single page
        ///// </summary>
        ///// <param name="collection">A list of items</param>
        ///// <param name="itemsPerPage">The number of items that fit within a single page</param>
        //public Challenge15_PaginationHelper(IList<T> collection, int itemsPerPage)
        //{
        //    this._collection = collection;
        //    this._itemsPerPage = itemsPerPage;
        //}

        ///// <summary>
        ///// The number of items within the collection
        ///// </summary>
        //public int ItemCount
        //{
        //    get
        //    {
        //        return _collection.Count;
        //    }
        //}

        ///// <summary>
        ///// The number of pages
        ///// </summary>
        //public int PageCount
        //{
        //    get
        //    {
        //        var result = _collection.Count % _itemsPerPage == 0 ? _collection.Count / _itemsPerPage : _collection.Count / _itemsPerPage + 1;

        //        return result;
        //    }
        //}


        ///// <summary>
        ///// Returns the number of items in the page at the given page index 
        ///// </summary>
        ///// <param name="pageIndex">The zero-based page index to get the number of items for</param>
        ///// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
        //public int PageItemCount(int pageIndex)
        //{
        //    if(pageIndex >= PageCount || pageIndex < 0)//out of range
        //    {
        //        return -1;
        //    }else if(pageIndex == PageCount-1)//last index
        //    {
        //        return _collection.Count % _itemsPerPage;
        //    }
        //    else//regular page
        //    {
        //        return _itemsPerPage;
        //    }

        //}

        ///// <summary>
        ///// Returns the page index of the page containing the item at the given item index.
        ///// </summary>
        ///// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
        ///// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
        //public int PageIndex(int itemIndex)
        //{
        //    if (itemIndex >= _collection.Count || itemIndex < 0)//out of range
        //    {
        //        return -1;
        //    }

        //    return itemIndex / _itemsPerPage;

        //}        //private readonly IList<T> _collection;
        //private readonly int _itemsPerPage;

        //// TODO: Complete this class

        ///// <summary>
        ///// Constructor, takes in a list of items and the number of items that fit within a single page
        ///// </summary>
        ///// <param name="collection">A list of items</param>
        ///// <param name="itemsPerPage">The number of items that fit within a single page</param>
        //public Challenge15_PaginationHelper(IList<T> collection, int itemsPerPage)
        //{
        //    this._collection = collection;
        //    this._itemsPerPage = itemsPerPage;
        //}

        ///// <summary>
        ///// The number of items within the collection
        ///// </summary>
        //public int ItemCount
        //{
        //    get
        //    {
        //        return _collection.Count;
        //    }
        //}

        ///// <summary>
        ///// The number of pages
        ///// </summary>
        //public int PageCount
        //{
        //    get
        //    {
        //        var result = _collection.Count % _itemsPerPage == 0 ? _collection.Count / _itemsPerPage : _collection.Count / _itemsPerPage + 1;

        //        return result;
        //    }
        //}


        ///// <summary>
        ///// Returns the number of items in the page at the given page index 
        ///// </summary>
        ///// <param name="pageIndex">The zero-based page index to get the number of items for</param>
        ///// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
        //public int PageItemCount(int pageIndex)
        //{
        //    if(pageIndex >= PageCount || pageIndex < 0)//out of range
        //    {
        //        return -1;
        //    }else if(pageIndex == PageCount-1)//last index
        //    {
        //        return _collection.Count % _itemsPerPage;
        //    }
        //    else//regular page
        //    {
        //        return _itemsPerPage;
        //    }

        //}

        ///// <summary>
        ///// Returns the page index of the page containing the item at the given item index.
        ///// </summary>
        ///// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
        ///// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
        //public int PageIndex(int itemIndex)
        //{
        //    if (itemIndex >= _collection.Count || itemIndex < 0)//out of range
        //    {
        //        return -1;
        //    }

        //    return itemIndex / _itemsPerPage;

        //}
    }
}
