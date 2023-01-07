using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HidePackage : MonoBehaviour
{
    // Start is called before the first frame update
    int t;
    public GameObject obj;
    void Start()
    {
        Button button = this.gameObject.GetComponent<Button>();
        button.onClick.AddListener(OnClick);
        t=1;
        obj.SetActive(false);
    }

    // Update is called once per frame
    void OnClick() {
		// 如果文本在展开状态
        if (t==0) {
            obj.SetActive(false);
            t=1;
        }
        else {
            obj.SetActive(true);  
            t=0;
        }
    }
}
