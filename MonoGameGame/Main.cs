using Microsoft.Xna.Framework.Input;

namespace MonoGameGame
{
    public class Main : Game
    {
        public static Rectangle ViewportBounds;

        private GraphicsDeviceManager _graphics;

        SpriteFont _font;

        private World _world;

        public Main() : base()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsFixedTimeStep = true;
            IsMouseVisible = true;

        }

        protected override void Initialize()
        {
            ViewportBounds = GraphicsDevice.Viewport.Bounds;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            GlContent = Content;
            GlSBatch = new SpriteBatch(GraphicsDevice);


            _font = Content.Load<SpriteFont>("Fonts/Arial12");
            _world = new World();
            base.LoadContent();
        }

        protected override void UnloadContent()
        {
            base.UnloadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            float delta = (float)gameTime.ElapsedGameTime.TotalSeconds;
            _world.Update(delta);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            GlSBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp);
            GlSBatch.DrawString(_font, "Hello World!", new Vector2(0, 0), Color.White);
            _world.Draw();
            GlSBatch.End();
            base.Draw(gameTime);
        }
    }
}
