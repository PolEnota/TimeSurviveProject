namespace SuriviveProject
{
    public class InputEventsInitializeArg : InitializeArgs
    {
        public readonly InputEvents inputEvents;

        public InputEventsInitializeArg(InputEvents input)
        {
            inputEvents = input;
        }
    }
}

