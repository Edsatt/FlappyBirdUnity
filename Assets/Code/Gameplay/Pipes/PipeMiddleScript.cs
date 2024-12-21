namespace Code.Gameplay.Pipes
{
    public class PipeMiddleScript : CollisionObject
    {
        protected override void Start()
        {
            base.Start();
            CollisionIncreasesScore = true;
        }
    }
}
