using UnityEngine;

public class posBola : MonoBehaviour
{
    public GameObject bola;
    public GameObject hasiera;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("finish"))
        {
            Debug.Log("La bola ha tocado el suelo.");
            bola.transform.position = hasiera.transform.position;
            bola.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("finish"))
        {
            Debug.Log("La bola ha atravesado el suelo.");
            bola.transform.position = hasiera.transform.position;
            bola.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
    }
}
