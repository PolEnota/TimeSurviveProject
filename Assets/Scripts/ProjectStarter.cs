using UnityEngine;
using SuriviveProject.Configs;

namespace SuriviveProject
{
    public class ProjectStarter : MonoBehaviour
    {
        [SerializeField]
        private Grid mainGrid;
        [SerializeField]
        private InputEvents inputEvents;
        [SerializeField]
        private EntityLib entityLib;

        private PlayerFactory entityFactory;
        private GridSpawner spawner;
        [SerializeField]
        private Camera gameCamera;

        public void Awake()
        {
            spawner = mainGrid.InitGrid(Vector2Int.zero);
            entityFactory = gameObject.AddComponent<PlayerFactory>();
            entityFactory.Initialize(new PlayerFactoryArg() { gridSpawner = spawner, inputEvents = inputEvents });
            GameObject player = entityFactory.SpawnEntity(entityLib.PlayerEntity, mainGrid.Center);
            CameraController cameraController = gameCamera.gameObject.AddComponent<CameraController>();
            cameraController.gameObject.AddComponent<BaseMovable>();
            cameraController.Initialize(new TargetArg() { target = player.transform });
        }
    }
}

