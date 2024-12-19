using UnityEngine;

public class TurnTable : MonoBehaviour
{
    Vector3 eulerAngleVelocity;
    Rigidbody rigidbody_a;
    public float rotSpeed = 200f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        eulerAngleVelocity = new Vector3(0,rotSpeed,0);
        rigidbody_a = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime);
        rigidbody_a.MoveRotation(rigidbody_a.rotation * deltaRotation);
    }
}
