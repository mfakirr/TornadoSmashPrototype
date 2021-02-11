using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosCal : MonoBehaviour
{

    private Vector3 mousePos      = Vector3.zero;
    private Vector3 firstMousePos = Vector3.zero;

    private Vector2 posChangeXY   = Vector2.zero;

    

    public Vector2 positionChangingXY
    {
        get
        {
          
                return -posChangeXY;
           
           
        }
    }


    void Update()
    {
        mousePosCalculator();//Calculate the mouse pos real pos
        //
        if (Input.GetMouseButtonDown(0))
        {  firstMousePos = mousePos;   }//get first mouse position

        //

        if (Input.GetMouseButton(0))
        {   posChangeXY = firstMousePos - mousePos;   }//get changing real mouse pos

        //

        if(Input.GetMouseButtonUp(0)) 
        {   posChangeXY = Vector2.zero; }//we need it

    }

    void mousePosCalculator()
    {
        mousePos   = Input.mousePosition;
        mousePos.z = transform.position.z * 1.3f;//manuel
        mousePos   = Camera.main.ScreenToWorldPoint(mousePos);
    }



}
