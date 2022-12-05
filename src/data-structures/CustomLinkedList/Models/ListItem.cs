namespace CustomLinkedList.Models;

public class ListItem
{

    public ListItem()
    { }

    public ListItem(int data)
    {

        if (data < 0 || data > 1000)
        {
            throw new ArgumentException("Значение должно быть больше либо равно 0, а также меньше либо равно 1000");
        }
        
        if (data == null)
        {
            throw new ArgumentNullException(nameof(data));
        }

        Data = data;
    }

    public int Data { get; set; }

    public ListItem Next { get; set; }

    public override string ToString()
    {
        return $"{Data}";
    }

}