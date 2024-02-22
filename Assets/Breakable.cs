using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    public List<GameObject> breakablePieces;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in breakablePieces)
        {
            item.SetActive(false);
        }
        
    }

    public void Break()
    {
        foreach (var item in breakablePieces)
        {
            item.SetActive(true);
            item.transform.parent = null;
        }

        gameObject.SetActive(false);    
    }
}
