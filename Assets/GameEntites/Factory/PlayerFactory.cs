using SuriviveProject.Configs;
using UnityEngine;

namespace SuriviveProject
{
    public class PlayerFactory : EntityFactory<PlayerFactoryArg>
    {
        private DefaultCharacter character;
        private CharacterMovable characterMovable;
        private PlayerCharacterInputController inputController;

        public override void ProceedSpawning(GameObject entity, EntityConfig entityConfig)
        {
            character = entity.AddComponent<DefaultCharacter>();
            characterMovable = entity.AddComponent<CharacterMovable>(); ;
            inputController = entity.AddComponent<PlayerCharacterInputController>();
            characterMovable.Initialize();
            character.Init(entityConfig.mainStats);
            inputController.Initialize(new PlayerCharacterContollerIntializeArg(entityFactoryInitializeArg.inputEvents));
        }
    }
}

