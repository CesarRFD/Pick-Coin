using UnityEngine;

namespace _Main.Scripts.MyMethods
{
    public class GetMoveInput : MonoBehaviour
    {
        private Vector2 _input;
        [SerializeField] private RawMovement rawMovement;

        void Update()
        {
            _input.x = Input.GetAxisRaw("Horizontal");
            _input.y = Input.GetAxisRaw("Vertical");
        }
        
        public Vector2 GetInput()
        {
            return _input;
        }
    }
}
