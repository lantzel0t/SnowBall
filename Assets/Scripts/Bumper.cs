using UnityEngine;

public class Bumper : MonoBehaviour
{
    public float pushMagnitude = 1.0f;
    public int baseScore = 100;

        private void OnCollisionEnter(Collision other)
    {
        Vector3 angle = (other.gameObject.transform.position
            - this.transform.position);
        angle.Normalize();
        angle *= pushMagnitude;
        Debug.Log("Bumping ball with power: " + angle.magnitude);
        GameManager.Instance.IncreaseScore(baseScore);
        
        other.gameObject.GetComponent<Rigidbody>().AddForce(angle, ForceMode.Impulse);

        //other.gameObject.GetComponent<Rigidbody>().linearVelocity *= -pushMult;
    }
}
