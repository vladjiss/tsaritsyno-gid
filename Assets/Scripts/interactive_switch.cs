using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactive_switch : MonoBehaviour
{
    public Transform cam, map;
    bool map_on = true;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(cam.localEulerAngles.x);
        if (cam.localEulerAngles.x > 45f && cam.localEulerAngles.x <270 && !map_on)
        {
            map_on = true;
            Switch();
        }
        if ((cam.localEulerAngles.x <= 45f || cam.localEulerAngles.x >= 270) && map_on)
        {
            map_on = false;
            Switch();
        }
    }
    void Switch()
    {
        if (map_on)
        {
            map.gameObject.SetActive(true);
        }
        else
            map.gameObject.SetActive(false);
    }
}
