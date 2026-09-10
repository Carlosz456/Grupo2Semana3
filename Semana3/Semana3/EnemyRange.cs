using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo2Semana3
{
    internal class EnemyRange : Program
    {
        protected float vida;
        protected float dano;
        protected float balas;
        public EnemyRange(float vida, float dano, float balas)
        {
            this.vida = vida;
            this.dano = dano;
            this.balas = balas;
        }
        public virtual float RecibirDanoEnemigoRango(float danoRecibido)
        {
            return vida - danoRecibido;
        }

        public virtual float AtaquedeEnemigoRango(float dano)
        {
            return dano;
        }
    }
}