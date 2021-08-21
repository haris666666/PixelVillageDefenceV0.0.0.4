using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : FightSystem
{
    private Collider2D HitBoxWeapon;

    void Start()
    {
        HitBoxWeapon = GetComponent<Collider2D>();
        HitBoxWeapon.enabled = false;
    }
    public void onClickHitBox()
    {
        StartCoroutine(HitBoxEnabled());
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ZombieTag")
        {
            StartCoroutine(DestroyTime());
            ZombieHp--;
            if(ZombieHp <= 0)
            {
                Destroy(collision.gameObject);
                ZombieHp = FullZombieHp;
            }
        }
        if (collision.gameObject.tag == "SceletonTag")
        {
            StartCoroutine(DestroyTime());
            SceletonHp--;
            if(SceletonHp <= 0)
            {
                Destroy(collision.gameObject);
                SceletonHp = FullSceletonHp;
            }
        }
    }
    IEnumerator DestroyTime()
    {
        yield return new WaitForSeconds(1f);
    }
    IEnumerator HitBoxEnabled()
    {
        yield return new WaitForSeconds(0.5f); // через 5 секунд нанесется урон
        HitBoxWeapon.enabled = true;

        yield return new WaitForSeconds(0.3f);
        HitBoxWeapon.enabled = false;
    }

}
