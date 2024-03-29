using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacking : MonoBehaviour
{
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public Animator animator;
    public float attackRate = 2f;
    float nextAttackTime = 0f;



    // Update is called once per frame
    void Update()
    {

        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
      

    }
    void Attack()
    {
        animator.SetTrigger("Attack");
        Collider2D[] hitEnemies =   Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemyhealth>().TakeDamage(20);

        }
    }
    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
