using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnBullet : FightSystem
{
    [SerializeField] GameObject MagicBullet;
    private GameObject link;
    protected Transform HeroPos;

    private void Start()
    {
        HeroPos = GetComponent<Transform>();
    }
    private void Update()
    {
        
    }

    public void OnClickMagicAttack()
    {
       link = Instantiate(MagicBullet, HeroPos);
        StartCoroutine(DeleteBullet());
    }
    IEnumerator DeleteBullet()
    {
        yield return new WaitForSeconds(1f);
        Destroy(link);
    }

}
