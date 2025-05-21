using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventOnColisionFlecha : MonoBehaviour
{
    public UnityEvent<int> colisonevento = new UnityEvent<int>();
    public int indice = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        colisonevento.Invoke(indice);
    }
}
