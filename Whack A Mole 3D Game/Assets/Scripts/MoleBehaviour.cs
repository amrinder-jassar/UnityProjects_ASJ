using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleBehaviour : MonoBehaviour
{
    Collider col;
    public int hitPoints = 1;
    public int score =1 ;
    [HideInInspector] public GameObject myParent;
    [HideInInspector] public Animator anim;

    public GameObject popupText;

    void Start()
    {
        anim = GetComponent<Animator>();
        col = GetComponent<Collider>();
        col.enabled = false;
    }
    public void DestroyObj()
    {
        myParent.GetComponent<HoleBehaviour>().hasMole = false;
        Destroy(gameObject);
    }
    public void SwitchCollider(int num)
    {
        col.enabled = (num == 0) ? false : true;
        //Any other number except for 0 is going to return true, but 0 is returning false.
    }
    
    //FOR POINTS
    public void GotHit()
    {
        hitPoints--;
        if (hitPoints>0)
        {
            col.enabled = true;
        }
        else
        {
            myParent.GetComponent<HoleBehaviour>().hasMole = false;
            ScoreManager.AddScore(score);

            GameObject pop = Instantiate(popupText) as GameObject;

            pop.transform.SetParent(UIManager.instance.transform,false);
            pop.transform.position = Camera.main.WorldToScreenPoint(transform.position);

            PopupText popText = pop.GetComponent<PopupText>();
            popText.ShowText(score);

            Destroy(gameObject);
        }
        
    }
}
