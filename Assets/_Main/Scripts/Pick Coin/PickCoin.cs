using TMPro;
using UnityEngine;

namespace _Main.Scripts.Pick_Coin
{
    public class PickCoin : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI textfield;
        private int _coins = 0;
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Coin")
            {
                Destroy(other.gameObject);
                _coins++;
                textfield.text = "Coins: " + _coins;
            }
        }
    }
}