namespace MonoGameGame
{
    internal class Basic2D
    {
        public Vector2 Pos, Dims;
        public Texture2D MyTexture;


        public Basic2D(string path, Vector2 pos, Vector2 dims)
        {
            Pos = pos;
            Dims = dims;
            MyTexture = GlContent.Load<Texture2D>(path);
        }

        public virtual void Update(float delta)
        {

        }

        public virtual void Draw()
        {
            if (MyTexture != null)
            {
                GlSBatch.Draw(MyTexture, new Rectangle((int)Pos.X, (int)Pos.Y, (int)Dims.X, (int)Dims.Y), null, Color.White, 0.0f, new Vector2(MyTexture.Bounds.Width / 2, MyTexture.Bounds.Height / 2), new SpriteEffects(), 0);
            }
        }
    }
}
