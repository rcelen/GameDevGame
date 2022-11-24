﻿using GameDevProject.Input;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevProject
{
    internal interface Imoveable
    {
        public Vector2 Position { get; set; }
        public Vector2 Speed { get; set; }

        public Vector2 Acceleration { get; set; }
        public KeyboardReader InputReader { get; set; }
    }
}
