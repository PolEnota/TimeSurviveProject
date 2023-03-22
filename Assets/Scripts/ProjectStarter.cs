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

        public void Awake()
        {
            spawner = mainGrid.InitGrid(Vector2Int.zero);
            entityFactory = gameObject.AddComponent<PlayerFactory>();
            entityFactory.Initialize(new PlayerFactoryArg() { gridSpawner = spawner, inputEvents = inputEvents });
            entityFactory.SpawnEntity(entityLib.PlayerEntity, mainGrid.Center);
        }
    }
}

