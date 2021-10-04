using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helper : MonoBehaviour
{
        public static void FlipObject(GameObject obj, bool objectDirection)
        {


            if (objectDirection == true)
            {
                obj.transform.localRotation = Quaternion.Euler(0, 180, 0);

            }
            else
            {
                obj.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }


        }
        public static bool GetObjectDir(GameObject obj)
        {
            float ang = obj.transform.eulerAngles.y;
            if (ang == 180)
            {
                return true;
            }
            else
                return false;
        }
    public static void FollowPlayer(GameObject EnemyScript, GameObject SpriteScript)
    {
        float dist;
        dist = (SpriteScript.transform.x) - (EnemyScript.transform.x);
        print(dist);
    }
}
