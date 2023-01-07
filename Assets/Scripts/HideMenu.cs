using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HideMenu : MonoBehaviour
{
    public GameObject obj;
    public GameObject tm;
    void Start()
    {
        Button button = this.gameObject.GetComponent<Button>();
        button.onClick.AddListener(OnClick);
        tm.transform.gameObject.GetComponent<TMP_Text>().text="+";
        obj.SetActive(false);
    }

   void OnClick() {
		// 如果文本在展开状态
        if (tm.transform.gameObject.GetComponent<TMP_Text>().text=="-") {
            obj.SetActive(false);
            tm.transform.gameObject.GetComponent<TMP_Text>().text="+";
        }
        else {
            obj.SetActive(true);  
            tm.transform.gameObject.GetComponent<TMP_Text>().text="-";
            
        }
    }
}
