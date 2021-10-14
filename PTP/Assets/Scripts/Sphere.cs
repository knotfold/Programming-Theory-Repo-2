using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    private float rotationSpeed = 500;
    public override IEnumerator DisplayText()
    {
        return base.DisplayText();
        
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
        Spin();
    }

    void Spin(){
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
    }
}
