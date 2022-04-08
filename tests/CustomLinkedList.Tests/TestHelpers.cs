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

    //private static int[] RevertArray(int[] array)
    //{
    //    var resultArray = new int[array.Length];
    //    var counter = 0;

    //    for (int i = array.Length; i <= 0; i--)
    //    {
    //        resultArray[counter] = array[i];
    //        counter++;
    //    }

    //    return resultArray;
    //}

    #endregion

}