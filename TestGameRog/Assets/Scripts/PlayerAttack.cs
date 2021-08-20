using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class PlayerAttack : Player
{
    [SerializeField] GameObject Weapon;
    private Collider2D HitBox;
    private Animator AnimAttack;
    protected bool StateAttack = true;

    void Start()
    {
        AnimAttack = GetComponent<Animator>();
          HitBox = GetComponent<Collider2D>();
    }
    public void onClick()
    {
        AnimAttack.SetBool("attack", StateAttack);
        //HitBoxWeapon.enabled = true;

    }
    public void EndAttack()
    {
        AnimAttack.SetBool("attack", !StateAttack);
        //HitBoxWeapon.enabled = false;
    }
   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if(CheckColl == true)
        {
            DestroyTime();
            Destroy(collision.gameObject);
        }
   */


}