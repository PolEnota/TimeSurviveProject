namespace SuriviveProject
{
    public class PlayerCharacterContollerIntializeArg : InitializeArgs
    {
        public readonly InputEvents inputEvents;

        public PlayerCharacterContollerIntializeArg(InputEvents input)
        {
            inputEvents = input;
        }
    }
}

