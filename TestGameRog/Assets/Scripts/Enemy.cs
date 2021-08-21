using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    GameObject FoundHero;
  
    NavMeshAgent agent;

    private Animator Anim;

  
    
     
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        FoundHero = GameObject.Find("Hero");

        Anim = GetComponent<Animator>();

    }

    
    void Update()
    {
        agent.SetDestination(FoundHero.transform.position);
        
        if(FoundHero.transform.position.x < transform.position.x)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }



        if (Vector2.Distance( FoundHero.transform.position , transform.position) < 1)
            
        {
            Anim.SetBool("attack", true);
        }
        if (Vector2.Distance(FoundHero.transform.position, transform.position) > 1)

        {
            Anim.SetBool("attack", false);
        }
    }
}
