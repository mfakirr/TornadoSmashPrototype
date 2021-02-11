using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoEffect : MonoBehaviour
{
    GameObject pullObject = default;

    public int pullSpeed = 0;


    private void OnTriggerStay(Collider other)
    {
       
        if (other.gameObject.tag == "Pullable" )
        {
            
            pullObject = other.gameObject;
            //
            Vector3 UpperY = new Vector3(transform.position.x + 3,
                transform.position.y + 8, transform.position.z);
            //
            pullObject.transform.position = Vector3.MoveTowards(pullObject.transform.position,
            UpperY , pullSpeed * Time.deltaTime);

        }

    }


}
