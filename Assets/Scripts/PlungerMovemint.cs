using UnityEngine;

public class PlungerMovemint : MonoBehaviour
{
    public float pullbackSpeed = 1f; // Speed at which the object moves along the X-axis
    public float launchSpeed = 0.7f;
    public float maxPullback = 0f;
    private Vector3 maxPullbackPos; 
    private Vector3 initialPosition; // Store the initial position of the object
    private Rigidbody rigidbody_a;

    void Start()
    {
        // Store the initial position and RB when the script starts
        initialPosition = transform.position;
        rigidbody_a = GetComponent<Rigidbody>();
        // Figure out how far back we can pull
        maxPullbackPos = initialPosition;
        maxPullbackPos.x += maxPullback;
    }

    void Update()
    {
        // Check if spacebar is being held down
        if (Input.GetKey(KeyCode.Space))
        {
            // Move the object along the x-axis
            rigidbody_a.MovePosition(Vector3.Lerp(transform.position, maxPullbackPos, pullbackSpeed));
        }
        else
        {
            // Reset the object's position to the initial one when spacebar is not held
            rigidbody_a.MovePosition(Vector3.Lerp(transform.position, initialPosition, launchSpeed));
        }
    }
}
