using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivarObejcto : MonoBehaviour
{
    public GameObject Ativar;
    public int podeApertar = 0;

    private void Start()
    {
        Ativar.SetActive(false);
    }

    public void ApertarBotao()
    {
        
        podeApertar = 1;
        Debug.Log($"{podeApertar}");
        if (podeApertar == 1)
        {
            Ativar.SetActive(true);
            podeApertar = 0;
        }
        if (podeApertar == 0)
        {
            Ativar.SetActive(false);
        }
        
    }
}
