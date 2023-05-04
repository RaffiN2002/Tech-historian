using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARmenu : MonoBehaviour
{
        public void toPager(){
        SceneManager.LoadScene("Pager");
    }

    public void toVhst(){
        SceneManager.LoadScene("Vhstape");
    }

    public void toVhsp(){
        SceneManager.LoadScene("Vhsplayer");
    }

    public void toTypew(){
        SceneManager.LoadScene("Typewriter");
    }

    public void toFlop(){
        SceneManager.LoadScene("Floppydisk");
    }

    public void toNes(){
        SceneManager.LoadScene("Nes");
    }

    public void back(){
        SceneManager.LoadScene("SampleScene");
    }
}
