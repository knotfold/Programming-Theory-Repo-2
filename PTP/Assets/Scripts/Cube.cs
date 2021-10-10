using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{  
    [SerializeField] string cubeName;
    [SerializeField] Material cubeMaterial;

    public override IEnumerator DisplayText()
    {  
        Debug.Log("hi");
        return base.DisplayText();
    }
    // Start is called before the first frame update
    void Start()
    {   
        shapeName = cubeName;
        material = cubeMaterial;
        AssignMaterial();
        StartCoroutine(DisplayText());
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }
}
