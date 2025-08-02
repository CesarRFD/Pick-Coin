using UnityEngine;

namespace _Main.Scripts.MyMethods
{
    [RequireComponent(typeof(GetMoveInput))]
    public class PlayerInvert : MonoBehaviour
    {
        [SerializeField] private Transform player;
        private GetMoveInput _getMoveInput;

        private void Start()
        {
            player = GetComponent<Transform>();
            _getMoveInput = GetComponent<GetMoveInput>();
        }

        private void Update()
        {
            if (_getMoveInput.GetInput().x < 0)
            {
                player.transform.rotation = Quaternion.Euler(0, 270, 0);
            }
            else
            {
                player.transform.rotation = Quaternion.Euler(0, 90, 0);
            }
        }
    }
}