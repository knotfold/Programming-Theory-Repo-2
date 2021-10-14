using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{

    [SerializeField] Material[] colors;
    protected bool error = false;

    public string shapeType
    {
        get { return m_shapeType; }
        set { m_shapeType = value; }
    }


    private string m_shapeType;


    public string shapeName
    {
        get { return m_ShapeName; }
        set
        {
            if (value == null || value.Trim() == "")
            {
                Debug.LogError("The shape name cant be empty");
                error = true;
            }
            else
            {
                m_ShapeName = value;
            }
        }
    }

    [SerializeField]
    private string m_ShapeName;
    public Material material
    {
        get { return m_Material; }
        [SerializeField]
        set
        {
            if (value == null)
            {
                Debug.LogError("Material can not be null");
                error = true;
            }
            else
            {
                m_Material = value;
            }
        }
    }

    [SerializeField]
    private Material m_Material;
    public virtual IEnumerator DisplayText()
    {
        if (error)
        {
            yield return new WaitForSeconds(0);
        }
        bool cycle = true;
        while (cycle)
        {
            yield return new WaitForSeconds(4);
            Debug.Log("Im a " + m_shapeType);
        }

    }

    protected virtual void InitalizeShapeData()
    {
        if (error)
        {
            return;
        }
        AssignShapeType();
        AssignMaterial();
    }

    private void AssignShapeType()
    {
        shapeType = gameObject.tag;
    }

    private void AssignMaterial()
    {
        GetComponent<Renderer>().material = m_Material;
    }



    protected void Rotate()
    {
        if (error)
        {
            return;
        }
        transform.Rotate(55.0f, 0.0f, 0.0f);


    }

    protected void ChangeMaterial()
    {
        if (error)
        {
            return;
        }
        if (colors.Length == 0)
        {
            Debug.LogError("The material color list is empty therefor the change material methot can not be used");
        }
        int randomIndex = Random.Range(0, colors.Length);
        gameObject.GetComponent<MeshRenderer>().material = colors[randomIndex];
        float randomScale = Random.Range(50f, 100f);
        transform.localScale = new Vector3(randomScale, randomScale, randomScale);
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
