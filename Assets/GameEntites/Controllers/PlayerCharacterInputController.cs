using UnityEngine;

namespace SuriviveProject
{
    public class PlayerCharacterInputController : MonoBehaviour, IInitializable<PlayerCharacterContollerIntializeArg>, IController
    {
        private IMovable movable;

        public void Initialize(PlayerCharacterContollerIntializeArg arg)
        {
            movable = GetComponent<IMovable>();
            arg.inputEvents.OnHorizontalAxis += OnHorizontalAxis;
            arg.inputEvents.OnVerticalAxis += OnVerticalAxis;
        }

        private void OnHorizontalAxis(float value)
        {
            MoveCharacter(Vector2.right * value);
        }

        private void OnVerticalAxis(float value)
        {
            MoveCharacter(Vector2.up * value);
        }

        private void MoveCharacter(Vector2 direction)
        {
            movable.Move(direction * Time.deltaTime);
        }
    }
}
