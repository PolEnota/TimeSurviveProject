using UnityEngine;
namespace SuriviveProject
{
    public class CameraController : TargetFollowerController
    {
        [SerializeField] private float maxDistanceFromTarget;
        [SerializeField] private float cameraSpeed = 25f;

        public void LateUpdate()
        {
            ReachTarget(cameraSpeed * Time.deltaTime, Space.Self);
        }
    }
}
