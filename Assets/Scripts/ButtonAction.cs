using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAction : MonoBehaviour
{
    public Text expandText;
    private int frame = 30;  
    private float height = 180;
    void Start()
    {
        Button button = this.gameObject.GetComponent<Button>();
        button.onClick.AddListener(OnClick);
		// 开始时文本收起
        StartCoroutine(FoldText());
    }

    IEnumerator FoldText() {
		// 获取文本底部坐标
        float textY = height;
		// 按帧收起文本
        for (int i = 0; i < frame; ++i) {
            textY -= height / frame;
            expandText.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Right, 0, expandText.rectTransform.sizeDelta.x);
            expandText.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom, 0, textY);
            if (i == frame - 1) {
                expandText.gameObject.SetActive(false);
            }
            yield return null;
        }
    }

     IEnumerator UnfoldText() {
		// 获取文本底部坐标
        float textY = 0;
		// 按帧展开文本
        for (int i = 0; i < frame; ++i) {
            textY += height / frame;
            expandText.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Right, 0, expandText.rectTransform.sizeDelta.x);
            expandText.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom, 0, textY);
            if (i == 0) {
                expandText.gameObject.SetActive(true);
            }
            yield return null;
        }
    }

	// 点击事件
    void OnClick() {
		// 如果文本在展开状态
        if (expandText.gameObject.activeSelf) {
			// 使用协程收起
            StartCoroutine(FoldText());
        }
        else {
			// 使用协程展开
            StartCoroutine(UnfoldText());
        }
    }
}
