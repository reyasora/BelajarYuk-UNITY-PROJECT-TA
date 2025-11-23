using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    //private Animator anim;
    //void Start() { 
    //    anim = GetComponent<Animator>();
    //}
    public void loadScene()
    {
        SceneManager.LoadScene("MenuGame");
    }

    public void slideDua()
    {
        SceneManager.LoadScene("MenuGame 2");
    }

    //susun kata SLIDE 1
    public void susunKata() //level 1 hewan
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void susunKataLevel2() //level 2 hewan
    {
        SceneManager.LoadScene("HewanSedang");
    }

    public void susunKataLevel3() //level 3 hewan
    {
        SceneManager.LoadScene("HewanSulit");
    }
    // PEMBATAS

    // flip card 
    public void flipCard() //flipcard level1
    {
        SceneManager.LoadScene("FlipCard");
    }

    public void flipCardLevel2() //flipcard level2
    {
        SceneManager.LoadScene("FlipCardHewan2");
    }

    public void flipCardLevel3() //flipcard level3
    {
        SceneManager.LoadScene("FlipCardHewan3");
    }

    public void flipCardLevel4()
    {
        SceneManager.LoadScene("FlipCardHewan4");
    }

    // PEMBATAS

    public void buah()
    {
        SceneManager.LoadScene("Buah");
    }
    
    public void buahLevel2()
    {
        SceneManager.LoadScene("BuahSedang");
    }
    
    public void buahLevel3()
    {
        SceneManager.LoadScene("BuahSulit");
    }

    //PEMBATAS

    public void benderaLevel1()
    {
        SceneManager.LoadScene("Bendera");
    }

    // PEMBATAS

    public void bendaLevel1()
    {
        SceneManager.LoadScene("Benda");
    }

    public void bendaLevel2()
    {
        SceneManager.LoadScene("BendaSedang");
    }

    //susun kata SLIDE 2

    public void warnaLevel()
    {
        SceneManager.LoadScene("ColorScene");
    }

    public void profesiLevel()
    {
        SceneManager.LoadScene("ProfesiScene");
    }
    public void foodLevel()
    {
        SceneManager.LoadScene("FoodScene");
    }
    public void carLevel()
    {
        SceneManager.LoadScene("KendaraanScene");
    }

    public void flipCardDua()
    {
        SceneManager.LoadScene("FlipCardScene2");
    }

    public void flipCardDuad()
    {
        SceneManager.LoadScene("FlipCard2Scene2");
    }

    public void flipCardDuadd()
    {
        SceneManager.LoadScene("FlipCard3Scene2");
    }

    public void flipCardDuaddd()
    {
        SceneManager.LoadScene("FlipCard4Scene2");
    }

    // PEMBATAS
    public void tampilanAwal()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Keluar");
    }
}