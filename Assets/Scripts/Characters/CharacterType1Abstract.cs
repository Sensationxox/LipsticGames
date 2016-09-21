using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Characters
{
    public abstract class CharacterType1Abstract : CharacterInterface
    {
        public int lvl;
        public int intel;
        public int dex;
        public int str;
        public int proffession;
        public int fullLife;
        public int leftLife;
        public int damage;
        public int heal;
        public int chanceAtt;
        public int chanceDef;
        public int chanceHeal;
        ////// APPEARANCE FOR TYPE 1
        public int head;
        public int hair;
        public int skin;
        public int eyes;
        public int clothes;

        public void AnimAttack()
        {
            throw new NotImplementedException();
        }

        public void AnimDeath()
        {
            throw new NotImplementedException();
        }

        public void AnimDeff()
        {
            throw new NotImplementedException();
        }

        public void AnimHeal()
        {
            throw new NotImplementedException();
        }

        public void AnimHit()
        {
            throw new NotImplementedException();
        }

        public void AnimIdle()
        {
            throw new NotImplementedException();
        }

        public void AnimWalk()
        {
            throw new NotImplementedException();
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void CountYourStats()
        {
            throw new NotImplementedException();
        }

        public void EvadeBlock()
        {
            throw new NotImplementedException();
        }

        public void Heal()
        {
            throw new NotImplementedException();
        }

        public void SetAppearance()
        {
            throw new NotImplementedException();
        }

        public void SetEmotion(int[] percents)
        {
            throw new NotImplementedException();
        }

        /*public void Start()
        {
            throw new NotImplementedException();
        }*/
    }
}
