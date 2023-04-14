using System;
using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    // TODO: Получите доступ ко всем объектам сцены со скриптом Lamp
    // TODO: При нажатии на кнопку 2 на клавиатуре вызывайте у всех полученных объектов метод Interact
    private Lamp[] _lamps;
    
    private void Start()
    {
        _lamps = FindObjectsOfType<Lamp>();
    }

    private void Update()
    {
        for (int i = 0; i < _lamps.Length; i++)
        {
            if (Input.GetKey(KeyCode.Alpha2))
            {
                _lamps[i].Interact();
            }
        }
    }
}