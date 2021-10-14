using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cube : Shape
{
    

    // POLYMORPHISM
    public override IEnumerator DisplayText()
    {
        
            Debug.Log("hi i am  " + shapeType + " named: " + shapeName + "and i like to mutate");
       
            return base.DisplayText();
        

    }
    // Start is called before the first frame update
    void Start()
    {
        
        // shapeName = cubeName;
        // material = cubeMaterial;
        InitalizeShapeData();
        StartCoroutine(DisplayText());
         InvokeRepeating("ChangeMaterial", 0.2f, 2.0f);
         InvokeRepeating("Rotate", 1f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
      
      
    }
}
