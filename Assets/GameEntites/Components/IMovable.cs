using UnityEngine;

namespace SuriviveProject
{
    public interface IMovable
    {
        public void Move(Vector2 translation, Space space = Space.Self);
    }
}
