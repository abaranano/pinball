using UnityEngine;

public class flipperIzquierdo : MonoBehaviour
{
    public float velocidad = 20f;
    private Quaternion rotacionArriba = Quaternion.Euler(new Vector3(0, 135f, 0));
    private Quaternion rotacionAbajo = Quaternion.Euler(new Vector3(0, 210f, 0));
    private bool subir = false;
    private bool bajar = false;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            subir = true;
            bajar = false;
        }

        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            subir = false;
            bajar = true;
        }
    }

    private void FixedUpdate()
    {
        if (subir)
        {
            rb.MoveRotation(Quaternion.Lerp(rb.rotation, rotacionArriba, velocidad * Time.fixedDeltaTime));
        }
        else if (bajar)
        {
            rb.MoveRotation(Quaternion.Lerp(rb.rotation, rotacionAbajo, velocidad * Time.fixedDeltaTime));
        }
    }
}
