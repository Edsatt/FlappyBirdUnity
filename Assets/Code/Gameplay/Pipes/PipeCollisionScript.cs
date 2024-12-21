namespace Code.Gameplay.Pipes
{
    public class PipeCollisionScript : CollisionObject
    {
        protected override void Start()
        {
            base.Start();
            CollisionEndsGame = true;
        }
    }
}