using UnityEngine;
using TMPro;

public class TimerUI : MonoBehaviour
{
    public TextMeshProUGUI textoTiempo;
    float tiempo = 0f;

    void Update()
    {
        tiempo += Time.deltaTime;
        textoTiempo.text = "Tiempo: " + tiempo.ToString("F2");
    }
}