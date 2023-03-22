namespace SuriviveProject
{
    public interface IInitializable
    {
        public void Initialize();
    }

    public interface IInitializable<T> where T: InitializeArgs
    {
        public void Initialize(T args);
    }
}

