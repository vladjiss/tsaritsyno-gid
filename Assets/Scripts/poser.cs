using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poser : MonoBehaviour
{
    int counter = 0;
    public Transform[] objs;
    public Transform[] objs_pop;
    public Camera cam;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchSupported && Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began || Input.GetMouseButtonUp(0)  && !Input.touchSupported)
        {
            Vector3 v = cam.transform.forward;
            if (Input.touchSupported)
                v = cam.ScreenPointToRay(Input.GetTouch(0).position).direction;
            else
                v = cam.ScreenPointToRay(Input.mousePosition).direction;
            Vector3 pos = cam.transform.position + v * 10;
            Quaternion rot = cam.transform.rotation;
            if (counter < objs.Length)
            {
                //Instantiate(objs[counter], pos, rot);
                objs[counter].gameObject.SetActive(true);
                objs[counter].position = pos;
                objs[counter].rotation = rot;
            }
            else
                objs_pop[counter - objs.Length].gameObject.SetActive(true);
            counter++;
        }
    }

}
