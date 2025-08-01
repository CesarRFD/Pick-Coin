using UnityEngine;

namespace _Main.Scripts.MyMethod
{
    public class RawMovement : MonoBehaviour
    {
        private Vector2 _movement;
        [SerializeField] private float speed = 5f;
        private Rigidbody _rb;
    
        void Start()
        {
            _rb = GetComponent<Rigidbody>();
        }

        void Update()
        {
            _rb.linearVelocity = new Vector2(_movement.x, _movement.y) * speed;
        }

        public void SetMovement(Vector2 movement)
        {
            _movement = movement;
        }
    }
}
