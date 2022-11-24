﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevProject.Input
{
    internal class KeyboardReader : IInputReader
    {
        public Vector2 ReadInput()
        {
            KeyboardState state = Keyboard.GetState();
            var direction = Vector2.Zero;
            if (state.IsKeyDown(Keys.Left))
            {
                direction.X = -3;
            }
            if (state.IsKeyDown(Keys.Right))
            {
                direction.X = 3;
            }
            if (state.IsKeyDown(Keys.None))
            {
                direction.X = 0;
            }
            return direction;
        }
    }
}
