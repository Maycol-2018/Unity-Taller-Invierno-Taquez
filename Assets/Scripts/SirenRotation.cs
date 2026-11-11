using UnityEngine;

public class SirenRotation : MonoBehaviour
{
    [Header("Configuración de Rotación")]
    [Tooltip("Velocidad de rotación en grados por segundo.")]
    public float rotationSpeed = 550f;

    void Update()
    {
        // Forzamos a que la rotación sea sobre el eje Y local del propio pivote
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f, Space.Self);
    }
}