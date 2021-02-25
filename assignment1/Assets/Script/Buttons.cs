using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slidea;
    public GameObject sword;
    public GameObject car;

    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(PressIt);
        //sword.SetActive(true);
        //car.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PressIt(){
        if(sword.activeSelf){
            sword.SetActive(false);


            car.SetActive(true);
            Debug.Log("sword is not active");
            
        }
        else{
            car.SetActive(false);


            sword.SetActive(true);
            Debug.Log("car is not active");
        }
    }
}
