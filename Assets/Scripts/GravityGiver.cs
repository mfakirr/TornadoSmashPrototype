using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityGiver : MonoBehaviour
{
    Rigidbody PullableObjectRb;
/// <summary>
/// give gravity if in the field
/// </summary>
/// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pullable")
        {
            PullableObjectRb = other.gameObject.GetComponent<Rigidbody>();
            //
            if (PullableObjectRb.isKinematic == enabled)
            {
                PullableObjectRb.isKinematic = !enabled;
                other.gameObject.transform.parent = null;
            }
              
            //
        }
    }
}
