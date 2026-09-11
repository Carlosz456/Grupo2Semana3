using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3Sem3
{
    internal class Player
    {
        protected float vida;
        protected float dmg;

        public Player(float vida, float dmg)
        {
            this.vida = vida;
            this.dmg = dmg;
        }
        public virtual float RecibirDano(float dmgRecibido)
        {
            return vida - dmgRecibido;
        }
        public virtual float AtaqueDMG(float dmg)
        {
            return dmg;
        }
    }
}
