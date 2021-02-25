using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scale : MonoBehaviour
{
    public GameObject car;
    public GameObject sword;
    private Slider sliderscale;
    public float scalemin;
    public float scalemax;

    // Start is called before the first frame update
    void Start()
    {
        sliderscale = GameObject.Find("Scaler").GetComponent<Slider>();
        sliderscale.minValue = scalemin;
        sliderscale.maxValue = scalemax;

        if(sword.activeSelf){
            
            sliderscale.onValueChanged.AddListener(Update3);
        }
        
        
    }

    // Update is called once per frame
    void Update3(float value)
    {   Debug.Log(sliderscale.value);
        if(sword.activeSelf){
            transform.localScale = new Vector3(value,value,value);
        }
        
    }
}
