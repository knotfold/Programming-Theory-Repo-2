using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    

    public override IEnumerator DisplayText()
    {
        
            Debug.Log("hi i am  " + shapeType + " named: " + shapeName);
       
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
