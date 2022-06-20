using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APIStatic : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector3 V1 = new Vector3(1f, 1f, 1f);

    private Vector3 V2 = new Vector3(22f, 22f, 22f);

    void Start()
    {
        //print(Random.value);
        //Cursor.visible = false;
        print(Mathf.Infinity);
        print($"2PI is {2*Mathf.Rad2Deg} degree");
        print(Camera.allCamerasCount);
        print(Application.platform);
        print("數值9.999f取四捨五入: "+Mathf.Round(9.999f));
        Physics.sleepThreshold = 10f;
        print("SleepThreshold= " + Physics.sleepThreshold);
        print("Distance from V1 to V2 : "+Vector3.Distance(V1,V2));
        Application.OpenURL("https://unity.com/");

    }

    private void Update()
    {
        //print(Input.anyKeyDown);
        //print(Time.timeSinceLevelLoad);
        if (Input.GetKey(KeyCode.Space))
        {
            print("Space is being pressed.");
        }
    }


}
