using UnityEngine;

namespace _Main.Scripts.MyMethods
{
    [RequireComponent(typeof(GetMoveInput))]
    [RequireComponent(typeof(Rigidbody))]
    public class RawMovement : MonoBehaviour
    {
        private Vector2 _movement;
        [SerializeField] private float speed = 5f;
        private Rigidbody _rb;
        private GetMoveInput _moveInput;
    
        void Start()
        {
            _rb = GetComponent<Rigidbody>();
            _moveInput = GetComponent<GetMoveInput>();
        }

        void Update()
        {
            _movement = _moveInput.GetInput();
            //_rb.transform.Translate(_movement.x * speed, 0, 0); -- no
            //_rb.linearVelocity = _movement * (speed * Time.deltaTime); -- pega saltos y se devuelve
            _rb.AddForce(_movement * speed);// Resultado mejor, pero tiene efecto piso helado, subiendo la masa del RB mejora el efecto.
        }
    }
}
