using Unity.Cinemachine;
using UnityEngine;

public class SecuenciaCamaras : MonoBehaviour
{ 
    public CinemachineCamera cam1;
    public CinemachineCamera cam2;
    public CinemachineCamera cam3;
    public CinemachineCamera cam4;
    public CinemachineCamera camaraNormal; 

    void Start()
    {
        
        cam1.Priority.Value = 20;
        cam2.Priority.Value = 0;
        cam3.Priority.Value = 0;
        cam4.Priority.Value = 0;
        camaraNormal.Priority.Value = 0;

        Invoke("CambiarCam2", 3f);
    }

    void CambiarCam2()
    {
        cam1.Priority.Value = 0;
        cam2.Priority.Value = 20;

        Invoke("CambiarCam3", 3f);
    }

    void CambiarCam3()
    {
        cam2.Priority.Value = 0;
        cam3.Priority.Value = 20;

        Invoke("CambiarCam4", 3f);
    }

    void CambiarCam4()
    {
        cam3.Priority.Value = 0;
        cam4.Priority.Value = 20;

        Invoke("VolverAlJugador", 3f);
    }

    void VolverAlJugador()
    {
        cam4.Priority.Value = 0;
        camaraNormal.Priority.Value = 50; // FreeLook
    }
}