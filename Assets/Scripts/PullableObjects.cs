using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullableObjects : MonoBehaviour
{
    Animator animator;

    Vector3  myForceVector = Vector3.zero;


    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();

        //****** rondom dağılma
        float forcePowerX = 0;
        float forcePowerY = 0;
        float forcePowerZ = 0;

        forcePowerX = Random.Range(-10 ,  10);
        forcePowerY = Random.Range( 25 ,  40);
        forcePowerZ = Random.Range(-10 , -15);

        myForceVector = new Vector3(forcePowerX, forcePowerY, forcePowerZ);//random force vector
        //***** rondom dağılma

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Rigidbody>().AddForce(myForceVector, ForceMode.Impulse);  

            animator.SetBool("Smaller", true);//do animation

            StartCoroutine("WaitForDestroy");//wait
        }

    }

    IEnumerator WaitForDestroy()
    {

        yield return new WaitForSecondsRealtime(0.47f); //Wait 0.47 second
        gameObject.SetActive(false);//for good
      
    }
}
