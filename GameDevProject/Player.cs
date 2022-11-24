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
    internal class Player : IGameObject
    {

        private Texture2D _texture;
        private Vector2 position;
        Animation.Animation animation;
        private Vector2 speed;

        private IInputReader inputReader;
        
        public Player(Texture2D texture,IInputReader inputReader)
        {
            _texture = texture;
            this.inputReader = inputReader;
            this.position = new Vector2(10, 10);
            this.speed = new Vector2(0, 0);
            
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
            spriteBatch.Draw(_texture, position,animation.CurrentFrame.SourceRectangle,Color.White);
        }

        public void Update(GameTime gameTime)
        {
            move();
            animation.Update(gameTime);
        }
        
        public void move()
        {
            var direction = inputReader.ReadInput();
            speed.X = direction.X;
            position += speed;
        }
        
    }
}
