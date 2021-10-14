using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
   
   [SerializeField] string uses;

    public override IEnumerator DisplayText()
    {
        Debug.Log("I am a " + shapeType + " named: " + shapeName + " that you can use for: " + uses);
        yield return new WaitForSeconds(5);
    }

    // Start is called before the first frame update
    void Start()
    {
        InitalizeShapeData();
        StartCoroutine(DisplayText());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
