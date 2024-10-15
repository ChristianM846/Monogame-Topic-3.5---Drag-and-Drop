using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Topic_3._5___Drag_and_Drop
{
    //Christian Moyes
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        bool isDraggingAsteroid;
        bool isDraggingCar;
        bool isDraggingRocket;

        MouseState mouseState;
        MouseState prevMouseState;

        Texture2D asteroidTexture;
        Rectangle asteroidRect;

        Texture2D carTexture;
        Rectangle carRect;

        Texture2D rocketTexture;
        Rectangle rocketRect;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            asteroidRect = new Rectangle(10, 10, 50, 50);
            isDraggingAsteroid = false;

            carRect = new Rectangle(200, 200, 75, 25);
            isDraggingCar = false;

            rocketRect = new Rectangle(400, 100, 40, 75);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            asteroidTexture = Content.Load<Texture2D>("Images/asteroid");
            carTexture = Content.Load<Texture2D>("Images/fast_car");
            rocketTexture = Content.Load<Texture2D>("Images/rocket");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            mouseState = Mouse.GetState();








            prevMouseState = mouseState;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            _spriteBatch.Draw(asteroidTexture, asteroidRect, Color.White);
            _spriteBatch.Draw(carTexture, carRect, Color.White);
            _spriteBatch.Draw(rocketTexture, rocketRect, Color.White);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
