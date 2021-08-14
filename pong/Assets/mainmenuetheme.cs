using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenuetheme : MonoBehaviour
{
    public Scene scene;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<Audiomanager>().Play("menue");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

