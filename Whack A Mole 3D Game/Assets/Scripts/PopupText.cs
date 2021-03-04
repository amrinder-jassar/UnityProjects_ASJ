using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupText : MonoBehaviour
{
    public Text popupText;// To ADD +1 with Animation at HIT
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        AnimatorClipInfo[] info = anim.GetCurrentAnimatorClipInfo(0);
        Destroy(gameObject,info[0].clip.length);
    }
    public void ShowText(int amount)
    {
        //if amount>0 return put + signin front otherwise use negative no ind front.
        popupText.text = (amount > 0) ? "+" + amount : amount.ToString();
    }
}
