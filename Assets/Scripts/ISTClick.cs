using System.Collections;
using UnityEngine;

public class ISTClick : MonoBehaviour
{
    private Transform sc;
    
    public void Start()
    {
        sc = GetComponent<Transform>();
    }

    public void ChangeScale()
    {
        StartCoroutine(Change(0.2f));
    }

    private IEnumerator Change(float value)
    {
        sc.localScale = new Vector3(0.9f, 0.9f, sc.localScale.z);
        yield return new WaitForSeconds(value);
        sc.localScale = new Vector3(1f, 1f, sc.localScale.z);
    }
}
