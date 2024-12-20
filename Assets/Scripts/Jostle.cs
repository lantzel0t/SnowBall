using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jostle : MonoBehaviour
{
    private Rigidbody rigidbody_a;
    private Camera cam;
    public float traumaPerTap = 0.01f;
    public float traumaMax = 0.05f;
    public float traumaCurrent = 0f;

    void Start()
    {
        rigidbody_a = GetComponent<Rigidbody>();
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            traumaCurrent += traumaPerTap;
            if (traumaCurrent > traumaMax) {
                GameManager.Instance.TriggerTilt();
            }
            traumaCurrent = Mathf.Min(traumaCurrent, traumaMax);
           
        }
        rigidbody_a.AddForce(Random.onUnitSphere*traumaCurrent);
        cam.transform.localPosition = Random.insideUnitSphere*(traumaCurrent/10);
        if (traumaCurrent>0) { traumaCurrent -= 0.02f; }

        
    }

    //TODO: camera jostle!

}
