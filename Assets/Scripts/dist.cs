using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dist : MonoBehaviour
{
    public string str;
    public Transform cam;
    public TextMesh textMesh;
    float d = 0f;
    void Update()
    {
        d = Vector3.Distance(cam.position, transform.position);
        textMesh.text = str + string.Format("{0:0.##}", d) + "m";
    }
}
