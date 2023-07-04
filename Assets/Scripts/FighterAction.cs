using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterAction : MonoBehaviour {
    
    private GameObject hero;
    private GameObject enemy;

    [SerializeField] private GameObject meleePrefab;
    [SerializeField] private GameObject magicPrefab;
    [SerializeField] private Sprite faceIcon;

    private GameObject currentAttack;

    void Awake() {
        hero = GameObject.FindGameObjectWithTag("Hero");
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    public void SelectAttack(string btn) {
        
        GameObject victim = tag == "Hero" ? enemy : hero;

        if(btn.CompareTo("melee") == 0) {
            meleePrefab.GetComponent<Attack>().UseAttack(victim);
        }
        else if(btn.CompareTo("magic") == 0) {
            magicPrefab.GetComponent<Attack>().UseAttack(victim);
        } else{
            Debug.Log("Run");
        }
    }
}
