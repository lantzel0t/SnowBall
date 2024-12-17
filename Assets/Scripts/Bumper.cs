using UnityEngine;

public class Bumper : MonoBehaviour
{
    public float pushMult = 20.0f;

        private void OnTriggerEnter(Collider other)
    {
        Vector3 angle = (other.gameObject.transform.position
            - this.transform.position) * pushMult;
        Debug.Log("Bumping ball at: " + angle);
        GameManager.Instance.Score += 100;
        
        other.gameObject.GetComponent<Rigidbody>().AddForce(angle, ForceMode.Impulse);

        //other.gameObject.GetComponent<Rigidbody>().linearVelocity *= -pushMult;
    }
}
