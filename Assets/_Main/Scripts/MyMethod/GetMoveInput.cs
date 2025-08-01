using UnityEngine;

namespace _Main.Scripts.MyMethod
{
    [RequireComponent(typeof(RawMovement))]
    public class GetMoveInput : MonoBehaviour
    {
        private Vector2 _input;
        [SerializeField] private RawMovement rawMovement;
    
        void Update()
        {
            _input.x = Input.GetAxis("Horizontal");
            _input.y = Input.GetAxis("Vertical");
            rawMovement.SetMovement(_input);
        }
    }
}
