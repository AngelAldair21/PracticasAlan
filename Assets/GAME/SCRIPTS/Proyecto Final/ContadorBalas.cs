using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ContadorBalas : MonoBehaviour
{
    
    private TextMeshProUGUI cantidadBalasTexto;
 

    private void Start()
    {
        cantidadBalasTexto = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        cantidadBalasTexto.text = GameManager.Instance.balas.ToString("0");
    }

    public void SumarBalas(int cantidadBalas)
    {
        GameManager.Instance.balas += cantidadBalas;
    }
}
