using System;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены
    private Shelf[] _shelves;

    private void Start()
    {
        _shelves = FindObjectsOfType<Shelf>();
        Shelf.ItemSpawned += Fall;
    }
    
    private void Fall()
    {
        for (int i = 0; i < _shelves.Length; i++)
        {
            _shelves[i].Fall();
        }
    }
}