using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    public DrawIceCream drawIceCreamScript;

    //flavors
    public GameObject strawberryPrefab;
    public GameObject chocolatePrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void flavorButtonStrawberry(){

        drawIceCreamScript.iceCreamPrefab = strawberryPrefab;
        print("strawberry");
    }

    public void flavorButtonChocolate(){

        drawIceCreamScript.iceCreamPrefab = chocolatePrefab;
        print("chocolate");

    }
}
