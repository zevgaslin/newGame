using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject sword;
    public bool CanAttack = true;
    public float sTimer = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && CanAttack)
        {
            SwordAttack();
        }
    }

    public void SwordAttack()
    {
        CanAttack = false;
        Animator anim = sword.GetComponent<Animator>();
        anim.SetTrigger("attack");
        StartCoroutine(AttackReset());
    }

    IEnumerator AttackReset()
    {
        yield return new WaitForSeconds(sTimer);
        CanAttack = true;
        Animator anim = sword.GetComponent<Animator>();
        anim.SetTrigger("attack");
    }
}
