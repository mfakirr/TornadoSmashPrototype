using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIRunAway : MonoBehaviour
{

     public Transform player;

     public int speed;

    void Update()
    {
       float distance =  Vector3.Distance(transform.position, player.position);
        if (distance < 20)
        {
            Vector3 moveDir = transform.position - player.transform.position;
            moveDir.y = 0;
            transform.Translate(moveDir.normalized * speed * Time.deltaTime);
        }
    }


}
