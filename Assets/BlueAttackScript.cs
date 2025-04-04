using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueAttackScript : MonoBehaviour
{


    private Animator animator;
    public float range = 100f;
    public float knockbackForce = 250f;
    public GameObject enemy;

    private Rigidbody enemyRigidbody;

    void Start()
    {
        animator = GetComponent<Animator>();
        if (enemy != null)
        {
            enemyRigidbody = enemy.GetComponent<Rigidbody>();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("AttackTrigger");
            ShootRaycast();
        }
    }

    void ShootRaycast()
    {
        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            if (hit.transform.gameObject == enemy)
            {
                Knockback(hit.transform);
            }
        }
    }

    void Knockback(Transform enemyTransform)
    {
        if (enemyRigidbody != null)
        {
           
            Vector3 knockbackDirection = enemyTransform.position - transform.position;
            knockbackDirection.y = 0;  
            knockbackDirection.Normalize();
            enemyRigidbody.AddForce(knockbackDirection * knockbackForce, ForceMode.Impulse);
        }
    }
}
