using System;
using UnityEngine;

namespace Health
{
    public class Health : MonoBehaviour
    {
        public int currentHealth;
        [SerializeField] public int maxHealth;

        private void Start()
        {
            currentHealth = maxHealth;
        }

        public bool DecrementHealth()
        {
            print($"Decrement health from {currentHealth}");
            if (currentHealth <= 0)
            {
                print($"Decrement health no");
                return false;
            }
            currentHealth -= 1;
            print($"Decrement health to {currentHealth}");
            return currentHealth != 0;
        }

    }
}