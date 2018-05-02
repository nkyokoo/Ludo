using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.scripts.ui
{


public class ErrorMesage : MonoBehaviour
{
    public GameObject errorBox;
    public GameObject errorText;
    private string errormessage;
    private Image errorImage;
    private Text txt;
	// Use this for initialization
	void Start () {
	    txt = errorText.GetComponent<Text>();
	    errorImage = GetComponent<Image>();
	    errorImage.enabled = false;
	    txt.enabled = false;
        }

    // Update is called once per frame
    void Update ()
    {
       Errormessage();
        errorImage.enabled = false;
        txt.enabled = false;
    }

    public IEnumerator Errormessage()
    {
        if (errormessage != null || errormessage != "")
        {
            txt.text = errormessage;
            txt.enabled = true;
            errorImage.enabled = true;
            for (int i = 0; i > 10; i++)
            {
                transform.Translate(Vector3.forward * Time.deltaTime);

            }
        }
            yield return new WaitForSeconds(10);    
        }
    public void SetErrorMessage(String text)
    {
        errormessage = text;
    }
  }
}
