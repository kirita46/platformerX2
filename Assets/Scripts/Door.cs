using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class Door: MonoBehaviour, ITouchable
    {

        [SerializeField] private string doorTarget;
        public void OnTouch(Player player)
        {
            SceneManager.LoadScene(doorTarget);
        }
    }
}