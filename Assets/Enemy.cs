using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    Animator animator;

    public float health;

    private void Start() {
        animator = GetComponent<Animator>();
        health = 1f;
    }
    

    public float Health{
        set{
            health = value;
            if(health <= 0){
                Defeated();
            }else{
                TakeDamage();
            }
        }
        get{
            return health;
        }
    }

    public void TakeDamage(){
        animator.SetTrigger("takeDamage");
    }

    public void Defeated(){
        animator.SetTrigger("defeated");
    }

    public void RemoveEnemy(){
        Destroy(gameObject);
    }

}
