using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button btnPlayerGame;
    // Start is called before the first frame update
    private void Awake() {
        btnPlayerGame.onClick.AddListener(playGame);
    }
    private void playGame(){
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
