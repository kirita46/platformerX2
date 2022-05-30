using System;
using UnityEngine;

public class MoraInWantedController : MonoBehaviour
{
    [SerializeField] private MoraModel model;

    [SerializeField] private MoraWanted mora;

    private void Start()
    {
        mora.SetMora(model.currentMora);
    }
}