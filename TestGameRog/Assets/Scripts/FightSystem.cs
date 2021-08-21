using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class FightSystem : MonoBehaviour
{
    protected int PlayerHp = 3;
    protected int FullPlayerHp = 3;

    protected int FullZombieHp = 3;
    protected int ZombieHp = 3;

    protected int SceletonHp = 2;
    protected int FullSceletonHp = 2;









    private Animator AnimAttack;
    protected bool StateAttack = true;

    void Start()
    {
        AnimAttack = GetComponent<Animator>();
    }
    public void onClick()
    {
        AnimAttack.SetBool("attack", StateAttack);
    }
    public void EndAttack()
    {
        AnimAttack.SetBool("attack", !StateAttack);
    }
}