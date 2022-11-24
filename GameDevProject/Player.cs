using GameDevProject.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevProject
{
    internal class Player : IGameObject, Imoveable
    {

        private Texture2D _texture;
        public Vector2 Position { get; set; }
        public Vector2 Speed { get; set; }

        public Vector2 Acceleration { get; set; }
        public KeyboardReader InputReader { get; set; }

        //private Vector2 position;
        //private Vector2 speed;
        //public KeyboardReader inputReader;

        private MovementManager movementManager;
        Animation.Animation animation;

        public Player(Texture2D texture,KeyboardReader inputReader)
        {
            _texture = texture;
            this.InputReader = inputReader;
            this.Position = new Vector2(10, 10);
            this.Speed = new Vector2(1, 1);
            this.Acceleration = new Vector2(0.1f, 0.1f);
            movementManager = new MovementManager();
                     
            //TODO: Enum van animation lists maken?
            //animationmanager verwijderen?
            animation = new Animation.Animation();
            animation.AddFrame(new Animation.AnimationFrame(new Rectangle(0, 0, 32, 32)));
            animation.AddFrame(new Animation.AnimationFrame(new Rectangle(32, 0, 32, 32)));
            animation.AddFrame(new Animation.AnimationFrame(new Rectangle(64, 0, 32, 32)));
            animation.AddFrame(new Animation.AnimationFrame(new Rectangle(96, 0, 32, 32)));

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, Position,animation.CurrentFrame.SourceRectangle,Color.White);
        }

        public void Update(GameTime gameTime)
        {
            move();
            animation.Update(gameTime);
        }
        
        public void move()
        {
            movementManager.Move(this);
            //var direction = inputReader.ReadInput();
            //speed.X = direction.X;
            //position += speed;
        }
        
    }
}
