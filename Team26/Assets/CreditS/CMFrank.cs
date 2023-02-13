using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CMFrank : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            SceneManager.LoadScene("Maria"); //Requires "Using" (see above)

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            SceneManager.LoadScene("Rafy"); //Requires "Using" (see above)

        }
    }
}
