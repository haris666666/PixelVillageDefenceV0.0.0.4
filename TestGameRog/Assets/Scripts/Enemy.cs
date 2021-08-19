using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
   [SerializeField] private Transform player;
  // [SerializeField]  private Transform enemy;
   // Rigidbody2D rb;

    NavMeshAgent agent;

    private Animator Anim;

   // private Vector2 moveInput;
  //  private Vector2 moveVelocity;
    
     
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

       // Anim = GetComponent<Animator>();
       // rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.position);
        
        if(player.transform.position.x < transform.position.x)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
       
      /*  moveInput = new Vector2(enemy.position.x, enemy.position.y);
       // moveVelocity = moveInput.normalized * Speed;
        if (enemy.transform.position.x > 0)
        {
            Anim.SetBool("running", false);
        }
        else
        {
            Anim.SetBool("running", true);
        } */
    }
}
