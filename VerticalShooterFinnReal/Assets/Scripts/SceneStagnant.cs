using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SceneStagnant : MonoBehaviour
{
    public int playerScore;
    [SerializeField] TextMeshProUGUI tmp;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.DontDestroyOnLoad(this);

    }
    private void Awake()
    {
        Debug.Log("awake");
    }

    // Update is called once per frame
    void Update()
    {
        tmp.text = playerScore.ToString();

    }
}
