using System;
using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs)
    [SerializeField] private GameObject _waffle;
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private Toaster _toaster;

    private void Start()
    {
        _toaster.TimerIsUp += CreateWaffle;
    }

    private GameObject CreateWaffle()
    {
        return Instantiate(_waffle, _spawnPosition);
    }
}