using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleLanes : MonoBehaviour
{
    public string inputNameR;
    public int selectedLane = 0;
    public int laneCount = 3; //modulo-ing this number,
    // so we don't start counting it at 0!

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown(inputNameR))
        {
            selectedLane = ((selectedLane+1) % laneCount);
        }
    }
}
