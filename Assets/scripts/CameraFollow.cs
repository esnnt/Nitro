using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;   // Araba
    private Vector3 offset;

    void Start()
    {
        // Kameranýn sahnedeki mevcut konumunu baz alýyoruz
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
