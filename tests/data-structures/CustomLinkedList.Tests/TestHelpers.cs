using CustomLinkedList.Models;
using System;

namespace CustomLinkedList.Tests;

/// <summary>
/// Класс для вспомогательных методов, для упрощения кода тестов
/// </summary>
public static class TestHelpers
{

    #region Help Methods

    public static MyLinkedList CreateLinkedListFromArray(int[] array)
    {
        
        var list = new MyLinkedList();

        Array.Reverse(array);

        foreach (var item in array)
        {
            list.AddAtHead(item);
        }

        return list;
    }

    #endregion

}