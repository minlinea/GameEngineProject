using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Hint : MonoBehaviour
{
    public GameObject Hintimage;

    // Start is called before the first frame update

    public void ShowHint()
    {
        if(Hintimage.active == false)
            Hintimage.SetActive(true);
        else
            Hintimage.SetActive(false);
    }

    void Start()
    {
        Hintimage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
