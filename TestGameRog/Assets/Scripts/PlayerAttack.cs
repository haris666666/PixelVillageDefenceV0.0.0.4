using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class PlayerAttack : Player
{
   // [SerializeField] GameObject Weapon;
  //  private Collider2D HitBox;
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