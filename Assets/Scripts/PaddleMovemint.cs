using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovemint : MonoBehaviour
{
    private Quaternion restAngle;
    private Rigidbody rigidbody_a;
    public float angleDeg = 45f;
    private Quaternion shotAngle;
    public float hitStrength = 0.5f;
    public string inputName;

    void Start()
    {
        rigidbody_a = GetComponent<Rigidbody>();
        restAngle = rigidbody_a.rotation;

        shotAngle = Quaternion.Euler(0, angleDeg, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis(inputName) == 1){
            rigidbody_a.MoveRotation(Quaternion.Lerp(
                rigidbody_a.rotation, shotAngle, hitStrength));
        }
        else{
            rigidbody_a.MoveRotation(Quaternion.Lerp(
                rigidbody_a.rotation, restAngle, hitStrength));
        }
    }
}