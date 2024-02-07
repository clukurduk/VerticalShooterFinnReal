using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UISceneManager : MonoBehaviour
{

    GameObject sceneStagnant;
    [SerializeField] private TextMeshProUGUI tmp;

    // Start is called before the first frame update
    void Start()
    {
        sceneStagnant = GameObject.Find("SceneStagnant");
        tmp.text = "Your Score Was " + sceneStagnant.GetComponent<SceneStagnant>().playerScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
