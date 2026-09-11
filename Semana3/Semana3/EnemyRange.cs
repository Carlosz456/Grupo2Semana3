using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo2Semana3
{
    internal class EnemigoRango : Enemy
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
        public override float RecibirDaño(float danoRecibido)
        {
            float jugadordaño = vida - danoRecibido;
            vida = jugadordaño;
        }

        public override float CausarDaño(float dano)
        {
            if (balas > 0)
            {
                return dano;
            } else 
            {
                balas - 1;
                return 0;
            }

        public override bool EstadoEnemigo()
        {
            return vida > 0;
        }
    }
}