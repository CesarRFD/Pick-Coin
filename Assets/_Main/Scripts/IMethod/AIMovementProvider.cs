using UnityEngine;

namespace _Main.Scripts.IMethod
{
    public class AIMovementProvider : MonoBehaviour, IMovementInputProvider
    {
        public Vector2 direction;

        public Vector2 GetMovementInput()
        {
            return direction.normalized;
        }

    }
}