using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Characters
{
    interface CharacterInterface
    {
        //void Start(); //set all stats, count hp, att & other, set speed to walk waitforseconds
        void CountYourStats(); //this can be used in Start() o recalculate players character
        void SetAppearance(); //set sprites & if needed other things for animations
        void SetEmotion(int[] percents); //this is called in every turn
        void Attack(); //count if needed attack damage
        void Heal(); //count if needed heal
        void EvadeBlock(); //evade, block algorythm
        //////////
        void AnimWalk(); //animations.. do i need them in this manner?
        void AnimIdle();
        void AnimAttack();
        void AnimHeal();
        void AnimDeff();
        void AnimHit();
        void AnimDeath();
    }
}
