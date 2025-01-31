using UnityEngine;

public class Plunger : MonoBehaviour
{
    public GameObject PosCarga;
    private Vector3 PosInicial;
    public Rigidbody piston;
    public float velocidadCarga = 2f;
    public float velocidadSoltar = 8f;
    public float soltar = 0.09f;
    private bool moverHaciaCarga = false;
    private bool moverHaciaInicial = false;

    private void Start()
    {
        PosInicial = transform.position;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            moverHaciaCarga = true;
            moverHaciaInicial = false;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            moverHaciaCarga = false;
            moverHaciaInicial = true;
        }
    }

    private void FixedUpdate()
    {
        if (moverHaciaCarga)
        {
            piston.MovePosition(Vector3.Lerp(piston.position, PosCarga.transform.position, velocidadCarga * Time.fixedDeltaTime));
        }
        else if (moverHaciaInicial)
        {
            piston.MovePosition(Vector3.MoveTowards(piston.position, PosInicial, velocidadSoltar * soltar));
        }
    }
}


