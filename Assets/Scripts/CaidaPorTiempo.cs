using System.Collections;
using UnityEngine;

public class CaidaPorTiempo : MonoBehaviour
{
    [Header("Configuración de Tiempo")]
    [Tooltip("Tiempo en segundos antes de que la pelota comience a caer")]
    public float tiempoDeEspera = 3.0f; // Este es tu tiempo 't'

    private Rigidbody rb;

    void Start()
    {
        // Obtener la referencia al componente Rigidbody del objeto
        rb = GetComponent<Rigidbody>();

        // Congelar la física al inicio para que no se mueva
        rb.isKinematic = true;

        // Iniciar el temporizador
        StartCoroutine(EsperarYCaer());
    }

    IEnumerator EsperarYCaer()
    {
        // Pausar la ejecución durante 't' segundos
        yield return new WaitForSeconds(tiempoDeEspera);

        // Desactivar el modo cinemático para activar la física y la gravedad
        rb.isKinematic = false;
    }
}