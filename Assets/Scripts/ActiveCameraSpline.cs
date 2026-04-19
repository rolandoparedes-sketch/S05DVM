using Unity.Cinemachine;
using UnityEngine;

public class ActivarCamaraSpline : MonoBehaviour
{
    public CinemachineCamera camaraNormal;
    public CinemachineCamera camaraSpline;

    private CinemachineSplineDolly dolly;
    private bool enSpline = false;
    private bool yaSeActivo = false;
    public float velocidad = 0.2f; 

    void Start()
    {
        camaraNormal.Priority.Value = 10;
        camaraSpline.Priority.Value = 0;

        dolly = camaraSpline.GetComponent<CinemachineSplineDolly>();
        dolly.CameraPosition = 0f;
        dolly.enabled = false;
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Cesped") && !enSpline && !yaSeActivo)
        {
            camaraNormal.Priority.Value = 0;
            camaraSpline.Priority.Value = 20;

            dolly.enabled = true;
            dolly.CameraPosition = 0f;

            enSpline = true;
            yaSeActivo = true; 
        }
    }

    void Update()
    {
        if (enSpline)
        {
            dolly.CameraPosition += Time.deltaTime * 0.2f;

            if (dolly.CameraPosition >= 1f)
            {
                VolverCamara();
            }
        }
    }

    void VolverCamara()
    {
        dolly.enabled = false;

        camaraSpline.Priority.Value = 0;
        camaraNormal.Priority.Value = 50;

        enSpline = false;
    }
}