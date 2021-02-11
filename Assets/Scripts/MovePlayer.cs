using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    MousePosCal mousePosCal=default;

    Vector2     beforeChangingXY = default;
    Vector2     afterChanginXY = default;
    Vector2     sumChangingXY = default;

    float       borderPositionX = default;
    float       borderPositionZ = default;
   
    void Start()
    {
        //transform.position = Vector3.zero;//start pos

        mousePosCal = Camera.main.GetComponent<MousePosCal>();
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {

            //
            beforeChangingXY = mousePosCal.positionChangingXY;//get before pos
            //
            sumChangingXY = beforeChangingXY - afterChanginXY;//mouse pos changing per frame
            //
            
            if (IsInTheBorder())
            {

                //
                transform.position = new Vector3((transform.position.x - sumChangingXY.x),
                    transform.position.y, (transform.position.z - sumChangingXY.y)); //change position    
                //I add z pos because my tornado move x and z pos but mouse pos move x and y
            }
            //
            afterChanginXY = mousePosCal.positionChangingXY;//get after pos 
        }
        else
        {
            afterChanginXY = Vector2.zero; beforeChangingXY = Vector2.zero;
            //because continue the some position
        }
    }


    bool IsInTheBorder()
    {
        borderPositionX = transform.position.x - sumChangingXY.x;
        borderPositionZ = transform.position.z - sumChangingXY.y;
        //am ı in the border

        return borderPositionZ <= 21 && borderPositionZ >= -26 && borderPositionX <= 21 && borderPositionX >= -25;
    }


}
