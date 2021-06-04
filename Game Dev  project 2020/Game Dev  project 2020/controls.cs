using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dev__project_2020
{
    class Controls
    {
        public bool left { get; set; } = false;
        public bool right { get; set; } = false;
        public bool jump { get; set; } = false;
        public bool enter { get; set; } = false;
        public bool shoot { get; set; } = false;

        public void Update()
        {

            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                jump = true;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                right = true;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                left = true;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                shoot = true;
            }
        }

    }
}
