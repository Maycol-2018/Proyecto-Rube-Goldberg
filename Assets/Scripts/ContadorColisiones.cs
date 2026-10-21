using UnityEngine;

public class ContadorColisiones : MonoBehaviour
{
    public int colisiones = 0;
    public static int totalColisiones = 0;

    void OnCollisionEnter(Collision collision)
    {
        colisiones++;
        totalColisiones++;
        Debug.Log("Colision numero " + totalColisiones + ": " + gameObject.name + " choco con " + collision.gameObject.name);
    }
}