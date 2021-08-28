using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : PlayerAttack
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
        if (collision.gameObject.tag == "Enemy")
        {
            StartCoroutine(DestroyTime());
            Destroy(collision.gameObject);
        }
    }
    IEnumerator DestroyTime()
    {
        yield return new WaitForSeconds(1f);
    }
    IEnumerator HitBoxEnabled()
    {
        yield return new WaitForSeconds(0.5f);
        HitBoxWeapon.enabled = true;

        yield return new WaitForSeconds(0.3f);
        HitBoxWeapon.enabled = false;

    }
 
}
