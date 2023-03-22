using UnityEngine;

namespace SuriviveProject.Configs
{
    [CreateAssetMenu(fileName = nameof(EntityConfig), menuName = nameof(Configs) + "/" +  nameof(EntityConfig))]
    public class EntityLib : ScriptableObject
    {
        [SerializeField]
        private EntityConfig _playerEntityConfig;

        public EntityConfig PlayerEntity
        {
            get
            {
                return _playerEntityConfig;
            }

        }
    }
}

