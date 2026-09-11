using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3
{
    class EnemigoMelee : Enemy
    {
        //El constructor debe recibir la vida que tiene y daño que puede causar
        float vida;
        float causarDaño;
        public EnemigoMelee(float vida, float causarDaño)
        {
            this.vida = vida;
            this.causarDaño = causarDaño;
        }
        
        //Debe tener un método que le permita recibir daño
        public override void RecibirDaño(float daño)
        {
            float enemigo_daño = vida - daño;
            vida = enemigo_daño;
        }
        
        //Debe tener un método que retorne el daño que puede causar 
        public override float CausarDaño()
        {
            return causarDaño;
        }
        
        //Debe tener un método que retorne si está vivo o muerto 
        public override bool EstadoEnemigo()
        {
            return vida > 0;
        }
    }
}