using UnityEngine;

namespace _Main.Scripts.MyMethods
{
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(GetMoveInput))]
    public class PlayerAnimation : MonoBehaviour
    {
        private Animator _anim;
        private GetMoveInput _getMoveInput;
        private Vector2 _moveInput;

        private void Start()
        {
            _anim = GetComponent<Animator>();
            _getMoveInput = GetComponent<GetMoveInput>();
        }

        private void Update()
        {
            _moveInput = _getMoveInput.GetInput();
            switch (_moveInput.x)
            {
                case 0:
                    _anim.SetBool("Idle", true);
                    _anim.SetBool("Walk", false);
                    break;
                case > 0:
                    _anim.SetBool("Idle", false);
                    _anim.SetBool("Walk", true);
                    break;
                case < 0:
                    _anim.SetBool("Idle", false);
                    _anim.SetBool("Walk", true);
                    break;
            }
        }
    }
}
