using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : FightSystem
{
    private GameObject FoundHero;
    void Start()
    {
        FoundHero = GameObject.Find("Hero");
    }
    
    public void EndAttackEnemy()
    {
        if(Vector2.Distance(FoundHero.transform.position, transform.position) < 1)
        {
            PlayerHp--;
        }
        
        if(PlayerHp <= 0)
        {
            print("Hero death");
            PlayerHp = FullPlayerHp;
        } 
    }
}
