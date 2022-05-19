using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class forScenes : MonoBehaviour
{
    public string scenesname;
    private Button btnTarget;
    // Start is called before the first frame update
    void Start()
    {
        //get parent
        Transform parent = this.transform.parent;

        //scan child with parent 
        int count = parent.childCount;
        for (int i = 0; i < count; i++)
        {
            if (parent.GetChild(i).gameObject==this.gameObject)
            {
                btnTarget = parent.GetChild(i).GetComponent<Button>();
                if (btnTarget != null)
                {
                    btnTarget.onClick.AddListener(GoScenes);
                }
            }
        }




    }

    public void GoScenes()
    {
        SceneManager.LoadScene(scenesname);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
