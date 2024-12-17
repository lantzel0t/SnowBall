using UnityEngine;

public class SlingShot : MonoBehaviour
{
    public float pushMult = 10.0f;

        private void OnTriggerEnter(Collider other)
    {
        Vector3 angle = (transform.forward * pushMult);
        Debug.Log("Bumping ball at: " + angle);
        
        other.gameObject.GetComponent<Rigidbody>().AddForce(angle, ForceMode.Impulse);

        //other.gameObject.GetComponent<Rigidbody>().linearVelocity *= -pushMult;
    }
}
