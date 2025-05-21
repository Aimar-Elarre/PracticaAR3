using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flechas : MonoBehaviour
{
    public List<GameObject> FlechasList;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject f in FlechasList)
        {
            f.SetActive(false);
        }
        FlechasList[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActivarFlecas(int indice)
    {
        if (indice >= FlechasList.Count)
        {
            FlechasList[indice - 1].SetActive(false);
        }
        else
        {
            FlechasList[indice].SetActive(true);
            FlechasList[indice - 1].SetActive(false);
        }
        
    }
}
