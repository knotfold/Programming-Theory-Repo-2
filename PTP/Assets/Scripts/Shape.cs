using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    [SerializeField] string name;
    [SerializeField] Material material;
    public virtual IEnumerator DisplayText(){
        bool cycle = true;
        while(cycle){
        yield return new WaitForSeconds(3);
        Debug.Log("Im a " + name);
        }
       
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
