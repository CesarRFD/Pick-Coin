using UnityEngine;

namespace _Main.Scripts.IMethod
{
    public class MovementController : MonoBehaviour
    {
        public float speed = 5.0f;
        public IMovementInputProvider inputProvider;
        
        private Rigidbody rb;

        void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        void Update()
        {
            if (inputProvider != null)
            {
                Vector2 input = inputProvider.GetMovementInput();
                rb.linearVelocity = input * speed;
            }
        }

        public void SetInputProvider(IMovementInputProvider provider)
        {
            inputProvider = provider;
        }
    }
}