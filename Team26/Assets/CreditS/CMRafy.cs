using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CMRafy : MonoBehaviour
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

            SceneManager.LoadScene("Frank"); //Requires "Using" (see above)

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            SceneManager.LoadScene("TitleScene"); //Requires "Using" (see above)

        }




    }
}
