using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameGame
{
    internal class World
    {
        private Sensei sensei;

        public World()
        {
            sensei = new Sensei();

        }
        public virtual void Update(float delta)
        {
            sensei.Update(delta);
        }

        public virtual void Draw()
        {
            sensei.Draw();
        }
    }
}
