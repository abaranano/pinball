using UnityEngine;

public class flipperDerecho : MonoBehaviour
{
    public float velocidad = 20f;
    private Quaternion rotacionArriba = Quaternion.Euler(new Vector3(0, 45f, 0));
    private Quaternion rotacionAbajo = Quaternion.Euler(new Vector3(0, -30f, 0));
    private bool subir = false;
    private bool bajar = false;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            subir = true;
            bajar = false;
        }

        if (Input.GetKeyUp(KeyCode.RightControl))
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