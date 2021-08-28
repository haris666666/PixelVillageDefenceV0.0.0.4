using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : SpawnBullet
{
    private Transform bullet;
    [SerializeField] Joystick joystick;
    Vector2 PosJs;
    void Start()
    {
        bullet = GetComponent<Transform>();
        bullet.SetParent(HeroPos);
        //PosJs = new Vector2(joystick.Horizontal, joystick.Vertical);
    }

    // Update is called once per frame
    void Update()
    {
        bullet.Translate(20 * Time.deltaTime, joystick.Vertical, 0);
    }
}
