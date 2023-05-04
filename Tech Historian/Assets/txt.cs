using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class txt : MonoBehaviour
{
    public GameObject pager_panel;
    public GameObject vhs_panel;
    public GameObject vhsp_panel;
    public GameObject typew_panel;
    public GameObject flop_panel;
    public GameObject nes_panel;

    public void PagerFound(){
        pager_panel.SetActive(true);
    }

    public void PagerLost(){
        pager_panel.SetActive(false);
    }

    public void VhsFound(){
        vhs_panel.SetActive(true);
    }

    public void VhsLost(){
        vhs_panel.SetActive(false);
    }

    public void VhspFound(){
        vhsp_panel.SetActive(true);
    }

    public void VhspLost(){
        vhsp_panel.SetActive(false);
    }

    public void TypewFound(){
        typew_panel.SetActive(true);
    }

    public void TypewLost(){
        typew_panel.SetActive(false);
    }

    public void FlopFound(){
        flop_panel.SetActive(true);
    }

    public void FlopLost(){
        flop_panel.SetActive(false);
    }

    public void NesFound(){
        nes_panel.SetActive(true);
    }

    public void NesLost(){
        nes_panel.SetActive(false);
    }

    public void back(){
        SceneManager.LoadScene("SampleScene");
    }
}
