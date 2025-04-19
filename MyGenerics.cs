namespace test;

public class MyList<T>
{
    private List<T> _list;
    private int _limit;

    public MyList(int limit)
    {
        _limit = limit;
        _list = new List<T>();
    }

    // public void Add(T element)
    // {
    // 	if (_list.Count < _limit)
    // 	{
    //         _list.Add(element);
    //     }
    // }

    public string GetContent()
    {
        string content = "";
	foreach (var element in _list) {
            content += element + ", ";
        }
        return content;
    }
}
