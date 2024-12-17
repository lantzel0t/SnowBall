using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperMovemint : MonoBehaviour
{
    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrength = 10000f;
    public float flipperDamper = 150f;
    public string inputName;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis(inputName) == 1){

        }
    }
}
