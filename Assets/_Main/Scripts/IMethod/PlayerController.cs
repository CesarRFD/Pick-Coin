using UnityEngine;

namespace _Main.Scripts.IMethod
{
    [RequireComponent(typeof(MovementController))]
    [RequireComponent(typeof(PlayerInputProvider))]
    public class PlayerController : MonoBehaviour
    {
        void Start()
        {
            // Obtener las referencias a los componentes necesarios
            MovementController movement = GetComponent<MovementController>();
            PlayerInputProvider inputProvider = GetComponent<PlayerInputProvider>();

            // Inyectar el proveedor de input al controlador de movimiento
            movement.SetInputProvider(inputProvider);
        }
    }
}