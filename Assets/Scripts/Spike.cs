using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class Spike : MonoBehaviour, ITouchable
    {
        private Health.Health _health;

        private void Start()
        {
            _health = FindObjectOfType<Health.Health>();
        }

        public void OnTouch(Player player)
        {
            var isDied = !_health.DecrementHealth();
            if (isDied)
                SceneManager.LoadScene("wanted");
        }
    }
}