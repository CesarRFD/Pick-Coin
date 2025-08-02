using UnityEngine;

namespace _Main.Scripts.IMethod
{
    public class PlayerInputProvider : MonoBehaviour, IMovementInputProvider
    {
        public Vector2 GetMovementInput()
        {
            return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }

    }
}