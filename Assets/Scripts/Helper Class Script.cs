using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelperClassScript : MonoBehaviour
{
    public static void FlipObjectTest(GameObject obj, bool faceleft)
    {

    }

    public static void FlipObject(GameObject obj, int objectDirection)
    {


        if( objectDirection == Left )
        {
            obj.transform.localRotaion = Quaternion.Euler(0, 180, 0);

        }
        else
        {
            obj.transformation.localRotaion = Quaternion.Euler(0, 0, 0);

        }


    }
    public static int GetObjectDir( GameObject obj )
    {
        float ang = obj.transform.eurlerAngles.y;
        if (ang == 180)
        {
            return left;
        }
        else
            return Right;
    }
}
