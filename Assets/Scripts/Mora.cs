using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Mora : MonoBehaviour, ITouchable
    {

        private MoraModel _moraModel;

        private void Start()
        {
            _moraModel = FindObjectOfType<MoraModel>();
        }

        public void OnTouch(Player player)
        {
            _moraModel.Increment();
            Destroy(gameObject);
        }
    }
}