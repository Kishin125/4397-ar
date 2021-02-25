using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate1 : MonoBehaviour
{
    private Slider sliderRot1;
    public float Rotmin;
    public float Rotmax;

    // Start is called before the first frame update
    void Start()
    {
        sliderRot1 = GameObject.Find("Rotator").GetComponent<Slider>();
        sliderRot1.minValue = Rotmin;
        sliderRot1.maxValue = Rotmax;

        sliderRot1.onValueChanged.AddListener(Update1);   
    }

    // Update is called once per frame
    void Update1(float value)
    {
        transform.localEulerAngles = new Vector3(transform.rotation.x,value,transform.rotation.z);
    }
}
