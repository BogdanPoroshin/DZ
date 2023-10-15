using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrip : MonoBehaviour
{   public GameObject cube;
    public int counter = 10;
    public Text x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        counter--;
        x.text = counter.ToString();
    }
    public void whenButtonClick()
    {
        if (cube.activeInHierarchy == true)
        {
            cube.SetActive(false);
        }
        else
        {
            cube.SetActive(true);
        }
    }
}
