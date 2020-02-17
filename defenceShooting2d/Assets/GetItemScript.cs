using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItemScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int ItemGetLine = -10;
        if (this.transform.position.y <= ItemGetLine)
        {
            GetItem();
        }
    }

    public virtual bool GetItem()
    {
        return false;
    }

}
