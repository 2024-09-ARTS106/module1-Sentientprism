using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        public int frameNum;
    Debug.Log("I was told to start: " + this.gameObject.name);
       
}

// Update is called once per frame
void Update()
{
       
        //Debug.Log("Frame #{0}: Update at Time: {1}", frameNum, Time.time);
        Debug.LogFormat("Frame #{0}: Update at Time: {1}", frameNum, Time.time);
        frameNum = frameNum + 1;
    }
}
