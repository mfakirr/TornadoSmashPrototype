using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    private void FixedUpdate()
    {
       
        transform.position = new Vector3(transform.position.z, transform.position.y,
          Mathf.PingPong(Time.time, 5)); 
        
    }
}
