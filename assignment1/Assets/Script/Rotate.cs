using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    private Slider sliderRot;
    public float Rotmin;
    public float Rotmax;

    // Start is called before the first frame update
    void Start()
    {
        sliderRot = GameObject.Find("Rotator").GetComponent<Slider>();
        sliderRot.minValue = Rotmin;
        sliderRot.maxValue = Rotmax;

        sliderRot.onValueChanged.AddListener(Update1);   
    }

    // Update is called once per frame
    void Update1(float value)
    {
        transform.localEulerAngles = new Vector3(transform.rotation.x,value,transform.rotation.z);
    }
}
