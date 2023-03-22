using UnityEngine;
using SuriviveProject.Configs;

namespace SuriviveProject
{
    public abstract class EntityFactory<T> : MonoBehaviour, IInitializable<T> where T : EntityFactoryInitializeArg 
    {
        protected GridSpawner gridSpawner => entityFactoryInitializeArg.gridSpawner;

        protected T entityFactoryInitializeArg; 

        public virtual void Initialize(T entityFactoryInitializeArg)
        {
            this.entityFactoryInitializeArg = entityFactoryInitializeArg;
        }

        public GameObject SpawnEntity(EntityConfig entityConfig, Vector2Int position)
        {
            GameObject spawned = Instantiate(entityConfig.prefab);
            gridSpawner.SetPosition(position, spawned);
            ProceedSpawning(spawned, entityConfig);
            return spawned;
        }

        public abstract void ProceedSpawning(GameObject entity, EntityConfig entityConfig);

    }
}

