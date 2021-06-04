using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dev__project_2020
{
    class Bullet: ICloneable
    {
        //alleen gebruikenbij child comp
        protected Texture2D _texture;
        protected float _rotation;
        protected Controls currentKey; // 2 button stat vergelijken anders straal van kogels ipv 1
        protected Controls previousKey;

        public Vector2 position;
        public Vector2 Origin;

        public Vector2 Directions;
        public float LinearVelocity = 4f; // snelheid

        public float Lifespan = 0f;
        public bool IsRemoved = false;

        public Bullet(Texture2D texture)
        {
            _texture = texture;
            Origin = new Vector2(_texture.Width / 2, _texture.Height / 2);
        }

        public virtual void Update(GameTime gameTime,List<Bullet> bullets)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, position, null, Color.White, _rotation, Origin, 1, SpriteEffects.None, 0);
        }

        public object Clone()
        {
            return this.MemberwiseClone(); 
        }
    }
}
