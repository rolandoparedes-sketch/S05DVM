using Sirenix.OdinInspector;
using Unity.Cinemachine;
using UnityEngine;

public class CinematicController : MonoBehaviour
{
    public CinemachineCamera camA;
    public CinemachineCamera camB;
    void Start()
    {
        
    }
    [Button]
   public void SwitchCamera()
    {
        if(camB.Priority > camA.Priority)
        {
         camA.Priority = 10;
        camB.Priority = 20;
        }
       else
        {
            camA.Priority = 20;
            camB.Priority = 10;
        }    
    }
}
