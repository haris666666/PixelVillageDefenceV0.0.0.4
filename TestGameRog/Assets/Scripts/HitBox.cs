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
        HitBoxWeapon.enabled = true;
        StartCoroutine(DestroyTime());
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            StartCoroutine(DestroyTime());
            Destroy(collision.gameObject);
        }
    }
    IEnumerator DestroyTime()
    {
        yield return new WaitForSeconds(2f);
        HitBoxWeapon.enabled = false;
    }
}
