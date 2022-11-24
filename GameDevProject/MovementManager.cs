using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameDevProject
{
    internal class MovementManager
    {
        public void Move(Imoveable moveable)
        {
            Vector2 direction = moveable.InputReader.ReadInput();

            var distance = direction * moveable.Speed;
            moveable.Speed += moveable.Acceleration;
            moveable.Position += distance;
        }
    }
}
