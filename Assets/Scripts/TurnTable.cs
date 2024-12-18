using UnityEngine;

public class TurnTable : MonoBehaviour
{
    Vector3 eulerAngleVelocity;
    Rigidbody rigidbody;
    public float rotSpeed = 200f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        eulerAngleVelocity = new Vector3(0,rotSpeed,0);
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime);
        GetComponent<Rigidbody>().MoveRotation(rigidbody.rotation * deltaRotation);
    }
}
