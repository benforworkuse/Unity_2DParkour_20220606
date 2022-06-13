using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APIStatic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(Random.value);
        Cursor.visible = false;
        print(Mathf.Infinity);
        print($"0.7PI is {0.7*Mathf.Rad2Deg} degree");
        print(Camera.allCamerasCount);
        print(Application.platform);

    }

   
}
