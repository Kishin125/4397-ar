using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scale1 : MonoBehaviour
{
    public GameObject car;
    public GameObject sword;
    private Slider sliderscale1;
    public float scalemin1;
    public float scalemax1;

    // Start is called before the first frame update
    void Start()
    {
        sliderscale1 = GameObject.Find("Scaler").GetComponent<Slider>();
        sliderscale1.minValue = scalemin1;
        sliderscale1.maxValue = scalemax1;

        if(car.activeSelf){
            sliderscale1.onValueChanged.AddListener(Update2);
        }
        
        
    }

    // Update is called once per frame
    void Update2(float value)
    {
        if(car.activeSelf){
            transform.localScale = new Vector3(value,value,value);
        }
        
    }
}
