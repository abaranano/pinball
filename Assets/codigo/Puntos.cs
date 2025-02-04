using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Puntos : MonoBehaviour
{
    private int balls;
    public int Points;
    public TextMeshPro text1;
    public TextMeshPro text2;
    public GameObject bola;
    public GameObject hasiera;
    public GameObject amaiera;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("seta"))
        {
            Points++;
        }
        if(collision.collider.CompareTag("pin"))
        {
            Points = Points*2;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("finish"))
        {

            bola.transform.position = hasiera.transform.position;
            bola.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            Points = Points / 2;
            balls--;
        }
    }

    private void Start()
    {
        Points=0;
        balls=1;
    }

    private void Update()
    {

        if (balls > 0)
        {
            string textoPuntos = "Puntuazioa:  " + Points.ToString();
            string textoBolas = "Bolak: " + balls.ToString();
            text1.SetText(textoPuntos);
            text2.SetText(textoBolas);
        }
        else if (balls == 0)
        {
            text1.SetText("Puntuazioa: " + Points.ToString());
            text2.SetText("Sakatu 'Backspace' berriro hasteko");
            bola.transform.position = amaiera.transform.position;
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                Points = 0;
                balls = 10;
                bola.transform.position = hasiera.transform.position;
            }
        }

        
    }
}
