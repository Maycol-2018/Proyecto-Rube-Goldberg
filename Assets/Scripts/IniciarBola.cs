using UnityEngine;

public class IniciarBola : MonoBehaviour
{
    public float velocidad = 3f;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.linearVelocity = Vector3.right * velocidad;
        Debug.Log("Bola iniciada");
    }
}