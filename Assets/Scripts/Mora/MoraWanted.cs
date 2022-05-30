
    using UnityEngine;
    using UnityEngine.UI;

    public class MoraWanted: MonoBehaviour
    {

        [SerializeField] private Text mora;

        public void SetMora(int value)
        {
            mora.text = $"Собранная мора: {value}";
        }

    }