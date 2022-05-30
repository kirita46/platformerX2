using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Health
{
    public class HealthInGameController : MonoBehaviour
    {
        [SerializeField]
        private Health _health;
        [SerializeField]
        private ValueBar valueBar;

        private void Start()
        {
            valueBar.SetValue(_health.maxHealth);
        }

        private void Update()
        {
            valueBar.SetValue(_health.currentHealth);
        }
        
    }
}