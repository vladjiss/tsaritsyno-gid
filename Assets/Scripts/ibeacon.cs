using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ibeacon : MonoBehaviour
{
    float t =0f;
    public Material m;
    public Color color1, color2;
    bool st = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (st)
        {
            t += Time.deltaTime*2f;
            if (t > 1)
            {
                t = 1f;
                st = !st;
            }
        }
        else
        {
            t -= Time.deltaTime * 2f;
            if (t < 0)
            {
                t = 0f;
                st = !st;
            }
        }
        m.SetColor("_TintColor", Color.Lerp(color1, color2, t));
    }
}
