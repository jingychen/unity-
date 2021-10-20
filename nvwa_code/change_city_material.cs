using System.Collections.Generic;
using UnityEngine;
public class Test : MonoBehaviour
{
    Dictionary<Transform, Material[]> objOriginMatDictionary = new Dictionary<Transform, Material[]>();
    Dictionary<Transform, Material[]> objMatDictionary = new Dictionary<Transform, Material[]>();
    Dictionary<Transform, Material[]> redMatDictionary = new Dictionary<Transform, Material[]>();
    Material _redMat;
    bool ifChangeChild = true;
    public bool IfBuLingBuLing;
    float shake;
    private void Awake()
    {
        _redMat = Resources.Load<Material>("blueHolo");
    }
    private void Start()
    {
        if (ifChangeChild)
        {
            objOriginMatDictionary.Add(transform, transform.GetComponent<MeshRenderer>().materials);
            objMatDictionary.Add(transform, transform.GetComponent<MeshRenderer>().materials);
            redMatDictionary.Add(transform, RedMaterials(transform));
            if (transform.childCount != 0)
            {
                CheckChild(transform);
            }
        }
    }
    //循环查找子物体存入字典
    public void CheckChild(Transform TF)
    {
        if (TF.childCount != 0)
        {
            for (int i = 0; i < TF.childCount; i++)
            {
                objOriginMatDictionary.Add(TF.GetChild(i), TF.GetChild(i).GetComponent<MeshRenderer>().materials);
                objMatDictionary.Add(TF.GetChild(i), TF.GetChild(i).GetComponent<MeshRenderer>().materials);
                redMatDictionary.Add(TF.GetChild(i), RedMaterials(TF.GetChild(i)));
                CheckChild(TF.GetChild(i));
            }
        }
    }
    public Material[] RedMaterials(Transform tra)
    {
        Material[] matRedArray = new Material[tra.GetComponent<MeshRenderer>().materials.Length];

        for (int i = 0; i < matRedArray.Length; i++)
        {
            matRedArray[i] = _redMat;
        }
        return matRedArray;
    }
    void Update()
    {
        if (IfBuLingBuLing)
        {
            shake += Time.deltaTime;
            if (shake % 0.5f > 0.25f)
            {
                foreach (Transform item in objMatDictionary.Keys)
                {
                    item.GetComponent<MeshRenderer>().materials = redMatDictionary[item];
                }
            }
            else
            {
                foreach (Transform item in objMatDictionary.Keys)
                {
                    item.GetComponent<MeshRenderer>().materials = objOriginMatDictionary[item];
                }
            }
        }
    }
    private void OnDisable()
    {
        foreach (Transform item in objMatDictionary.Keys)
        {
            item.GetComponent<MeshRenderer>().materials = objOriginMatDictionary[item];
        }
    }
}