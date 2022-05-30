using System;
using UnityEngine;

public class MoraInGameController : MonoBehaviour
{
    [SerializeField] private MoraModel _moraModel;
    [SerializeField] private ValueBar _valueBar;

    private void Update()
    {
        _valueBar.SetValue(_moraModel.currentMora);
    }
}