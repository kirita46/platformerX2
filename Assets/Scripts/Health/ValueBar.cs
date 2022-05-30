using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ValueBar : MonoBehaviour
{
    [SerializeField] private List<Image> _values;

    public void SetValue(int health)
    {
        for (int i = 0; i < _values.Count; i++)
        {
            _values[i].gameObject.SetActive(i < health);
        }
    }
}