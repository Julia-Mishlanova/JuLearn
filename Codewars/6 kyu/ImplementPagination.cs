using System;
using System.Collections.Generic;
using System.Linq;

public class Pagination<T>
{
    public static List<T> symbols = new List<T>();
    public IEnumerable<T> Items
    {
        get
        {
            if (CurrentPage > TotalPages)
                return Enumerable.Empty<T>();
            List<T> list = new List<T>();

            int end = CurrentPage * ItemsPerPage;
            int start = end - ItemsPerPage;

            for (int i = start; i < end; i++)
            {
                if (i == symbols.Count)
                    break;
                list.Add(symbols[i]);
            }

            return list;
        }
    }

    private int _currentPage;
    public int CurrentPage
    {
        get { return _currentPage; }
        set
        {
            if (value <= 0)
            {
                _currentPage = 1;
                return;
            }

            _currentPage = value;
        }
    }

    private int _itemsPerPage;
    public int ItemsPerPage
    {
        get { return _itemsPerPage; }
        set
        {
            if (value <= 0)
            {
                _itemsPerPage = 10;
                return;
            }
            _itemsPerPage = value;
        }
    }

    public int Total
    {
        get { return symbols.Count; }
    }
    public int TotalPages
    {
        get
        {
            int pages = 0;
            for (int i = 0; i <= Total; i += _itemsPerPage)
            {
                if (i % _itemsPerPage == 0)
                    pages++;
            }
            return pages;
        }
    }

    public Pagination()
    {
        ItemsPerPage = 10;
        CurrentPage = 1;
        symbols = new List<T>();
    }

    public Pagination(IEnumerable<T> source)
    {
        ItemsPerPage = 10;
        CurrentPage = 1;
        symbols = source.ToList();
    }
}
