using UnityEngine;

namespace SuriviveProject
{
    public abstract class TargetFollowerController : MonoBehaviour, IController, IInitializable<TargetArg>
    {

        [SerializeField] private float distanceOfReaching = 0.25f;
        [SerializeField] private IMovable movable;

        private TargetArg arg;

        protected Vector2 Direction 
        {
            get
            {
                return (arg.target.position - transform.position).normalized;
            }
        }

        protected float Distance
        {
            get
            {
                return (transform.position - arg.target.position).magnitude;
            }
        }

        protected bool IsReached
        {
            get
            {
                return Distance <= distanceOfReaching;
            }
        }
        public void Initialize(TargetArg args)
        {
            arg = args;
            movable = GetComponent<IMovable>();
        }

        protected void ReachTarget(float speed = 1f, Space space = Space.Self)
        {
            if (IsReached)
            {
                return;
            }
            movable.Move(Direction * speed, space);
        }
    }
}
