using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeout : MonoBehaviour
{
    public GameObject gb;
    float timer = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 3f)
        {
            gb.SetActive(true);
        }
    }
}
