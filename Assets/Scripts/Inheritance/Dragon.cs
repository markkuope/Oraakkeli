using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : Enemy
{
    public bool attacking = false;

   private void Update()
    {
        if (attacking)
        {
            Attack();
            //base.Attack();
        }
    }

    //void Attack()
    //{
    //    print("Dragon hy�kk��");
    //}

}
