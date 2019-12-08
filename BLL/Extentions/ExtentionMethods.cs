using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BLL.Extentions
{
    public static class ExtentionMethods
    {
        public static void UseNewSource<T>(this ObservableCollection<T> collection, IEnumerable<T> source)
        {
            collection.Clear();
            foreach (var c in source)
            {
                collection.Add(c);
            }
        }
    }
}
