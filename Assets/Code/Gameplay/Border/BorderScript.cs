namespace Code.Gameplay.Border
{
    public class BorderScript : CollisionObject
    {
        protected override void Start()
        {
            base.Start();
            CollisionEndsGame = true;
        }
    }
}
