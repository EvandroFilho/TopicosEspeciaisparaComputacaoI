using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    public int germQnt;
    private GameMaster gm;



    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void germRemoved(){
        germQnt -= 1;
        if (germQnt == 0){
            gm.removeDish();
            Destroy(gameObject);
        }
    }
}
