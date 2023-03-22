using UnityEngine;

namespace SuriviveProject
{    
    public class DefaultCharacter : Character
    {
        private IMovable movable;

        public void Init(MainStats stats)
        {
            movable = GetComponent<IMovable>();
            this.mainStat = stats;
        }

        public void Move(Vector3 direction)
        {
            movable.Move(direction * Time.deltaTime, Space.World);
        }
    }
}

