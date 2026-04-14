using Unity.Cinemachine;
using UnityEngine;

public class ActivarCamaraSpline : MonoBehaviour
{
    public CinemachineCamera camaraNormal;
    public CinemachineCamera camaraSpline;
    public CinemachineSplineDolly dolly;

    private bool enSpline = false;

    void Start()
    {
        camaraNormal.Priority.Value = 10;
        camaraSpline.Priority.Value = 0;

        dolly.enabled = false; 
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Cesped") && !enSpline)
        {
            Debug.Log("ACTIVA SPLINE");

            camaraNormal.Priority.Value = 0;
            camaraSpline.Priority.Value = 20;

            dolly.enabled = true;         
            dolly.CameraPosition = 0f;   

            enSpline = true;

            Invoke("VolverCamara", 5f); 
        }
    }

    void VolverCamara()
    {
        Debug.Log("VOLVER A JUGADOR");

        dolly.enabled = false; 

        camaraSpline.Priority.Value = 0;
        camaraNormal.Priority.Value = 50;

        enSpline = false;
    }
}