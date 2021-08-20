using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform spawnPos;
    [SerializeField] Vector2 range;
    [SerializeField] GameObject enemy;
    [SerializeField] float TimerSpawnEnemy;
    [SerializeField] int CountEnemy;
    int count = 0;
    void Start()
    {
        StartCoroutine(Spawn());   
    }
    IEnumerator Spawn()
    {

        yield return new WaitForSeconds(TimerSpawnEnemy);
        Vector2 pos = spawnPos.position + new Vector3(0, Random.Range(-range.y, range.y));
        Instantiate(enemy, pos, Quaternion.identity);
        if (count < CountEnemy)
        {
            Repeat();
            count++;
        }
    }
    void Repeat()
    {
        StartCoroutine(Spawn()); 
    }

}
