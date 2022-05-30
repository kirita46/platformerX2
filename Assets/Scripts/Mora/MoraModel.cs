using System;
using UnityEngine;
using UnityEngine.Serialization;

public class MoraModel : MonoBehaviour
{

    [SerializeField]
    private bool loadMoraFromSave;
    public int currentMora;

    private void Start()
    {
        if (loadMoraFromSave)
        {
            currentMora = PlayerPrefs.GetInt("last_mora", 0);
        }
    }

    public void Increment()
    {
        currentMora += 1;
    }


    private void OnDestroy()
    {
        PlayerPrefs.SetInt("last_mora", currentMora);
        PlayerPrefs.Save();
    }
}