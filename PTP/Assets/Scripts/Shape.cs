using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public string shapeName{
        get{return shapeName;}
        set{
            if(value == null || value.Trim() == " "){
                Debug.LogError("The shape name cant be empty");
            }
            else{
                m_ShapeName = value;
            }
        }
    }
    private string m_ShapeName;
    public Material material{
        get{return m_Material;}
        set {m_Material = value;}
    }
    private Material m_Material;
    public virtual IEnumerator DisplayText(){
        bool cycle = true;
        while(cycle){
        yield return new WaitForSeconds(3);
        Debug.Log("Im a " + m_ShapeName);
        }
       
    }

    protected  void AssignMaterial(){
         GetComponent<Renderer>().material = m_Material;
    } 

    public void Rotate(){
        transform.Rotate(55.0f, 0.0f, 0.0f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
