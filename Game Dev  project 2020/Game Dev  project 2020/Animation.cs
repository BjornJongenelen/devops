using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dev__project_2020
{
    class Animation
    {

        private List<AnimationFrame> frames;
        public AnimationFrame CurrentFrame { get; set; }
        public int AantalBewegingenPerSeconde { get; set; }

        private int counter = 0;

        private double x = 0;
        public double offset { get; set; }

        private int _totalWidth = 0;
        //Set variables
        public Animation()
        {
            frames = new List<AnimationFrame>();
            AantalBewegingenPerSeconde = 1;
        }
        //Voeg een frame toe aan de animatie
        public void AddFrame(Rectangle rectangle)
        {
            AnimationFrame newFrame = new AnimationFrame()
            {
                sourcetemplate = rectangle,
                //Duration = duration
            };

            frames.Add(newFrame);
            CurrentFrame = frames[0];
            offset = CurrentFrame.sourcetemplate.Width;
            foreach (AnimationFrame f in frames)
                _totalWidth += f.sourcetemplate.Width;
        }

        //Update de animatie
        public void Update(GameTime gameTime)
        {
            double temp = CurrentFrame.sourcetemplate.Width * ((double)gameTime.ElapsedGameTime.Milliseconds / 1000);

            x += temp;
            if (x >= CurrentFrame.sourcetemplate.Width / AantalBewegingenPerSeconde)
            {
                Console.WriteLine(x);
                x = 0;
                counter++;
                if (counter >= frames.Count)
                    counter = 0;
                CurrentFrame = frames[counter];
                offset += CurrentFrame.sourcetemplate.Width;
            }
            if (offset >= _totalWidth)
                offset = 0;
        }

    }
}
