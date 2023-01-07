using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ThingCollision : MonoBehaviour
{
    public GameObject btn;
    public Text txt;
    GameObject tt;
    Image image;
    Texture2D texture1;
    Sprite sprite1;
    public string sname;
    void Start(){
        image=null;
        tt=GameObject.Find("Canvas");
        texture1 = Resources.Load<Texture2D>(sname);
        sprite1 = Sprite.Create(texture1, new Rect(0, 0, texture1.width, texture1.height), new Vector2(0.5f, 0.5f));
    }
    void OnCollisionEnter(Collision co){
        if(co.gameObject.tag=="Player"){
            btn.transform.gameObject.GetComponent<TMP_Text>().text="Task Completed";
            txt.text="You have completed this task.Thank you for your help.";
            int k=1;
            string num="box"+k;
            while(image==null){
                foreach (GameObject go in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[]){
                    if(go.name==num){
                        if(go.GetComponent<Image>().sprite==null) {
                            image=go.GetComponent<Image>();
                            break;
                        }
                        else {
                            k++;
                            num="box"+k;
                        }
                    } 
                }
            }
            
            image.sprite=sprite1;
            this.transform.gameObject.SetActive(false);
        }
    }
}
