using UnityEngine;

public class Objetivo : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("¡Llegaste al objetivo!");
        }
    }
}