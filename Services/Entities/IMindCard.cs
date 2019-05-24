namespace Services.Entities
{
    public interface IMindCard<T> : IEntity
    {
        int Level { get; set; }
        void LevelUp();
        void LevelDown();
        void Delete();
        void Update();
    }
}