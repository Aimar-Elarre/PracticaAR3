using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MostrarNumeroSlider : MonoBehaviour
{
    private float numeros = 0;

    public TextMeshProUGUI textUGUI;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();

        slider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    void OnSliderValueChanged(float value)
    {
        Debug.Log("Nuevo valor del slider: " + value);
        numeros = value;
    }

    // Update is called once per frame
    void Update()
    {
        textUGUI.text = numeros.ToString();
    }
}
