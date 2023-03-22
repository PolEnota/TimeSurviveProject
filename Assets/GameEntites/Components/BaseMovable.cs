using UnityEngine;

namespace SuriviveProject
{
    public class BaseMovable : MonoBehaviour,  IMovable
    {
        public void Move(Vector2 translation, Space space = Space.Self)
        {
            transform.Translate(translation, space);
        }
    }
}
